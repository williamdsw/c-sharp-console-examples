using System;
using System.Net.Mail;

namespace c_sharp_console_examples
{
    class SendEmailExample
    {
        private const string SENDER = "myemail@gmail.com";
        private const string PASSWORD = "mypassword";
        private const string HOST = "smtp.gmail.com";
        private const int PORT = 587;

        //-----------------------------------------------------------------------//
        // CONSTRUCTOR

        public SendEmailExample ()
        {
            Send ();
        }

        //-----------------------------------------------------------------------//
        // HELPER FUNCTIONS

        private async void Send ()
        {
            try
            {
                using (SmtpClient smtpClient = new SmtpClient ())
                {
                    // Parameters for client (gmail)
                    smtpClient.Host = HOST;
                    smtpClient.Port = PORT;
                    smtpClient.EnableSsl = true;
                    smtpClient.UseDefaultCredentials = true;
                    smtpClient.Credentials = new System.Net.NetworkCredential (SENDER, PASSWORD);

                    using (MailMessage mailMessage = new MailMessage())
                    {
                        // Lists of emails, files paths
                        string[] toEmails = { "example1@gmail.com", "example2@gmail.com", "example3@gmail.com" };
                        string[] ccEmails = { "example4@gmail.com", "example5@gmail.com", "example6@gmail.com" };
                        string[] bccEmails = { "example7@gmail.com", "example8@gmail.com", "example9@gmail.com" };
                        string[] filePaths = { "C://file.txt", "C://file.xml", "C://file.mp3" };

                        mailMessage.From = new MailAddress (SENDER);

                        foreach (string to in toEmails)
                        {
                            mailMessage.To.Add (new MailAddress (to));
                        }

                        foreach (string cc in ccEmails)
                        {
                            mailMessage.CC.Add (new MailAddress (cc));
                        }

                        foreach (string bcc in bccEmails)
                        {
                            mailMessage.Bcc.Add (new MailAddress (bcc));
                        }

                        foreach (string path in filePaths)
                        {
                            mailMessage.Attachments.Add (new Attachment (path));
                        }

                        mailMessage.Subject = "Subject email test using C#";
                        mailMessage.Body = "Subject body test using C#";

                        await smtpClient.SendMailAsync (mailMessage);

                        Console.WriteLine ("Email sent...");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine (ex.Message);
            }
        }
    }
}