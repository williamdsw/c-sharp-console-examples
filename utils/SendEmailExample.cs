using System;
using System.Net.Mail;

namespace CSharpConsoleExamples
{
    class SendEmailExample
    {
        public SendEmailExample ()
        {
            Send();
        }

        private async void Send ()
        {
            try
            {
                using (SmtpClient client = new SmtpClient ())
                {
                    /* Parameters for client (gmail) */
                    string sender = "myemail@gmail.com";
                    string password = "mypassword";
                    client.Host = "smtp.gmail.com";
                    client.Port = 587;
                    client.EnableSsl = true;
                    client.UseDefaultCredentials = true;
                    client.Credentials = new System.Net.NetworkCredential (sender, password);

                    using (MailMessage mail = new MailMessage())
                    {
                        /* Lists of emails, files paths */
                        string[] toEmails = { "example1@gmail.com", "example2@gmail.com", "example3@gmail.com" };
                        string[] ccEmails = { "example4@gmail.com", "example5@gmail.com", "example6@gmail.com" };
                        string[] bccEmails = { "example7@gmail.com", "example8@gmail.com", "example9@gmail.com" };
                        string[] filePaths = { "C://file.txt", "C://file.xml", "C://file.mp3" };

                        mail.From = new MailAddress (sender);

                        foreach (string to in toEmails)
                        {
                            mail.To.Add (new MailAddress (to));
                        }

                        foreach (string cc in ccEmails)
                        {
                            mail.CC.Add (new MailAddress (cc));
                        }

                        foreach (string bcc in bccEmails)
                        {
                            mail.Bcc.Add (new MailAddress (bcc));
                        }

                        foreach (string path in filePaths)
                        {
                            mail.Attachments.Add (new Attachment (path));
                        }

                        mail.Subject = "Subject email test using C#";
                        mail.Body = "Subject body test using C#";

                        await client.SendMailAsync (mail);

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