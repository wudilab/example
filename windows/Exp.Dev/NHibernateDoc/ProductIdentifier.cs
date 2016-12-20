using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateDoc
{
    [Serializable]
    public class ProductIdentifier
    {
        public virtual int StoreID { get; set; }
        public virtual int ProductID { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            ProductIdentifier id;
            id = (ProductIdentifier)obj;
            if (id == null)
                return false;
            if (StoreID == id.StoreID && ProductID == id.ProductID)
                return true;
            return false;
        }

        public override int GetHashCode()
        {
            return (StoreID + "|" + ProductID).GetHashCode();
        }
    }
}
