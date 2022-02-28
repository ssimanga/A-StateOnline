using A_StateOnline.Core.Models;
using A_StateOnline.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_StateOnline.Core.Contracts
{
    public interface IOrderService
    {
        void CreateOrder(Order baseOrde, List<CartItemVM> cartItems);
    }
}
