﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TimeFudge {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resource1 {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource1() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("TimeFudge.Resource1", typeof(Resource1).Assembly);
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
        ///   Looks up a localized string similar to Error setting time...running without admin rights?.
        /// </summary>
        internal static string ErrorSettingTime {
            get {
                return ResourceManager.GetString("ErrorSettingTime", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid keypress option -- click, ctrl-click, or alt-click.
        /// </summary>
        internal static string InvalidKeyPress {
            get {
                return ResourceManager.GetString("InvalidKeyPress", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Click to add\nCtrl-Click to reverse direction\nAlt-Click to reset to original time\nNeutralize a station’s dT of +2.1 by fudging -2.1.
        /// </summary>
        internal static string toolTipButtonFudge {
            get {
                return ResourceManager.GetString("toolTipButtonFudge", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Total correction so far -- alt-click Fudge button to undo.
        /// </summary>
        internal static string toolTipLabelTotal {
            get {
                return ResourceManager.GetString("toolTipLabelTotal", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Seconds to fudge your clock.
        /// </summary>
        internal static string toolTipNumericUpDownSeconds {
            get {
                return ResourceManager.GetString("toolTipNumericUpDownSeconds", resourceCulture);
            }
        }
    }
}