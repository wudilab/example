using NHibernate;
using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateDoc
{
    public sealed class NHibernateHelper
    {
        private const string CurrentSessionKey = "nhibernate.current_session";
        private static readonly ISessionFactory sessionFactory;
        private static ISession currentSession = null;

        static NHibernateHelper()
        {
            sessionFactory = new Configuration().Configure().BuildSessionFactory();
        }

        public static ISession GetCurrentSession()
        {
            //HttpContext context = HttpContext.Current;
            //ISession currentSession = context.Items[CurrentSessionKey] as ISession;

            //if (currentSession == null)
            //{
                currentSession = sessionFactory.OpenSession();
                //context.Items[CurrentSessionKey] = currentSession;
            //}

            return currentSession;
        }

        public static void CloseSession()
        {
            //HttpContext context = HttpContext.Current;
            //ISession currentSession = context.Items[CurrentSessionKey] as ISession;

            //if (currentSession == null)
            //{
            //    // No current session
            //    return;
            //}

            currentSession.Close();
            //context.Items.Remove(CurrentSessionKey);
        }

        public static void CloseSessionFactory()
        {
            if (sessionFactory != null)
            {
                sessionFactory.Close();
            }
        }
    }
}
