﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Practices.SharePoint.Common.LoggerProxy.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Practices.SharePoint.Common.LoggerProxy.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An area must already exist when adding a category, area {0} not found..
        /// </summary>
        internal static string AreaMustExist {
            get {
                return ResourceManager.GetString("AreaMustExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The proxy arguments provide where not the required type, provided &apos;{0}&apos;, expected &apos;{1}&apos;..
        /// </summary>
        internal static string InvalidProxyArgProvided {
            get {
                return ResourceManager.GetString("InvalidProxyArgProvided", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sandbox Log, Missing Site Context, Message: &apos;{0}&apos;.
        /// </summary>
        internal static string NoSiteContextLogMessage {
            get {
                return ResourceManager.GetString("NoSiteContextLogMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sandbox Trace,Missing Site Context, Message:&apos;{0}&apos;.
        /// </summary>
        internal static string NoSiteContextTraceMessage {
            get {
                return ResourceManager.GetString("NoSiteContextTraceMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sandbox Log, SiteID:&apos;{0}&apos;  SiteName:&apos;{1}&apos;  Message:&apos;{2}&apos;.
        /// </summary>
        internal static string SandboxLogMessage {
            get {
                return ResourceManager.GetString("SandboxLogMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sandbox Trace, SiteID:&apos;{0}&apos;   SiteName:&apos;{1}&apos;  Message:&apos;{2}&apos;.
        /// </summary>
        internal static string SandboxTraceMessage {
            get {
                return ResourceManager.GetString("SandboxTraceMessage", resourceCulture);
            }
        }
    }
}