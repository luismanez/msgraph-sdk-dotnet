// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Windows10Endpoint Protection Configuration.
    /// </summary>
    public partial class Windows10EndpointProtectionConfiguration : DeviceConfiguration
    {
    
        ///<summary>
        /// The Windows10EndpointProtectionConfiguration constructor
        ///</summary>
        public Windows10EndpointProtectionConfiguration()
        {
            this.ODataType = "microsoft.graph.windows10EndpointProtectionConfiguration";
        }
    
        /// <summary>
        /// Gets or sets application guard allow persistence.
        /// Allow persisting user generated data inside the App Guard Containter (favorites, cookies, web passwords, etc.)
        /// </summary>
        [JsonPropertyName("applicationGuardAllowPersistence")]
        public bool? ApplicationGuardAllowPersistence { get; set; }
    
        /// <summary>
        /// Gets or sets application guard allow print to local printers.
        /// Allow printing to Local Printers from Container
        /// </summary>
        [JsonPropertyName("applicationGuardAllowPrintToLocalPrinters")]
        public bool? ApplicationGuardAllowPrintToLocalPrinters { get; set; }
    
        /// <summary>
        /// Gets or sets application guard allow print to network printers.
        /// Allow printing to Network Printers from Container
        /// </summary>
        [JsonPropertyName("applicationGuardAllowPrintToNetworkPrinters")]
        public bool? ApplicationGuardAllowPrintToNetworkPrinters { get; set; }
    
        /// <summary>
        /// Gets or sets application guard allow print to pdf.
        /// Allow printing to PDF from Container
        /// </summary>
        [JsonPropertyName("applicationGuardAllowPrintToPDF")]
        public bool? ApplicationGuardAllowPrintToPDF { get; set; }
    
        /// <summary>
        /// Gets or sets application guard allow print to xps.
        /// Allow printing to XPS from Container
        /// </summary>
        [JsonPropertyName("applicationGuardAllowPrintToXPS")]
        public bool? ApplicationGuardAllowPrintToXPS { get; set; }
    
        /// <summary>
        /// Gets or sets application guard block clipboard sharing.
        /// Block clipboard to share data from Host to Container, or from Container to Host, or both ways, or neither ways. Possible values are: notConfigured, blockBoth, blockHostToContainer, blockContainerToHost, blockNone.
        /// </summary>
        [JsonPropertyName("applicationGuardBlockClipboardSharing")]
        public ApplicationGuardBlockClipboardSharingType? ApplicationGuardBlockClipboardSharing { get; set; }
    
        /// <summary>
        /// Gets or sets application guard block file transfer.
        /// Block clipboard to transfer image file, text file or neither of them. Possible values are: notConfigured, blockImageAndTextFile, blockImageFile, blockNone, blockTextFile.
        /// </summary>
        [JsonPropertyName("applicationGuardBlockFileTransfer")]
        public ApplicationGuardBlockFileTransferType? ApplicationGuardBlockFileTransfer { get; set; }
    
        /// <summary>
        /// Gets or sets application guard block non enterprise content.
        /// Block enterprise sites to load non-enterprise content, such as third party plug-ins
        /// </summary>
        [JsonPropertyName("applicationGuardBlockNonEnterpriseContent")]
        public bool? ApplicationGuardBlockNonEnterpriseContent { get; set; }
    
        /// <summary>
        /// Gets or sets application guard enabled.
        /// Enable Windows Defender Application Guard
        /// </summary>
        [JsonPropertyName("applicationGuardEnabled")]
        public bool? ApplicationGuardEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets application guard force auditing.
        /// Force auditing will persist Windows logs and events to meet security/compliance criteria (sample events are user login-logoff, use of privilege rights, software installation, system changes, etc.)
        /// </summary>
        [JsonPropertyName("applicationGuardForceAuditing")]
        public bool? ApplicationGuardForceAuditing { get; set; }
    
        /// <summary>
        /// Gets or sets app locker application control.
        /// Enables the Admin to choose what types of app to allow on devices. Possible values are: notConfigured, enforceComponentsAndStoreApps, auditComponentsAndStoreApps, enforceComponentsStoreAppsAndSmartlocker, auditComponentsStoreAppsAndSmartlocker.
        /// </summary>
        [JsonPropertyName("appLockerApplicationControl")]
        public AppLockerApplicationControlType? AppLockerApplicationControl { get; set; }
    
        /// <summary>
        /// Gets or sets bit locker disable warning for other disk encryption.
        /// Allows the Admin to disable the warning prompt for other disk encryption on the user machines.
        /// </summary>
        [JsonPropertyName("bitLockerDisableWarningForOtherDiskEncryption")]
        public bool? BitLockerDisableWarningForOtherDiskEncryption { get; set; }
    
        /// <summary>
        /// Gets or sets bit locker enable storage card encryption on mobile.
        /// Allows the admin to require encryption to be turned on using BitLocker. This policy is valid only for a mobile SKU.
        /// </summary>
        [JsonPropertyName("bitLockerEnableStorageCardEncryptionOnMobile")]
        public bool? BitLockerEnableStorageCardEncryptionOnMobile { get; set; }
    
        /// <summary>
        /// Gets or sets bit locker encrypt device.
        /// Allows the admin to require encryption to be turned on using BitLocker.
        /// </summary>
        [JsonPropertyName("bitLockerEncryptDevice")]
        public bool? BitLockerEncryptDevice { get; set; }
    
        /// <summary>
        /// Gets or sets bit locker removable drive policy.
        /// BitLocker Removable Drive Policy.
        /// </summary>
        [JsonPropertyName("bitLockerRemovableDrivePolicy")]
        public BitLockerRemovableDrivePolicy BitLockerRemovableDrivePolicy { get; set; }
    
        /// <summary>
        /// Gets or sets defender additional guarded folders.
        /// List of folder paths to be added to the list of protected folders
        /// </summary>
        [JsonPropertyName("defenderAdditionalGuardedFolders")]
        public IEnumerable<string> DefenderAdditionalGuardedFolders { get; set; }
    
        /// <summary>
        /// Gets or sets defender attack surface reduction excluded paths.
        /// List of exe files and folders to be excluded from attack surface reduction rules
        /// </summary>
        [JsonPropertyName("defenderAttackSurfaceReductionExcludedPaths")]
        public IEnumerable<string> DefenderAttackSurfaceReductionExcludedPaths { get; set; }
    
        /// <summary>
        /// Gets or sets defender exploit protection xml.
        /// Xml content containing information regarding exploit protection details.
        /// </summary>
        [JsonPropertyName("defenderExploitProtectionXml")]
        public byte[] DefenderExploitProtectionXml { get; set; }
    
        /// <summary>
        /// Gets or sets defender exploit protection xml file name.
        /// Name of the file from which DefenderExploitProtectionXml was obtained.
        /// </summary>
        [JsonPropertyName("defenderExploitProtectionXmlFileName")]
        public string DefenderExploitProtectionXmlFileName { get; set; }
    
        /// <summary>
        /// Gets or sets defender guarded folders allowed app paths.
        /// List of paths to exe that are allowed to access protected folders
        /// </summary>
        [JsonPropertyName("defenderGuardedFoldersAllowedAppPaths")]
        public IEnumerable<string> DefenderGuardedFoldersAllowedAppPaths { get; set; }
    
        /// <summary>
        /// Gets or sets defender security center block exploit protection override.
        /// Indicates whether or not to block user from overriding Exploit Protection settings.
        /// </summary>
        [JsonPropertyName("defenderSecurityCenterBlockExploitProtectionOverride")]
        public bool? DefenderSecurityCenterBlockExploitProtectionOverride { get; set; }
    
        /// <summary>
        /// Gets or sets firewall block stateful ftp.
        /// Blocks stateful FTP connections to the device
        /// </summary>
        [JsonPropertyName("firewallBlockStatefulFTP")]
        public bool? FirewallBlockStatefulFTP { get; set; }
    
        /// <summary>
        /// Gets or sets firewall certificate revocation list check method.
        /// Specify how the certificate revocation list is to be enforced. Possible values are: deviceDefault, none, attempt, require.
        /// </summary>
        [JsonPropertyName("firewallCertificateRevocationListCheckMethod")]
        public FirewallCertificateRevocationListCheckMethodType? FirewallCertificateRevocationListCheckMethod { get; set; }
    
        /// <summary>
        /// Gets or sets firewall idle timeout for security association in seconds.
        /// Configures the idle timeout for security associations, in seconds, from 300 to 3600 inclusive. This is the period after which security associations will expire and be deleted. Valid values 300 to 3600
        /// </summary>
        [JsonPropertyName("firewallIdleTimeoutForSecurityAssociationInSeconds")]
        public Int32? FirewallIdleTimeoutForSecurityAssociationInSeconds { get; set; }
    
        /// <summary>
        /// Gets or sets firewall ipsec exemptions allow dhcp.
        /// Configures IPSec exemptions to allow both IPv4 and IPv6 DHCP traffic
        /// </summary>
        [JsonPropertyName("firewallIPSecExemptionsAllowDHCP")]
        public bool? FirewallIPSecExemptionsAllowDHCP { get; set; }
    
        /// <summary>
        /// Gets or sets firewall ipsec exemptions allow icmp.
        /// Configures IPSec exemptions to allow ICMP
        /// </summary>
        [JsonPropertyName("firewallIPSecExemptionsAllowICMP")]
        public bool? FirewallIPSecExemptionsAllowICMP { get; set; }
    
        /// <summary>
        /// Gets or sets firewall ipsec exemptions allow neighbor discovery.
        /// Configures IPSec exemptions to allow neighbor discovery IPv6 ICMP type-codes
        /// </summary>
        [JsonPropertyName("firewallIPSecExemptionsAllowNeighborDiscovery")]
        public bool? FirewallIPSecExemptionsAllowNeighborDiscovery { get; set; }
    
        /// <summary>
        /// Gets or sets firewall ipsec exemptions allow router discovery.
        /// Configures IPSec exemptions to allow router discovery IPv6 ICMP type-codes
        /// </summary>
        [JsonPropertyName("firewallIPSecExemptionsAllowRouterDiscovery")]
        public bool? FirewallIPSecExemptionsAllowRouterDiscovery { get; set; }
    
        /// <summary>
        /// Gets or sets firewall merge keying module settings.
        /// If an authentication set is not fully supported by a keying module, direct the module to ignore only unsupported authentication suites rather than the entire set
        /// </summary>
        [JsonPropertyName("firewallMergeKeyingModuleSettings")]
        public bool? FirewallMergeKeyingModuleSettings { get; set; }
    
        /// <summary>
        /// Gets or sets firewall packet queueing method.
        /// Configures how packet queueing should be applied in the tunnel gateway scenario. Possible values are: deviceDefault, disabled, queueInbound, queueOutbound, queueBoth.
        /// </summary>
        [JsonPropertyName("firewallPacketQueueingMethod")]
        public FirewallPacketQueueingMethodType? FirewallPacketQueueingMethod { get; set; }
    
        /// <summary>
        /// Gets or sets firewall pre shared key encoding method.
        /// Select the preshared key encoding to be used. Possible values are: deviceDefault, none, utF8.
        /// </summary>
        [JsonPropertyName("firewallPreSharedKeyEncodingMethod")]
        public FirewallPreSharedKeyEncodingMethodType? FirewallPreSharedKeyEncodingMethod { get; set; }
    
        /// <summary>
        /// Gets or sets firewall profile domain.
        /// Configures the firewall profile settings for domain networks
        /// </summary>
        [JsonPropertyName("firewallProfileDomain")]
        public WindowsFirewallNetworkProfile FirewallProfileDomain { get; set; }
    
        /// <summary>
        /// Gets or sets firewall profile private.
        /// Configures the firewall profile settings for private networks
        /// </summary>
        [JsonPropertyName("firewallProfilePrivate")]
        public WindowsFirewallNetworkProfile FirewallProfilePrivate { get; set; }
    
        /// <summary>
        /// Gets or sets firewall profile public.
        /// Configures the firewall profile settings for public networks
        /// </summary>
        [JsonPropertyName("firewallProfilePublic")]
        public WindowsFirewallNetworkProfile FirewallProfilePublic { get; set; }
    
        /// <summary>
        /// Gets or sets smart screen block override for files.
        /// Allows IT Admins to control whether users can ignore SmartScreen warnings and run malicious files.
        /// </summary>
        [JsonPropertyName("smartScreenBlockOverrideForFiles")]
        public bool? SmartScreenBlockOverrideForFiles { get; set; }
    
        /// <summary>
        /// Gets or sets smart screen enable in shell.
        /// Allows IT Admins to configure SmartScreen for Windows.
        /// </summary>
        [JsonPropertyName("smartScreenEnableInShell")]
        public bool? SmartScreenEnableInShell { get; set; }
    
    }
}

