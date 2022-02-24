﻿using A_StateOnline.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace A_StateOnline.Core.Contracts
{
   public interface ICartService
    {
        void AddToCart(HttpContextBase httpContext, string productId);
        void RemoveFromCart(HttpContextBase httpContext, string itemId);
        List<CartItemVM> GetCartItems(HttpContextBase httpContext);
        CartSummaryVM GetCartSummary(HttpContextBase httpContext);
        
    }
}