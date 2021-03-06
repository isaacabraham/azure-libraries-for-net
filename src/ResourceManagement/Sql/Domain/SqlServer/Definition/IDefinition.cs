// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Sql.Fluent.SqlServer.Definition
{
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core.Resource.Definition;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core.ResourceActions;
    using Microsoft.Azure.Management.Sql.Fluent;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core.GroupableResource.Definition;

    /// <summary>
    /// The first stage of the SQL Server definition.
    /// </summary>
    public interface IBlank  :
        Microsoft.Azure.Management.ResourceManager.Fluent.Core.Resource.Definition.IDefinitionWithRegion<Microsoft.Azure.Management.Sql.Fluent.SqlServer.Definition.IWithGroup>
    {
    }

    /// <summary>
    /// A SQL Server definition setting admin user password.
    /// </summary>
    public interface IWithAdministratorPassword 
    {
        /// <summary>
        /// Sets the administrator login password.
        /// </summary>
        /// <param name="administratorLoginPassword">Password for administrator login.</param>
        /// <return>Next stage of the SQL Server definition.</return>
        Microsoft.Azure.Management.Sql.Fluent.SqlServer.Definition.IWithCreate WithAdministratorPassword(string administratorLoginPassword);
    }

    /// <summary>
    /// A SQL Server definition with sufficient inputs to create a new
    /// SQL Server in the cloud, but exposing additional optional inputs to
    /// specify.
    /// </summary>
    public interface IWithCreate  :
        Microsoft.Azure.Management.ResourceManager.Fluent.Core.ResourceActions.ICreatable<Microsoft.Azure.Management.Sql.Fluent.ISqlServer>,
        Microsoft.Azure.Management.ResourceManager.Fluent.Core.Resource.Definition.IDefinitionWithTags<Microsoft.Azure.Management.Sql.Fluent.SqlServer.Definition.IWithCreate>,
        Microsoft.Azure.Management.Sql.Fluent.SqlServer.Definition.IWithElasticPool,
        Microsoft.Azure.Management.Sql.Fluent.SqlServer.Definition.IWithDatabase,
        Microsoft.Azure.Management.Sql.Fluent.SqlServer.Definition.IWithFirewallRule
    {
    }

    /// <summary>
    /// A SQL Server definition for specifying elastic pool.
    /// </summary>
    public interface IWithElasticPool 
    {
        /// <summary>
        /// Creates new elastic pool in the SQL Server.
        /// </summary>
        /// <param name="elasticPoolName">Name of the elastic pool to be created.</param>
        /// <param name="elasticPoolEdition">Edition of the elastic pool.</param>
        /// <param name="databaseNames">Names of the database to be included in the elastic pool.</param>
        /// <return>Next stage of the SQL Server definition.</return>
        Microsoft.Azure.Management.Sql.Fluent.SqlServer.Definition.IWithCreate WithNewElasticPool(string elasticPoolName, string elasticPoolEdition, params string[] databaseNames);

        /// <summary>
        /// Creates new elastic pool in the SQL Server.
        /// </summary>
        /// <param name="elasticPoolName">Name of the elastic pool to be created.</param>
        /// <param name="elasticPoolEdition">Edition of the elastic pool.</param>
        /// <return>Next stage of the SQL Server definition.</return>
        Microsoft.Azure.Management.Sql.Fluent.SqlServer.Definition.IWithCreate WithNewElasticPool(string elasticPoolName, string elasticPoolEdition);
    }

    /// <summary>
    /// A SQL Server definition setting administrator user name.
    /// </summary>
    public interface IWithAdministratorLogin 
    {
        /// <summary>
        /// Sets the administrator login user name.
        /// </summary>
        /// <param name="administratorLogin">Administrator login user name.</param>
        /// <return>Next stage of the SQL Server definition.</return>
        Microsoft.Azure.Management.Sql.Fluent.SqlServer.Definition.IWithAdministratorPassword WithAdministratorLogin(string administratorLogin);
    }

    /// <summary>
    /// A SQL Server definition allowing resource group to be set.
    /// </summary>
    public interface IWithGroup  :
        Microsoft.Azure.Management.ResourceManager.Fluent.Core.GroupableResource.Definition.IWithGroup<Microsoft.Azure.Management.Sql.Fluent.SqlServer.Definition.IWithAdministratorLogin>
    {
    }

    /// <summary>
    /// A SQL Server definition for specifying the firewall rule.
    /// </summary>
    public interface IWithFirewallRule 
    {
        /// <summary>
        /// Creates new firewall rule in the SQL Server.
        /// </summary>
        /// <param name="ipAddress">IpAddress for the firewall rule.</param>
        /// <return>Next stage of the SQL Server definition.</return>
        Microsoft.Azure.Management.Sql.Fluent.SqlServer.Definition.IWithCreate WithNewFirewallRule(string ipAddress);

        /// <summary>
        /// Creates new firewall rule in the SQL Server.
        /// </summary>
        /// <param name="startIPAddress">Start IP address for the firewall rule.</param>
        /// <param name="endIPAddress">End IP address for the firewall rule.</param>
        /// <return>Next stage of the SQL Server definition.</return>
        Microsoft.Azure.Management.Sql.Fluent.SqlServer.Definition.IWithCreate WithNewFirewallRule(string startIPAddress, string endIPAddress);

        /// <summary>
        /// Creates new firewall rule in the SQL Server.
        /// </summary>
        /// <param name="startIPAddress">Start IP address for the firewall rule.</param>
        /// <param name="endIPAddress">End IP address for the firewall rule.</param>
        /// <param name="firewallRuleName">Name for the firewall rule.</param>
        /// <return>Next stage of the SQL Server definition.</return>
        Microsoft.Azure.Management.Sql.Fluent.SqlServer.Definition.IWithCreate WithNewFirewallRule(string startIPAddress, string endIPAddress, string firewallRuleName);
    }

    /// <summary>
    /// A SQL Server definition for specifying the databases.
    /// </summary>
    public interface IWithDatabase 
    {
        /// <summary>
        /// Creates new database in the SQL Server.
        /// </summary>
        /// <param name="databaseName">Name of the database to be created.</param>
        /// <return>Next stage of the SQL Server definition.</return>
        Microsoft.Azure.Management.Sql.Fluent.SqlServer.Definition.IWithCreate WithNewDatabase(string databaseName);
    }

    /// <summary>
    /// Container interface for all the definitions that need to be implemented.
    /// </summary>
    public interface IDefinition  :
        Microsoft.Azure.Management.Sql.Fluent.SqlServer.Definition.IBlank,
        Microsoft.Azure.Management.Sql.Fluent.SqlServer.Definition.IWithGroup,
        Microsoft.Azure.Management.Sql.Fluent.SqlServer.Definition.IWithAdministratorLogin,
        Microsoft.Azure.Management.Sql.Fluent.SqlServer.Definition.IWithAdministratorPassword,
        Microsoft.Azure.Management.Sql.Fluent.SqlServer.Definition.IWithElasticPool,
        Microsoft.Azure.Management.Sql.Fluent.SqlServer.Definition.IWithDatabase,
        Microsoft.Azure.Management.Sql.Fluent.SqlServer.Definition.IWithFirewallRule,
        Microsoft.Azure.Management.Sql.Fluent.SqlServer.Definition.IWithCreate
    {
    }
}