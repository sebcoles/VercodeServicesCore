﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.8.3928.0.
// 

namespace VeracodeService.Models
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://analysiscenter.veracode.com/schema/2.0/vendorlist")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="https://analysiscenter.veracode.com/schema/2.0/vendorlist", IsNullable=false)]
public partial class vendorlist {
    
    private VendorType[] vendorField;
    
    private long account_idField;
    
    private bool account_idFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("vendor")]
    public VendorType[] vendor {
        get {
            return this.vendorField;
        }
        set {
            this.vendorField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public long account_id {
        get {
            return this.account_idField;
        }
        set {
            this.account_idField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool account_idSpecified {
        get {
            return this.account_idFieldSpecified;
        }
        set {
            this.account_idFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="https://analysiscenter.veracode.com/schema/2.0/vendorlist")]
public partial class VendorType {
    
    private long vendor_idField;
    
    private bool vendor_idFieldSpecified;
    
    private string vendor_nameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public long vendor_id {
        get {
            return this.vendor_idField;
        }
        set {
            this.vendor_idField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool vendor_idSpecified {
        get {
            return this.vendor_idFieldSpecified;
        }
        set {
            this.vendor_idFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string vendor_name {
        get {
            return this.vendor_nameField;
        }
        set {
            this.vendor_nameField = value;
        }
    }
}
}

