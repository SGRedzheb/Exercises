using System;
using System.Linq;
using System.Windows.Forms;
using NHibernate.Linq;
using System.Text;
using System.Data;

namespace DBTest1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            DisplayData();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(NameTextBox.Text)
                || string.IsNullOrEmpty(AgeTextBox.Text)))
            {
                string name = NameTextBox.Text;
                int age = int.Parse(AgeTextBox.Text);

                SaveRecord(name, age);
                DisplayData();
                ClearTextBoxes();
            }
            else
            {
                ShowMessage();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                int selectedHamalId;
                Int32.TryParse(row.Cells[0].Value.ToString(), out selectedHamalId);

                DeleteRecord(selectedHamalId);
            }

            DisplayData();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                int selectedHamalId;
                Int32.TryParse(row.Cells[0].Value.ToString(), out selectedHamalId);

                if (!(string.IsNullOrEmpty(NameTextBox.Text)
                    || string.IsNullOrEmpty(AgeTextBox.Text)))
                {
                    UpdateRecord(selectedHamalId);
                }
                else
                {
                    ShowMessage();
                }
            }
        }

        private void SaveRecord(string name, int age)
        {
            var hamal = new Hamali();
            hamal.Name = name;
            hamal.Age = age;

            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Save(hamal);

                    transaction.Commit();
                }
            }
        }

        private void UpdateRecord(int hamalId)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var item = session.Load<Hamali>(hamalId);

                    item.Name = NameTextBox.Text;
                    item.Age = int.Parse(AgeTextBox.Text);

                    session.SaveOrUpdate(item);

                    transaction.Commit();
                }
            }

            DisplayData();
            ClearTextBoxes();
        }

        private void DeleteRecord(int selectedStudentId)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var item = session.Load<Hamali>(selectedStudentId);

                    session.Delete(item);

                    transaction.Commit();
                }
            }
        }

        public void DisplayData()
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var query = session.Query<Hamali>()
                        .ToList();

                    DataTable dt = new DataTable();
                    dt.Columns.Add("Id");
                    dt.Columns.Add("Hamal");
                    dt.Columns.Add("Age");
                    dt.Columns.Add("Tools");
                    var sb = new StringBuilder();
                    foreach (var hamal in query)
                    {
                        DataRow row = dt.NewRow();

                        row["Id"] = hamal.Id;
                        row["Hamal"] = hamal.Name;
                        row["Age"] = hamal.Age;

                        sb = new StringBuilder();

                        if (hamal.Tools.Count > 0)
                        {
                            foreach (var item in hamal.Tools)
                            {
                                sb.Append(item.ToolName);
                                sb.Append(", ");
                            }

                            sb.Remove(sb.Length - 2, 2);
                        }
                        

                        row["Tools"] = sb.ToString();

                        dt.Rows.Add(row);
                    }

                    dataGridView1.DataSource = dt;

                    transaction.Commit();
                }
            }
        }

        private void ClearTextBoxes()
        {
            NameTextBox.Text = "";
            AgeTextBox.Text = "";
        }

        private void ShowMessage()
        {
            MessageBox.Show("Name or Age field can't be empty.", "Required fields", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                var selectedItem = (row.DataBoundItem) as Hamali;
                string name = row.Cells[1].Value.ToString();

                string age = row.Cells[2].Value.ToString();

                NameTextBox.Text = name;
                AgeTextBox.Text = age.ToString();
            }
        }
    }
}
