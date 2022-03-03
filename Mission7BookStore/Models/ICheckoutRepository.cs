using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission7BookStore.Models
{
    public interface ICheckoutRepository
    {
        public IQueryable<Checkout> Checkouts { get; }
        void SaveCheckout(Checkout checkout);
    }
}
