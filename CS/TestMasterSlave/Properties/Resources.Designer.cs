﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestMasterSlave.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("TestMasterSlave.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to &lt;BusinessPartnerData&gt;
        ///  &lt;BusinessPartner t_BusinessPartner__ID=&quot;2&quot; t_BusinessPartner__Number=&quot;3&quot; t_BusinessPartner__SearchTerm=&quot;kraxel&quot; t_BusinessPartner__Salutation_ID=&quot;3&quot; t_BusinessPartner__Name=&quot;Kraxel.com&quot; t_BusinessPartner__Employee_ID=&quot;9&quot; t_BusinessPartner__VoucherEmployee_ID=&quot;1&quot; t_BusinessPartner__ConcernedUnit_ID=&quot;3&quot; t_BusinessPartner__OwnNumberAtObject=&quot;0002&quot; t_BusinessPartner__ObjectType_ID=&quot;1&quot; t_BusinessPartner__ObjectMethod_ID=&quot;1&quot; t_BusinessPartner__BusinessPartnerType_ID=&quot;1&quot; t_BusinessPartner_ [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ExampleDataSet {
            get {
                return ResourceManager.GetString("ExampleDataSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; standalone=&quot;yes&quot;?&gt;
        ///&lt;xs:schema id=&quot;BusinessPartnerFullList&quot; xmlns=&quot;&quot; xmlns:xs=&quot;http://www.w3.org/2001/XMLSchema&quot; xmlns:msdata=&quot;urn:schemas-microsoft-com:xml-msdata&quot;&gt;
        ///  &lt;xs:element name=&quot;BusinessPartnerData&quot;&gt;
        ///    &lt;xs:complexType&gt;
        ///	&lt;xs:sequence&gt;
        ///	  &lt;xs:element name=&quot;BusinessPartner&quot; minOccurs=&quot;0&quot; maxOccurs=&quot;unbounded&quot;&gt;
        ///		&lt;xs:complexType&gt;
        ///		  &lt;xs:sequence&gt;
        ///			&lt;xs:element name=&quot;BusinessObject&quot; minOccurs=&quot;0&quot; maxOccurs=&quot;unbounded&quot;&gt;
        ///			  &lt;xs:complexType&gt;
        ///				&lt;xs:sequence&gt;
        ///				  &lt;xs:el [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ExampleDataSetSchema {
            get {
                return ResourceManager.GetString("ExampleDataSetSchema", resourceCulture);
            }
        }
    }
}
