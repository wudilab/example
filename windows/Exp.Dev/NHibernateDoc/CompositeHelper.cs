using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateDoc
{
    public class CompositeHelper
    {
        //@example: nhibernate - composite id and foreign key as composite id example
        //https://www.codeproject.com/tips/419780/nhibernate-mappings-for-composite-keys-with-associ
        public static void main()
        {
            ISession session = NHibernateHelper.GetCurrentSession();

            ITransaction tx = session.BeginTransaction();

            var products1 = session.CreateSQLQuery("SELECT * FROM Products").AddEntity(typeof(Products)).List<Products>();

            Console.WriteLine(products1.Count);

            NHibernateHelper.CloseSession();
        }
    }
}
