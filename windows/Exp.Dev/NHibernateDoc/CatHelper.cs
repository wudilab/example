using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateDoc
{
    public class CatHelper
    {
        public static void main()
        {
            ISession session = NHibernateHelper.GetCurrentSession();

            ITransaction tx = session.BeginTransaction();

            Cat princess = new Cat();
            princess.Name = "Princess";
            princess.Sex = 'F';
            princess.Weight = 7.4f;

            session.Save(princess);
            tx.Commit();

            //@example: NHibernate HQL - CreateQuery run sql directly from NHibernate
            IList<Cat> cats = session.CreateQuery("from Cat b where b.Sex = :title")
                .SetParameter("title", "F")
                .List<Cat>();

            Console.WriteLine(cats.Count);

            //@example: NHibernate Call SQL directly
            var cats1 = session.CreateSQLQuery("SELECT * FROM CAT").AddEntity(typeof(Cat)).List<Cat>();

            //@example: NHibernate - update Sql statement with parameters - query.ExecuteUpdate() to update sql statement
            var query = session.CreateQuery("update Cat set Weight = :Weight where CatId = :Id").SetParameter("Weight", 7.5).SetParameter("Id", "882326ff52074780abfbd3c9f928f615");
            query.ExecuteUpdate();

            NHibernateHelper.CloseSession();
        }
    }
}
