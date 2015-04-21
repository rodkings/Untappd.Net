﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Untappd.Net.Client
{
    public abstract class UntappdCredentials : IUntappdCredentials
    {
        public string ClientId { get; private set; }
        public string ClientSecret { get; private set; }

        /// <summary>
        /// UnAuthenticated request. Pass your API id and secret
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="clientSecret"></param>
        public UntappdCredentials(string clientId, string clientSecret)
        {
            if (string.IsNullOrWhiteSpace(clientId))
            {
                throw new ArgumentNullException("clientId");
            }
            if (string.IsNullOrWhiteSpace(clientSecret))
            {
                throw new ArgumentNullException("clientSecret");
            }
            ClientId = string.Copy(clientId);
            ClientSecret = string.Copy(clientSecret);
        }
    }
}