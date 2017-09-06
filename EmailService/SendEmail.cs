using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Web.Hosting;


namespace EmailService
{
    public class SendEmail
    {
        public string EmailTemplate(string template, params object[] args)
        {
            var templateFilePath = HostingEnvironment.MapPath("~/template/") + template + "";
            var objStreamReaderFile = new StreamReader(templateFilePath);
            var body = objStreamReaderFile.ReadToEnd();
            objStreamReaderFile.Close();
       
            var dict = new Dictionary<string, string>();
            var a = 1;
            foreach (string word in args)
            {   dict.Add("VALUE" + a, word);a = a + 1;}
                var newstr = dict.Aggregate(body, (current, value) => current.Replace(value.Key, value.Value));
            return newstr; 
         }

        private MailMessage CreateMailmsg(EmailTemplate emailTemplate,Data args)
        {
            var valueaParser = new EmailValueParser();
            var from = emailTemplate.From ;
            var to = emailTemplate.To;
            var subject = emailTemplate.Subject;
            var message = new MailMessage ();
            message.To.Add(new MailAddress(to));
            message.Subject = emailTemplate.Subject;
            message.Body = valueaParser.CreateMessage("SendMain.txt", args);
            return message;
        }



        public void SendEmailMessage(Data args)
        {
            var valueaParser = new EmailValueParser();
          
            var email = new EmailTemplate(sp@hotmail.com","Booking","Confirmation");
            var message = CreateMailmsg(email, args);

            using (var smtp = new SmtpClient())
            {
                smtp.UseDefaultCredentials = true;
                smtp.Host = "";
                smtp.Port = 25;
                try
                {
                    smtp.Send(message);
                }
                catch (SmtpException ex)
                {
                    
                }
            }

        }
    }
}
