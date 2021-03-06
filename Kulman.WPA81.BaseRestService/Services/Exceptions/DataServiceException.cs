﻿using System;
using JetBrains.Annotations;

namespace Kulman.WPA81.BaseRestService.Services.Exceptions
{
    /// <summary>
    /// Generic data service exception
    /// </summary>
    public class DataServiceException : Exception
    {
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="message">Error message</param>
        /// <param name="innerException">Inner exception</param>
        protected DataServiceException([NotNull] string message, [NotNull] Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
