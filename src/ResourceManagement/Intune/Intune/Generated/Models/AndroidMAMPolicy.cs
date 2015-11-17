// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.12.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Intune.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Android Policy entity for Intune MAM.
    /// </summary>
    public partial class AndroidMAMPolicy : Resource
    {
        /// <summary>
        /// Initializes a new instance of the AndroidMAMPolicy class.
        /// </summary>
        public AndroidMAMPolicy() { }

        /// <summary>
        /// Initializes a new instance of the AndroidMAMPolicy class.
        /// </summary>
        public AndroidMAMPolicy(string friendlyName, string screenCapture = default(string), string fileEncryption = default(string), string description = default(string), string appSharingFromLevel = default(string), string appSharingToLevel = default(string), string authentication = default(string), string clipboardSharingLevel = default(string), string dataBackup = default(string), string fileSharingSaveAs = default(string), string pin = default(string), int? pinNumRetry = default(int?), string deviceCompliance = default(string), string managedBrowser = default(string), TimeSpan? accessRecheckOfflineTimeout = default(TimeSpan?), TimeSpan? accessRecheckOnlineTimeout = default(TimeSpan?), TimeSpan? offlineWipeTimeout = default(TimeSpan?), int? numOfApps = default(int?), string groupStatus = default(string), DateTime? lastModifiedTime = default(DateTime?))
        {
            ScreenCapture = screenCapture;
            FileEncryption = fileEncryption;
            FriendlyName = friendlyName;
            Description = description;
            AppSharingFromLevel = appSharingFromLevel;
            AppSharingToLevel = appSharingToLevel;
            Authentication = authentication;
            ClipboardSharingLevel = clipboardSharingLevel;
            DataBackup = dataBackup;
            FileSharingSaveAs = fileSharingSaveAs;
            Pin = pin;
            PinNumRetry = pinNumRetry;
            DeviceCompliance = deviceCompliance;
            ManagedBrowser = managedBrowser;
            AccessRecheckOfflineTimeout = accessRecheckOfflineTimeout;
            AccessRecheckOnlineTimeout = accessRecheckOnlineTimeout;
            OfflineWipeTimeout = offlineWipeTimeout;
            NumOfApps = numOfApps;
            GroupStatus = groupStatus;
            LastModifiedTime = lastModifiedTime;
        }

        /// <summary>
        /// Possible values for this property include: 'allow', 'block'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.screenCapture")]
        public string ScreenCapture { get; set; }

        /// <summary>
        /// Possible values for this property include: 'required',
        /// 'notRequired'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.fileEncryption")]
        public string FileEncryption { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.friendlyName")]
        public string FriendlyName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Possible values for this property include: 'none',
        /// 'policyManagedApps', 'allApps'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.appSharingFromLevel")]
        public string AppSharingFromLevel { get; set; }

        /// <summary>
        /// Possible values for this property include: 'none',
        /// 'policyManagedApps', 'allApps'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.appSharingToLevel")]
        public string AppSharingToLevel { get; set; }

        /// <summary>
        /// Possible values for this property include: 'required',
        /// 'notRequired'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.authentication")]
        public string Authentication { get; set; }

        /// <summary>
        /// Possible values for this property include: 'blocked',
        /// 'policyManagedApps', 'policyManagedAppsWithPasteIn', 'allApps'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.clipboardSharingLevel")]
        public string ClipboardSharingLevel { get; set; }

        /// <summary>
        /// Possible values for this property include: 'allow', 'block'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.dataBackup")]
        public string DataBackup { get; set; }

        /// <summary>
        /// Possible values for this property include: 'allow', 'block'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.fileSharingSaveAs")]
        public string FileSharingSaveAs { get; set; }

        /// <summary>
        /// Possible values for this property include: 'required',
        /// 'notRequired'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.pin")]
        public string Pin { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.pinNumRetry")]
        public int? PinNumRetry { get; set; }

        /// <summary>
        /// Possible values for this property include: 'enable', 'disable'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.deviceCompliance")]
        public string DeviceCompliance { get; set; }

        /// <summary>
        /// Possible values for this property include: 'required',
        /// 'notRequired'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.managedBrowser")]
        public string ManagedBrowser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.accessRecheckOfflineTimeout")]
        public TimeSpan? AccessRecheckOfflineTimeout { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.accessRecheckOnlineTimeout")]
        public TimeSpan? AccessRecheckOnlineTimeout { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.offlineWipeTimeout")]
        public TimeSpan? OfflineWipeTimeout { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.numOfApps")]
        public int? NumOfApps { get; private set; }

        /// <summary>
        /// Possible values for this property include: 'notTargeted',
        /// 'targeted'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.groupStatus")]
        public string GroupStatus { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastModifiedTime")]
        public DateTime? LastModifiedTime { get; private set; }

        /// <summary>
        /// Validate the object. Throws ArgumentException or ArgumentNullException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (FriendlyName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "FriendlyName");
            }
        }
    }
}
