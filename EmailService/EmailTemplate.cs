using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailService
{
    public class EmailTemplate
    {
    
        public string From { get; private set; }
        public string To { get; private set; }
        public string Subject { get; private set; }
       // public string Body { get; set; }

        public EmailTemplate( string from, string to, string subject)// string body)
        {
        
            From = from;
            To = to;
            Subject = subject;
          //  Body = body;
        }

      
    }
}