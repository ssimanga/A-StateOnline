using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_StateOnline.Core.Models
{
   public class Cart : BaseEntity
    {
        public virtual ICollection<CartItem> CartItems { get; set; }
        public Cart()
        {
            this.CartItems = new List<CartItem>();
        }
    }
}
