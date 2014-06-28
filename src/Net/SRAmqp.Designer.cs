﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Amqp {
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
    internal class SRAmqp {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SRAmqp() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Amqp.SRAmqp", typeof(SRAmqp).Assembly);
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
        ///   Looks up a localized string similar to The session channel &apos;{0}&apos; cannot be found..
        /// </summary>
        internal static string AmqpChannelNotFound {
            get {
                return ResourceManager.GetString("AmqpChannelNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot allocate more handles. The maximum number of handles is {0}..
        /// </summary>
        internal static string AmqpHandleExceeded {
            get {
                return ResourceManager.GetString("AmqpHandleExceeded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The link handle &apos;{0}&apos; cannot be found in session &apos;{1}&apos;..
        /// </summary>
        internal static string AmqpHandleNotFound {
            get {
                return ResourceManager.GetString("AmqpHandleNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Operation &apos;{0}&apos; is not valid under state: {1}..
        /// </summary>
        internal static string AmqpIllegalOperationState {
            get {
                return ResourceManager.GetString("AmqpIllegalOperationState", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The format code &apos;{0}&apos; at frame buffer offset &apos;{1}&apos; is invalid (expected: {2})..
        /// </summary>
        internal static string AmqpInvalidFormatCode {
            get {
                return ResourceManager.GetString("AmqpInvalidFormatCode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is not supported over AMQP..
        /// </summary>
        internal static string AmqpOperationNotSupported {
            get {
                return ResourceManager.GetString("AmqpOperationNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The operation {0} did not complete within the allocated time {1} for object {2}..
        /// </summary>
        internal static string AmqpTimeout {
            get {
                return ResourceManager.GetString("AmqpTimeout", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The descriptor {0} is unknown..
        /// </summary>
        internal static string AmqpUnknownDescriptor {
            get {
                return ResourceManager.GetString("AmqpUnknownDescriptor", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There is no credit to accept a new delivery (id={0}) on the link..
        /// </summary>
        internal static string DeliveryLimitExceeded {
            get {
                return ResourceManager.GetString("DeliveryLimitExceeded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type &apos;{0}&apos; is not a valid AMQP type and cannot be encoded..
        /// </summary>
        internal static string EncodingTypeNotSupported {
            get {
                return ResourceManager.GetString("EncodingTypeNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The address is not correctly formatted..
        /// </summary>
        internal static string InvalidAddressFormat {
            get {
                return ResourceManager.GetString("InvalidAddressFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to transfer.delivery-id {0} is invalid (expect: {1}).
        /// </summary>
        internal static string InvalidDeliveryIdOnTransfer {
            get {
                return ResourceManager.GetString("InvalidDeliveryIdOnTransfer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid frame size:{0}, maximum frame size:{1}..
        /// </summary>
        internal static string InvalidFrameSize {
            get {
                return ResourceManager.GetString("InvalidFrameSize", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The map count {0} is invalid. It must be an even number..
        /// </summary>
        internal static string InvalidMapCount {
            get {
                return ResourceManager.GetString("InvalidMapCount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The key type {0} is invalid. The map key is restricted to {1}..
        /// </summary>
        internal static string InvalidMapKeyType {
            get {
                return ResourceManager.GetString("InvalidMapKeyType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Comparison of {0} and {1} is invalid because the result is undefined..
        /// </summary>
        internal static string InvalidSequenceNumberComparison {
            get {
                return ResourceManager.GetString("InvalidSequenceNumberComparison", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The link name {0} in the received attach cannot be found..
        /// </summary>
        internal static string LinkNotFound {
            get {
                return ResourceManager.GetString("LinkNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sasl negotiation failed with code {0}..
        /// </summary>
        internal static string SaslNegoFailed {
            get {
                return ResourceManager.GetString("SaslNegoFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There is no window to accept an incoming transfer (incoming-id={0})..
        /// </summary>
        internal static string WindowViolation {
            get {
                return ResourceManager.GetString("WindowViolation", resourceCulture);
            }
        }
    }
}
