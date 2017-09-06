using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Web.Hosting;

namespace EmailService
{
   
    public class EmailValueParser:IEmailValueParser
    {
        public string CreateMessage(string template, params object[] args)
        {
            var templateFilePath = HostingEnvironment.MapPath("~/template/") + template + "";
          
            var objStreamReaderFile = new StreamReader(templateFilePath);
            var body = objStreamReaderFile.ReadToEnd();
            objStreamReaderFile.Close();
            //   GetTokenToValueMap(body,args );
            var dict = new Dictionary<string, string>();
            var count = 1;
            foreach (string word in args)
            {
                dict.Add("VALUE" + count, word);
                count = count + 1;
            }
           var newstr = dict.Aggregate(body, (current, value) => current.Replace(value.Key, value.Value));
            // body = body.Replace("$password$", "Hellohi786"); //replacing the required things  
           return newstr; 

         }
    }
    
}
