﻿using System;
using SimpleAuthentication.Core;

namespace Nancy.SimpleAuthentication
{
    public class AuthenticateCallbackData
    {
        public AuthenticateCallbackData()
        {
            ProviderName = "Unknown";
        }

        /// <summary>
        /// An Authentication Provider.
        /// </summary>
        public string ProviderName { get; set; }

        /// <summary>
        /// The authenticated client information, if we have successfully authenticated.
        /// </summary>
        public IAuthenticatedClient AuthenticatedClient { get; set; }

        /// <summary>
        /// Possible Url or partial route to redirect to.
        /// </summary>
        public string ReturnUrl { get; set; }

        /// <summary>
        /// Exception information, if an error has occurred.
        /// </summary>
        public Exception Exception { get; set; }
    }
}