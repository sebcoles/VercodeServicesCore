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
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://analysiscenter.veracode.com/schema/4.0/buildinfo")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="https://analysiscenter.veracode.com/schema/4.0/buildinfo", IsNullable=false)]
public partial class buildinfo {
    
    private BuildInfoBuildType buildField;
    
    private string buildinfo_versionField;
    
    private long account_idField;
    
    private long app_idField;
    
    private long sandbox_idField;
    
    private bool sandbox_idFieldSpecified;
    
    private long build_idField;
    
    private BuildInfoADynamicScanType dynamic_scan_typeField;
    
    private bool dynamic_scan_typeFieldSpecified;
    
    /// <remarks/>
    public BuildInfoBuildType build {
        get {
            return this.buildField;
        }
        set {
            this.buildField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string buildinfo_version {
        get {
            return this.buildinfo_versionField;
        }
        set {
            this.buildinfo_versionField = value;
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
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public long app_id {
        get {
            return this.app_idField;
        }
        set {
            this.app_idField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public long sandbox_id {
        get {
            return this.sandbox_idField;
        }
        set {
            this.sandbox_idField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool sandbox_idSpecified {
        get {
            return this.sandbox_idFieldSpecified;
        }
        set {
            this.sandbox_idFieldSpecified = value;
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
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public BuildInfoADynamicScanType dynamic_scan_type {
        get {
            return this.dynamic_scan_typeField;
        }
        set {
            this.dynamic_scan_typeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool dynamic_scan_typeSpecified {
        get {
            return this.dynamic_scan_typeFieldSpecified;
        }
        set {
            this.dynamic_scan_typeFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="https://analysiscenter.veracode.com/schema/4.0/buildinfo")]
public partial class BuildInfoBuildType {
    
    private AnalysisUnitType[] analysis_unitField;
    
    private string versionField;
    
    private long build_idField;
    
    private bool build_idFieldSpecified;
    
    private string submitterField;
    
    private PlatformType platformField;
    
    private bool platformFieldSpecified;
    
    private LifecycleStageType lifecycle_stageField;
    
    private bool lifecycle_stageFieldSpecified;
    
    private bool results_readyField;
    
    private bool results_readyFieldSpecified;
    
    private string policy_nameField;
    
    private string policy_versionField;
    
    private PolicyComplianceType policy_compliance_statusField;
    
    private bool policy_compliance_statusFieldSpecified;
    
    private string policy_updated_dateField;
    
    private PolicyComplianceType rules_statusField;
    
    private bool rules_statusFieldSpecified;
    
    private bool grace_period_expiredField;
    
    private bool grace_period_expiredFieldSpecified;
    
    private bool scan_overdueField;
    
    private bool scan_overdueFieldSpecified;
    
    private bool legacy_scan_engineField;
    
    private bool legacy_scan_engineFieldSpecified;
    
    private System.DateTime launch_dateField;
    
    private bool launch_dateFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("analysis_unit")]
    public AnalysisUnitType[] analysis_unit {
        get {
            return this.analysis_unitField;
        }
        set {
            this.analysis_unitField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string version {
        get {
            return this.versionField;
        }
        set {
            this.versionField = value;
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
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string submitter {
        get {
            return this.submitterField;
        }
        set {
            this.submitterField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public PlatformType platform {
        get {
            return this.platformField;
        }
        set {
            this.platformField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool platformSpecified {
        get {
            return this.platformFieldSpecified;
        }
        set {
            this.platformFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public LifecycleStageType lifecycle_stage {
        get {
            return this.lifecycle_stageField;
        }
        set {
            this.lifecycle_stageField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool lifecycle_stageSpecified {
        get {
            return this.lifecycle_stageFieldSpecified;
        }
        set {
            this.lifecycle_stageFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool results_ready {
        get {
            return this.results_readyField;
        }
        set {
            this.results_readyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool results_readySpecified {
        get {
            return this.results_readyFieldSpecified;
        }
        set {
            this.results_readyFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string policy_name {
        get {
            return this.policy_nameField;
        }
        set {
            this.policy_nameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string policy_version {
        get {
            return this.policy_versionField;
        }
        set {
            this.policy_versionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public PolicyComplianceType policy_compliance_status {
        get {
            return this.policy_compliance_statusField;
        }
        set {
            this.policy_compliance_statusField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool policy_compliance_statusSpecified {
        get {
            return this.policy_compliance_statusFieldSpecified;
        }
        set {
            this.policy_compliance_statusFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string policy_updated_date {
        get {
            return this.policy_updated_dateField;
        }
        set {
            this.policy_updated_dateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public PolicyComplianceType rules_status {
        get {
            return this.rules_statusField;
        }
        set {
            this.rules_statusField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool rules_statusSpecified {
        get {
            return this.rules_statusFieldSpecified;
        }
        set {
            this.rules_statusFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool grace_period_expired {
        get {
            return this.grace_period_expiredField;
        }
        set {
            this.grace_period_expiredField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool grace_period_expiredSpecified {
        get {
            return this.grace_period_expiredFieldSpecified;
        }
        set {
            this.grace_period_expiredFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool scan_overdue {
        get {
            return this.scan_overdueField;
        }
        set {
            this.scan_overdueField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool scan_overdueSpecified {
        get {
            return this.scan_overdueFieldSpecified;
        }
        set {
            this.scan_overdueFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool legacy_scan_engine {
        get {
            return this.legacy_scan_engineField;
        }
        set {
            this.legacy_scan_engineField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool legacy_scan_engineSpecified {
        get {
            return this.legacy_scan_engineFieldSpecified;
        }
        set {
            this.legacy_scan_engineFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.DateTime launch_date {
        get {
            return this.launch_dateField;
        }
        set {
            this.launch_dateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool launch_dateSpecified {
        get {
            return this.launch_dateFieldSpecified;
        }
        set {
            this.launch_dateFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="https://analysiscenter.veracode.com/schema/4.0/buildinfo")]
public partial class AnalysisUnitType {
    
    private BuildInfoAnalysisType analysis_typeField;
    
    private bool analysis_typeFieldSpecified;
    
    private System.DateTime published_dateField;
    
    private bool published_dateFieldSpecified;
    
    private string published_date_secField;
    
    private BuildStatusType statusField;
    
    private bool statusFieldSpecified;
    
    private string estimated_scan_hoursField;
    
    private System.DateTime estimated_delivery_dateField;
    
    private bool estimated_delivery_dateFieldSpecified;
    
    private string engine_versionField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public BuildInfoAnalysisType analysis_type {
        get {
            return this.analysis_typeField;
        }
        set {
            this.analysis_typeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool analysis_typeSpecified {
        get {
            return this.analysis_typeFieldSpecified;
        }
        set {
            this.analysis_typeFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.DateTime published_date {
        get {
            return this.published_dateField;
        }
        set {
            this.published_dateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool published_dateSpecified {
        get {
            return this.published_dateFieldSpecified;
        }
        set {
            this.published_dateFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string published_date_sec {
        get {
            return this.published_date_secField;
        }
        set {
            this.published_date_secField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public BuildStatusType status {
        get {
            return this.statusField;
        }
        set {
            this.statusField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool statusSpecified {
        get {
            return this.statusFieldSpecified;
        }
        set {
            this.statusFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string estimated_scan_hours {
        get {
            return this.estimated_scan_hoursField;
        }
        set {
            this.estimated_scan_hoursField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.DateTime estimated_delivery_date {
        get {
            return this.estimated_delivery_dateField;
        }
        set {
            this.estimated_delivery_dateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool estimated_delivery_dateSpecified {
        get {
            return this.estimated_delivery_dateFieldSpecified;
        }
        set {
            this.estimated_delivery_dateFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string engine_version {
        get {
            return this.engine_versionField;
        }
        set {
            this.engine_versionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="https://analysiscenter.veracode.com/schema/4.0/buildinfo")]
public enum BuildInfoAnalysisType {
    
    /// <remarks/>
    Static,
    
    /// <remarks/>
    Dynamic,
    
    /// <remarks/>
    Manual,
    
    /// <remarks/>
    eDAST,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="https://analysiscenter.veracode.com/schema/4.0/buildinfo")]
public enum BuildStatusType {
    
    /// <remarks/>
    Incomplete,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Not Submitted to Engine")]
    NotSubmittedtoEngine,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Submitted to Engine")]
    SubmittedtoEngine,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Scan Errors")]
    ScanErrors,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Scan In Process")]
    ScanInProcess,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Scan Cancelled")]
    ScanCancelled,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Scan Internal Error")]
    ScanInternalError,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Pending Internal Review")]
    PendingInternalReview,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Results Ready")]
    ResultsReady,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Pre-Scan Submitted")]
    PreScanSubmitted,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Pre-Scan Failed")]
    PreScanFailed,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Pre-Scan Success")]
    PreScanSuccess,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("No Modules Defined")]
    NoModulesDefined,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Pending Vendor Confirmation")]
    PendingVendorConfirmation,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Vendor Reviewing")]
    VendorReviewing,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Pre-Scan Cancelled")]
    PreScanCancelled,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Scan On Hold")]
    ScanOnHold,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="https://analysiscenter.veracode.com/schema/4.0/buildinfo")]
public enum PlatformType {
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Not Specified")]
    NotSpecified,
    
    /// <remarks/>
    Windows,
    
    /// <remarks/>
    Solaris,
    
    /// <remarks/>
    Linux,
    
    /// <remarks/>
    Java,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Windows Mobile")]
    WindowsMobile,
    
    /// <remarks/>
    J2ME,
    
    /// <remarks/>
    ColdFusion,
    
    /// <remarks/>
    PHP,
    
    /// <remarks/>
    Android,
    
    /// <remarks/>
    iOS,
    
    /// <remarks/>
    Ruby,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="https://analysiscenter.veracode.com/schema/4.0/buildinfo")]
public enum LifecycleStageType {
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Not Specified")]
    NotSpecified,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("In Development (pre-Alpha)")]
    InDevelopmentpreAlpha,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Internal or Alpha Testing")]
    InternalorAlphaTesting,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("External or Beta Testing")]
    ExternalorBetaTesting,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Deployed (In production and actively developed)")]
    DeployedInproductionandactivelydeveloped,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Maintenance (only bug fixes)")]
    Maintenanceonlybugfixes,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Cannot Disclose")]
    CannotDisclose,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="https://analysiscenter.veracode.com/schema/4.0/buildinfo")]
public enum PolicyComplianceType {
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Calculating...")]
    Calculating,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Not Assessed")]
    NotAssessed,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Did Not Pass")]
    DidNotPass,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Conditional Pass")]
    ConditionalPass,
    
    /// <remarks/>
    Pass,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="https://analysiscenter.veracode.com/schema/4.0/buildinfo")]
public enum BuildInfoADynamicScanType {
    
    /// <remarks/>
    mp,
    
    /// <remarks/>
    ds,
}
    }
