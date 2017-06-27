using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Mail;


namespace VaupelElectric.Controllers
{
    public class SendMailController : Controller
    {
        // GET: SendMail
        public ActionResult Index()
        {
            return View();
        }

        //Logic for sending mail from contact page. 
         protected void SendMail()
        {
            var fromAddress = "3sgtejeff@gmail.com";
            var toAddress = "jeffreylongo@yahoo.com";
            const string fromPassword = "maxmaxmax";

            string subject = YourSubject.Text.ToString();
            string body = "From: " + YourName.Text + "\n";
            body += "Emai: " + YourEmail.Text + "\n";
            body += "Subject: " + YourSubject.Text + "\n";
            body += "Question: \n" + Comments.Text + "\n";

            var smtp = new System.Net.Mail.SmtpClient();
            {
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(fromAddress, fromPassword);
                smtp.Timeout = 20000;

            }
            smtp.Send(fromAddress, toAddress, subject, body);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SendMail();
                DisplayMessage.Text = "Your Mail has been sent!";
                DisplayMessage.Visible = true;
                YourSubject.Text = "";
                YourEmail.Text = "";
                YourName.Text = "";
                Comments.Text = "";
            }
            catch (Exception) { }
        }
    }
}