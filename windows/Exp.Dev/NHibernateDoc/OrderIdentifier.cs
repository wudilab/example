using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateDoc
{
    [Serializable]
    public class OrderIdentifier
    {
        public virtual int StoreID { get; set; }
        public virtual int ProductID { get; set; }
        public virtual int OrderID { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            OrderIdentifier id;
            id = (OrderIdentifier)obj;
            if (id == null)
                return false;
            if (StoreID == id.StoreID &&
            ProductID == id.ProductID && OrderID == id.OrderID)
                return true;
            return false;
        }

        public override int GetHashCode()
        {
            return (StoreID + "|" +
            ProductID + "|" + OrderID).GetHashCode();
        }
    }
}
