// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityCollectionWithReferencesRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type EducationSchoolUsersCollectionWithReferencesRequestBuilder.
    /// </summary>
    public partial class EducationSchoolUsersCollectionWithReferencesRequestBuilder : BaseRequestBuilder, IEducationSchoolUsersCollectionWithReferencesRequestBuilder
    {

        /// <summary>
        /// Constructs a new EducationSchoolUsersCollectionWithReferencesRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public EducationSchoolUsersCollectionWithReferencesRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IEducationSchoolUsersCollectionWithReferencesRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IEducationSchoolUsersCollectionWithReferencesRequest Request(IEnumerable<Option> options)
        {
            return new EducationSchoolUsersCollectionWithReferencesRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IEducationUserWithReferenceRequestBuilder"/> for the specified EducationSchoolEducationUser.
        /// </summary>
        /// <param name="id">The ID for the EducationSchoolEducationUser.</param>
        /// <returns>The <see cref="IEducationUserWithReferenceRequestBuilder"/>.</returns>
        public IEducationUserWithReferenceRequestBuilder this[string id]
        {
            get
            {
                return new EducationUserWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
        /// <summary>
        /// Gets an <see cref="IEducationSchoolUsersCollectionReferencesRequestBuilder"/> for the references in the collection.
        /// </summary>
        /// <returns>The <see cref="IEducationSchoolUsersCollectionReferencesRequestBuilder"/>.</returns>
        public IEducationSchoolUsersCollectionReferencesRequestBuilder References
        {
            get
            {
                return new EducationSchoolUsersCollectionReferencesRequestBuilder(this.AppendSegmentToRequestUrl("$ref"), this.Client);
            }
        }

    }
}
