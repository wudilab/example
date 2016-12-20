using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateDoc
{
    [Serializable]
    public class Products
    {
        private int storeId;
        private int productId;
        private string productName;

        public Products()
        {

        }

        public virtual ISet<Orders> Orders { get; set; }

        public virtual ProductIdentifier ProductIdentifier { get; set; }

        /// <summary>
        ///
        /// </summary>
        public virtual int StoreID
        {
            get { return storeId; }
            set { storeId = value; }
        }

        /// <summary>
        ///
        /// </summary>
        public virtual int ProductID
        {
            get { return productId; }
            set { productId = value; }
        }

        /// <summary>
        ///
        /// </summary>
        public virtual string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }
    }
}
