//======
// Microsoft patterns & practices
// Composite Application Guidance for Windows Presentation Foundation and Silverlight
//======
// Copyright (c) Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
//======
// The example companies, organizations, products, domain names,
// e-mail addresses, logos, people, places, and events depicted
// herein are fictitious.  No association with any real company,
// organization, product, domain name, email address, logo, person,
// places, or events is intended or should be inferred.
//======
using System;
using System.Runtime.Serialization;

namespace Microsoft.Practices.Prism.Regions
{
    /// <summary>
    /// Exception that's thrown when something goes wrong while Registering a View with a region name in the <see cref="RegionViewRegistry"/> class. 
    /// </summary>
    [Serializable]
    public partial class ViewRegistrationException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewRegistrationException"/> class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="SerializationInfo"/> that holds the serialized 
        /// object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="StreamingContext"/> that contains contextual information about the source or destination.</param>
        protected ViewRegistrationException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}