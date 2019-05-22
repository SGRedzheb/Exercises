using System;
using System.Linq;
using System.Windows.Forms;
using NHibernate.Linq;

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
                var selectedStudent = (Student)(row.DataBoundItem);

                DeleteRecord(selectedStudent);
            }

            DisplayData();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                var selectedItem = (row.DataBoundItem) as Student;

                if (!(string.IsNullOrEmpty(NameTextBox.Text) 
                    || string.IsNullOrEmpty(AgeTextBox.Text)))
                {
                    UpdateRecord(selectedItem.Id);
                }
                else
                {
                    ShowMessage();
                }
            }
        }

        private void SaveRecord(string name, int age)
        {
            var student = new Student();
            student.Name = name;
            student.Age = age;

            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Save(student);

                    transaction.Commit();
                }
            }
        }

        private void UpdateRecord(int index)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var item = session.Load<Student>(index);

                    item.Name = NameTextBox.Text;
                    item.Age = int.Parse(AgeTextBox.Text);

                    session.SaveOrUpdate(item);

                    transaction.Commit();
                }
            }

            DisplayData();
            ClearTextBoxes();
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                var selectedItem = (row.DataBoundItem) as Student;

                NameTextBox.Text = selectedItem.Name;
                AgeTextBox.Text = selectedItem.Age.ToString();
            }
        }

        private void DeleteRecord(Student selectedStudent)
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var item = session.Load<Student>(selectedStudent.Id);

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
                    var query = session.Query<Student>()
                        .ToList();

                    dataGridView1.DataSource = query;

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
    }
}
