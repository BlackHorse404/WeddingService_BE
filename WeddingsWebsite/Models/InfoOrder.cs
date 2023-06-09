using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeddingsWebsite.Models
{
    public class InfoOrder
    {
        public string fullname { get; set; }
        public string telephoneNumber { get; set; }
        public string address { get; set; }
        public string email { get; set; }
        public InfoOrder(string fullname, string telephone, string address, string email) 
        {
            //generate mã order

            this.fullname = fullname;
            this.telephoneNumber = telephone;
            this.address = address;
            this.email = email;
        }
    }
}