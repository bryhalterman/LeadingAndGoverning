using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace LeadingAndGoverning.SystemServices
{
    public class ApplicationSettingsService : IDisposable
    {
        public string SMTPHostname => ConfigurationManager.AppSettings["SMTPHostname"].ToString();

        public string SMTPUserId => ConfigurationManager.AppSettings["SMTPUserId"].ToString();

        public string SMTPPassword => ConfigurationManager.AppSettings["SMTPPassword"].ToString();

        public string SMTPUnsecuredPort => ConfigurationManager.AppSettings["SMTPUnsecuredPort"].ToString();

        public string SMTPSSLPort => ConfigurationManager.AppSettings["SMTPSSLPort"].ToString();

        public string SMTPTLSPort => ConfigurationManager.AppSettings["SMTPTLSPort"].ToString();

        // TODO: This needs to move to a database instance once I get one setup.
        public string SMTPUseSecureConnection => ConfigurationManager.AppSettings["SMTPUseSecureConnection"].ToString();

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {

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