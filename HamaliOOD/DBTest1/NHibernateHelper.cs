﻿using NHibernate;
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
                    var cfg = new Configuration().Configure();
                    _sessionFactory = cfg.BuildSessionFactory();

                //    _sessionFactory = new Configuration()
                //.DataBaseIntegration(x =>
                //{
                //    //x.ConnectionString = "Server=ROBOX;Database=StudentsTestApp;Integrated Security=true;";
                //    x.ConnectionString = "DSN=TESTDB2;UID=db2admin;PWD=12345;";
                //    //x.ConnectionString = "Server=localhost:50000;Database=TESTDB2;UID=db2admin;PWD=12345;";
                //    x.Dialect<DB2Dialect>();
                //    x.Driver<OdbcDriver>();
                    
                //}).AddAssembly(Assembly.GetExecutingAssembly())
                //.BuildSessionFactory();
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
