using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Driver;
using NHibernate.Dialect;
using NHibernate.Connection;
using System.Reflection;
using NHibernate.Linq;

namespace DBTest1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            DisplayData();
            //using (var session = NHibernateHelper.OpenSession())
            //{
            //    using (var tran = session.BeginTransaction())
            //    {
            //        var query = session.Query<Student>().ToList();
            //        dataGridView1.DataSource = query;

            //        tran.Commit();
            //    }
            //}

            //Configuration config = new Configuration();
            //ISessionFactory factory;

            //config.SetProperty(NHibernate.Cfg.Environment.ConnectionProvider, "NHibernate.Connection.DriverConnectionProvider");
            //config.SetProperty(NHibernate.Cfg.Environment.Dialect, "NHibernate.Dialect.MsSql2012Dialect");
            //config.SetProperty(NHibernate.Cfg.Environment.ConnectionDriver, "NHibernate.Driver.SqlClientDriver");
            //config.SetProperty(NHibernate.Cfg.Environment.ConnectionString, "Server=ROBOX;Database=StudentsTestApp;Integrated Security=true;");

            //config.AddAssembly("DBTest1");

            //factory = config.BuildSessionFactory();

            //ISession session = null;

            //try
            //{
            //    session = factory.OpenSession();
            //    dataGridView1.DataSource = session.Query<Student>().ToList();
            //}
            //catch (Exception ex)
            //{

            //    session.Close();

            //    MessageBox.Show(ex.Message, "nhibernate error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string name = NameTextBox.Text;
            int age = int.Parse(AgeTextBox.Text);

            var student = new Student();
            student.Names = name;
            student.Age = age;

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

                    dataGridView1.DataSource = query;

                    transaction.Commit();
                }
            }
        }
    }
}
