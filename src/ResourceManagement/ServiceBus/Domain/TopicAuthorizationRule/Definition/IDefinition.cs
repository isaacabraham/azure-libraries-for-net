// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.ServiceBus.Fluent.TopicAuthorizationRule.Definition
{
    using Microsoft.Azure.Management.ServiceBus.Fluent.AuthorizationRule.Definition;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core.ResourceActions;
    using Microsoft.Azure.Management.ServiceBus.Fluent;

    /// <summary>
    /// The first stage of topic authorization rule definition.
    /// </summary>
    public interface IBlank :
        Microsoft.Azure.Management.ServiceBus.Fluent.AuthorizationRule.Definition.IWithListenOrSendOrManage<Microsoft.Azure.Management.ServiceBus.Fluent.TopicAuthorizationRule.Definition.IWithCreate>
    {
    }

    /// <summary>
    /// The entirety of the topic authorization rule definition.
    /// </summary>
    public interface IDefinition :
        Microsoft.Azure.Management.ServiceBus.Fluent.TopicAuthorizationRule.Definition.IBlank,
        Microsoft.Azure.Management.ServiceBus.Fluent.TopicAuthorizationRule.Definition.IWithCreate
    {
    }

    /// <summary>
    /// The stage of the definition which contains all the minimum required inputs for
    /// the resource to be created (via  WithCreate.create()), but also allows
    /// for any other optional settings to be specified.
    /// </summary>
    public interface IWithCreate :
        Microsoft.Azure.Management.ResourceManager.Fluent.Core.ResourceActions.ICreatable<Microsoft.Azure.Management.ServiceBus.Fluent.ITopicAuthorizationRule>
    {
    }
}