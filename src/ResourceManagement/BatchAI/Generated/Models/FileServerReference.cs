// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.BatchAI.Fluent.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Provides required information, for the service to be able to mount
    /// Azure FileShare on the cluster nodes.
    /// </summary>
    public partial class FileServerReference
    {
        /// <summary>
        /// Initializes a new instance of the FileServerReference class.
        /// </summary>
        public FileServerReference()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FileServerReference class.
        /// </summary>
        /// <param name="fileServer">Reference to the file server
        /// resource.</param>
        /// <param name="relativeMountPath">Specifies the relative path on the
        /// compute node where the File Server will be mounted.</param>
        /// <param name="sourceDirectory">Specifies the source directory in
        /// File Server that needs to be mounted.</param>
        /// <param name="mountOptions">Specifies the mount options for File
        /// Server.</param>
        public FileServerReference(ResourceId fileServer, string relativeMountPath, string sourceDirectory = default(string), string mountOptions = default(string))
        {
            FileServer = fileServer;
            SourceDirectory = sourceDirectory;
            RelativeMountPath = relativeMountPath;
            MountOptions = mountOptions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets reference to the file server resource.
        /// </summary>
        [JsonProperty(PropertyName = "fileServer")]
        public ResourceId FileServer { get; set; }

        /// <summary>
        /// Gets or sets specifies the source directory in File Server that
        /// needs to be mounted.
        /// </summary>
        /// <remarks>
        /// If this property is not specified, the entire File Server will be
        /// mounted.
        /// </remarks>
        [JsonProperty(PropertyName = "sourceDirectory")]
        public string SourceDirectory { get; set; }

        /// <summary>
        /// Gets or sets specifies the relative path on the compute node where
        /// the File Server will be mounted.
        /// </summary>
        /// <remarks>
        /// Note that all file shares will be mounted under
        /// $AZ_BATCHAI_MOUNT_ROOT location.
        /// </remarks>
        [JsonProperty(PropertyName = "relativeMountPath")]
        public string RelativeMountPath { get; set; }

        /// <summary>
        /// Gets or sets specifies the mount options for File Server.
        /// </summary>
        [JsonProperty(PropertyName = "mountOptions")]
        public string MountOptions { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (FileServer == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "FileServer");
            }
            if (RelativeMountPath == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RelativeMountPath");
            }
            if (FileServer != null)
            {
                FileServer.Validate();
            }
        }
    }
}
