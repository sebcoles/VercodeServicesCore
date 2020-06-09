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
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://analysiscenter.veracode.com/schema/mitigationinfo/1.0")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="https://analysiscenter.veracode.com/schema/mitigationinfo/1.0", IsNullable=false)]
public partial class mitigationinfo {
    
    private MitigationInfoIssueType[] issueField;
    
    private ErrorType[] errorField;
    
    private string mitigationinfo_versionField;
    
    private long build_idField;
    
    private bool build_idFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("issue")]
    public MitigationInfoIssueType[] issue {
        get {
            return this.issueField;
        }
        set {
            this.issueField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("error")]
    public ErrorType[] error {
        get {
            return this.errorField;
        }
        set {
            this.errorField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string mitigationinfo_version {
        get {
            return this.mitigationinfo_versionField;
        }
        set {
            this.mitigationinfo_versionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public long build_id {
        get {
            return this.build_idField;
        }
        set {
            this.build_idField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool build_idSpecified {
        get {
            return this.build_idFieldSpecified;
        }
        set {
            this.build_idFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="https://analysiscenter.veracode.com/schema/mitigationinfo/1.0")]
public partial class MitigationInfoIssueType {
    
    private MitigationActionType[] mitigation_actionField;
    
    private long flaw_idField;
    
    private bool flaw_idFieldSpecified;
    
    private string categoryField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("mitigation_action")]
    public MitigationActionType[] mitigation_action {
        get {
            return this.mitigation_actionField;
        }
        set {
            this.mitigation_actionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public long flaw_id {
        get {
            return this.flaw_idField;
        }
        set {
            this.flaw_idField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool flaw_idSpecified {
        get {
            return this.flaw_idFieldSpecified;
        }
        set {
            this.flaw_idFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string category {
        get {
            return this.categoryField;
        }
        set {
            this.categoryField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="https://analysiscenter.veracode.com/schema/mitigationinfo/1.0")]
public partial class MitigationActionType {
    
    private ActionTypeType actionField;
    
    private bool actionFieldSpecified;
    
    private string descField;
    
    private string reviewerField;
    
    private string dateField;
    
    private string commentField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ActionTypeType action {
        get {
            return this.actionField;
        }
        set {
            this.actionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool actionSpecified {
        get {
            return this.actionFieldSpecified;
        }
        set {
            this.actionFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string desc {
        get {
            return this.descField;
        }
        set {
            this.descField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string reviewer {
        get {
            return this.reviewerField;
        }
        set {
            this.reviewerField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string date {
        get {
            return this.dateField;
        }
        set {
            this.dateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string comment {
        get {
            return this.commentField;
        }
        set {
            this.commentField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="https://analysiscenter.veracode.com/schema/mitigationinfo/1.0")]
public enum ActionTypeType {
    
    /// <remarks/>
    comment,
    
    /// <remarks/>
    fp,
    
    /// <remarks/>
    library,
    
    /// <remarks/>
    acceptrisk,
    
    /// <remarks/>
    appdesign,
    
    /// <remarks/>
    osenv,
    
    /// <remarks/>
    netenv,
    
    /// <remarks/>
    rejected,
    
    /// <remarks/>
    accepted,
    
    /// <remarks/>
    remediated,
    
    /// <remarks/>
    noactiontaken,
    
    /// <remarks/>
    conforms,
    
    /// <remarks/>
    deviates,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="https://analysiscenter.veracode.com/schema/mitigationinfo/1.0")]
public partial class ErrorType {
    
    private string typeField;
    
    private string flaw_id_listField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string type {
        get {
            return this.typeField;
        }
        set {
            this.typeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string flaw_id_list {
        get {
            return this.flaw_id_listField;
        }
        set {
            this.flaw_id_listField = value;
        }
    }
}
}
