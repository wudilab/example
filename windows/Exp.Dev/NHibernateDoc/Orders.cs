using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateDoc
{
    [Serializable]
    public class Orders
    {
        public virtual OrderIdentifier OrderIdentifier { get; set; }

        public virtual int Amount { get; set; }

        public virtual Products Products { get; set; }
    }
}
