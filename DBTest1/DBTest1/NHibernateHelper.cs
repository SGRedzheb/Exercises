using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Dialect;
using NHibernate.Driver;
using System.Reflection;

namespace DBTest1
{
    public class NHibernateHelper
    {
        private static ISessionFactory _sessionFactory;

        private static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                {
                    _sessionFactory = new Configuration()
                .DataBaseIntegration(x =>
                {
                    x.ConnectionString = "Server=ROBOX;Database=StudentsTestApp;Integrated Security=true;";
                    x.Dialect<MsSql2012Dialect>();
                    x.Driver<SqlClientDriver>();
                }).AddAssembly(Assembly.GetExecutingAssembly())
                .BuildSessionFactory();

                    //var configuration = new Configuration();
                    //configuration.Configure();
                    //configuration.AddAssembly(typeof(Student).Assembly);
                    //_sessionFactory = configuration.BuildSessionFactory();
                }
                return _sessionFactory;
            }
        }

        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
    }
}
