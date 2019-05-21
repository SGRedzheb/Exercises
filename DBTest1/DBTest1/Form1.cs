using System;
using System.Linq;
using System.Windows.Forms;
using NHibernate.Linq;
using NHibernate;

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
            string name = NameTextBox.Text;
            int age = int.Parse(AgeTextBox.Text);
            //int id = int.Parse(IdTextBox.Text);

            var student = new Student();
            student.Name = name;
            student.Age = age;
            //student.Id = id;
            

            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Save(student);


                    transaction.Commit();
                }
            }

            DisplayData();
        }

        public void DisplayData()
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var query = session.Query<Student>()
                        .ToList();

                    //var query = session.CreateSQLQuery("SELECT * FROM \"testDB2schema\".\"Student\"")
                    //    .AddScalar("Id", NHibernateUtil.Int64)
                    //    .AddScalar("Names", NHibernateUtil.String)
                    //    .AddScalar("Age", NHibernateUtil.Int64);

                    //var query = session.CreateSQLQuery("SELECT * FROM \"testDB2schema\".\"Student\"")
                    //    .AddEntity(typeof(Student));



                    dataGridView1.DataSource = query;

                    transaction.Commit();
                }
            }
        }
    }
}
