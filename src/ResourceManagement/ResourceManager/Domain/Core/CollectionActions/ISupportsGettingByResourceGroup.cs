// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information. 

namespace Microsoft.Azure.Management.ResourceManager.Fluent.Core.CollectionActions
{

    using System.Threading.Tasks;
    using System.Threading;

    /// <summary>
    /// Provides access to getting a specific Azure resource based on its name and resource group.
    /// 
    /// (Note: this interface is not intended to be implemented by user code)
    /// 
    /// @param <T> the type of the resource to get.
    /// </summary>
    public interface ISupportsGettingByResourceGroup<T> 
    {
        /// <summary>
        /// Gets the information about a resource from Azure based on the resource name and the name of its resource group.
        /// </summary>
        /// <param name="resourceGroupName">the name of the resource group the resource is in</param>
        /// <param name="name">the name of the resource. (Note, this is not the ID)</param>
        /// <returns>an immutable representation of the resource</returns>
        T GetByResourceGroup (string resourceGroupName, string name);

        /// <summary>
        /// Gets the information about a resource from Azure based on the resource name and the name of its resource group.
        /// </summary>
        /// <param name="resourceGroupName">the name of the resource group the resource is in</param>
        /// <param name="name">the name of the resource. (Note, this is not the ID)</param>
        /// <param name="cancellationToken">the cancellation token</param>
        /// <returns>an immutable representation of the resource</returns>
        Task<T> GetByResourceGroupAsync (string resourceGroupName, string name, CancellationToken cancellationToken = default(CancellationToken));

    }
}