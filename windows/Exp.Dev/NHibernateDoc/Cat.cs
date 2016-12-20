using System;
using NHibernate;
using NHibernate.Classic;

namespace NHibernateDoc
{
    public class Cat : ILifecycle
    {
        private string id;
        private string name;
        private char sex;
        private float weight;

        public Cat()
        {
        }

        public virtual string Id
        {
            get { return id; }
            set { id = value; }
        }

        public virtual string Name
        {
            get { return name; }
            set { name = value; }
        }

        public virtual char Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        public virtual float Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        //@example: NHibernate - ILifecycle Callback for NHibernate
        public virtual LifecycleVeto OnDelete(ISession s)
        {
            Console.WriteLine("OnDelete");
            return LifecycleVeto.NoVeto;
        }

        public virtual void OnLoad(ISession s, object id)
        {
            Console.WriteLine("OnLoad");
        }

        public virtual LifecycleVeto OnSave(ISession s)
        {
            Console.WriteLine("OnSave");
            return LifecycleVeto.NoVeto;
        }

        public virtual LifecycleVeto OnUpdate(ISession s)
        {
            Console.WriteLine("OnSave");
            return LifecycleVeto.NoVeto;
        }
    }
}