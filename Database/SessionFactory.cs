using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database;
using Database.Classes;

namespace Database
{

    public class SessionFactory
    {
        private static string ConnectionString = "Server=localhost;Port=3306;Database=leilao;Uid=root;Pwd=admin123;SslMode=none;";
        private static ISessionFactory session;

        public static ISessionFactory CreateSession()
        {
            if (session != null)
            {
                return session;
            }

            IPersistenceConfigurer dbConfig = MySQLConfiguration.Standard.ConnectionString(ConnectionString);


            var mapConfig = Fluently.Configure().Database(dbConfig).Mappings(c => c.FluentMappings.AddFromAssemblyOf<Classes.Usuario_Mapping>());

            session = mapConfig.BuildSessionFactory();

            return session;
        }

        public static ISession StartSession()
        {
            return CreateSession().OpenSession();
        }
    }
}