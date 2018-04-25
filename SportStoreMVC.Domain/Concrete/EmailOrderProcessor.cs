using SportStoreMVC.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportStoreMVC.Domain.Entities;

namespace SportStoreMVC.Domain.Concrete
{
    public class EmailOrderProcessor : IOrderProcessor
    {
        public EmailOrderProcessor(EmailSettings emailSettings)
        {

        }
        public void ProcessOrder(Cart cart, ShippingDetails shippingDetails)
        {
           
        }
    }

    public class EmailSettings
    {
        public string UserName { get; set; } = "EmailName";
    }
}
