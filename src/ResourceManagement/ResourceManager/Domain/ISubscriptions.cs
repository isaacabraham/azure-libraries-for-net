// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information. 

namespace Microsoft.Azure.Management.ResourceManager.Fluent
{

    using Microsoft.Azure.Management.ResourceManager.Fluent.Core.CollectionActions;

    /// <summary>
    /// Entry point to subscription management API.
    /// </summary>
    public interface ISubscriptions  :
        ISupportsListing<ISubscription>,
        ISupportsGettingById<ISubscription>
    {
    }
}