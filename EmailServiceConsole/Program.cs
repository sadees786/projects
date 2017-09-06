using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmailService;


namespace EmailServiceConsole
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            var dt= new Data();
            dt.Value1 = "Saadia";
            dt.Value2 = "Sajjad";
            var sebn= new SendEmail();
            sebn.SendEmailMessage(dt);
        }
    }
}
