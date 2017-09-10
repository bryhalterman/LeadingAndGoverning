using LearningAndGoverning.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Web;

namespace LearningAndGoverning.Services
{
    public class MessagingService : IDisposable
    {
        private SmtpClient smtpClient;
        private MailMessage mailMessage;
        private NetworkCredential credentials;
        private ApplicationSettingsService appSettings;
        private bool wasSuccessful;

        public MessagingService()
        {
            smtpClient = new SmtpClient();
            mailMessage = new MailMessage();
            appSettings = new ApplicationSettingsService();
            credentials = new NetworkCredential(appSettings.SMTPUserId, appSettings.SMTPPassword);
            wasSuccessful = true;

            smtpClient.Host = appSettings.SMTPHostname;
            smtpClient.Port = Convert.ToInt16(appSettings.SMTPTLSPort);
            smtpClient.EnableSsl = false;
            smtpClient.Credentials = credentials;
        }

        public bool SendMessage(string to, string from, string subject, string body)
        {
            mailMessage.From = new MailAddress(from);
            mailMessage.To.Add(to);
            mailMessage.Subject = subject;
            mailMessage.Body = body;

            mailMessage.BodyEncoding = UTF8Encoding.UTF8;

            SendMessage();

            return wasSuccessful;
        }

        public bool SendMessage(ContactViewModel vm)
        {
            return SendMessage("bryhalterman@gmail.com", vm.Email, vm.Subject, vm.Body);
        }

        private void SendMessage()
        {
            try
            {
                smtpClient.Send(mailMessage);
                wasSuccessful = true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception: " + ex.Message);
                wasSuccessful = false;
            }
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    mailMessage.Dispose();
                    smtpClient.Dispose();
                    appSettings.Dispose();
                }

                disposedValue = true;
            }
        }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
        }
        #endregion

    }
}