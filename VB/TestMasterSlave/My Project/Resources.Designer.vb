﻿Imports System

'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.34209
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Namespace My.Resources


    ''' <summary>
    '''   A strongly-typed resource class, for looking up localized strings, etc.
    ''' </summary>
    ' This class was auto-generated by the StronglyTypedResourceBuilder
    ' class via a tool like ResGen or Visual Studio.
    ' To add or remove a member, edit your .ResX file then rerun ResGen
    ' with the /str option, or rebuild your VS project.
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"), Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(), _
    Global.Microsoft.VisualBasic.HideModuleNameAttribute()> _
    Friend Module Resources

        Private resourceMan As Global.System.Resources.ResourceManager

        Private resourceCulture As Global.System.Globalization.CultureInfo

'        internal Resources()
'        {
'        }

        ''' <summary>
        '''   Returns the cached ResourceManager instance used by this class.
        ''' </summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As New Global.System.Resources.ResourceManager("Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property

        ''' <summary>
        '''   Overrides the current thread's CurrentUICulture property for all
        '''   resource lookups using this strongly typed resource class.
        ''' </summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set(ByVal value As System.Globalization.CultureInfo)
                resourceCulture = value
            End Set
        End Property

        ''' <summary>
        '''   Looks up a localized string similar to &lt;BusinessPartnerData&gt;
        '''  &lt;BusinessPartner t_BusinessPartner__ID=&quot;2&quot; t_BusinessPartner__Number=&quot;3&quot; t_BusinessPartner__SearchTerm=&quot;kraxel&quot; t_BusinessPartner__Salutation_ID=&quot;3&quot; t_BusinessPartner__Name=&quot;Kraxel.com&quot; t_BusinessPartner__Employee_ID=&quot;9&quot; t_BusinessPartner__VoucherEmployee_ID=&quot;1&quot; t_BusinessPartner__ConcernedUnit_ID=&quot;3&quot; t_BusinessPartner__OwnNumberAtObject=&quot;0002&quot; t_BusinessPartner__ObjectType_ID=&quot;1&quot; t_BusinessPartner__ObjectMethod_ID=&quot;1&quot; t_BusinessPartner__BusinessPartnerType_ID=&quot;1&quot; t_BusinessPartner_ [rest of string was truncated]&quot;;.
        ''' </summary>
        Friend ReadOnly Property ExampleDataSet() As String
            Get
                Return ResourceManager.GetString("ExampleDataSet", resourceCulture)
            End Get
        End Property

        ''' <summary>
        '''   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; standalone=&quot;yes&quot;?&gt;
        '''&lt;xs:schema id=&quot;BusinessPartnerFullList&quot; xmlns=&quot;&quot; xmlns:xs=&quot;http://www.w3.org/2001/XMLSchema&quot; xmlns:msdata=&quot;urn:schemas-microsoft-com:xml-msdata&quot;&gt;
        '''  &lt;xs:element name=&quot;BusinessPartnerData&quot;&gt;
        '''    &lt;xs:complexType&gt;
        '''	&lt;xs:sequence&gt;
        '''	  &lt;xs:element name=&quot;BusinessPartner&quot; minOccurs=&quot;0&quot; maxOccurs=&quot;unbounded&quot;&gt;
        '''		&lt;xs:complexType&gt;
        '''		  &lt;xs:sequence&gt;
        '''			&lt;xs:element name=&quot;BusinessObject&quot; minOccurs=&quot;0&quot; maxOccurs=&quot;unbounded&quot;&gt;
        '''			  &lt;xs:complexType&gt;
        '''				&lt;xs:sequence&gt;
        '''				  &lt;xs:el [rest of string was truncated]&quot;;.
        ''' </summary>
        Friend ReadOnly Property ExampleDataSetSchema() As String
            Get
                Return ResourceManager.GetString("ExampleDataSetSchema", resourceCulture)
            End Get
        End Property
    End Module
End Namespace
