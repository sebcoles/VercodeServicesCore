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
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="https://analysiscenter.veracode.com/schema/2.0/appinfo")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="https://analysiscenter.veracode.com/schema/2.0/appinfo", IsNullable=false)]
public partial class appinfo {
    
    private ApplicationType[] applicationField;
    
    private string appinfo_versionField;
    
    private long account_idField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("application")]
    public ApplicationType[] application {
        get {
            return this.applicationField;
        }
        set {
            this.applicationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string appinfo_version {
        get {
            return this.appinfo_versionField;
        }
        set {
            this.appinfo_versionField = value;
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
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="https://analysiscenter.veracode.com/schema/2.0/appinfo")]
public partial class ApplicationType {
    
    private AppCustomFieldType[] customfieldField;
    
    private long app_idField;
    
    private bool app_idFieldSpecified;
    
    private string app_nameField;
    
    private string vendorField;
    
    private string descriptionField;
    
    private BusinessCriticalityType business_criticalityField;
    
    private bool business_criticalityFieldSpecified;
    
    private string policyField;
    
    private string policy_updated_dateField;
    
    private string teamsField;
    
    private OriginType originField;
    
    private bool originFieldSpecified;
    
    private IndustryVerticalType industry_verticalField;
    
    private bool industry_verticalFieldSpecified;
    
    private AppTypeType app_typeField;
    
    private bool app_typeFieldSpecified;
    
    private DeploymentMethodType deployment_methodField;
    
    private bool deployment_methodFieldSpecified;
    
    private bool is_web_applicationField;
    
    private bool is_web_applicationFieldSpecified;
    
    private string archer_app_nameField;
    
    private string modified_dateField;
    
    private bool cotsField;
    
    private bool cotsFieldSpecified;
    
    private bool vastField;
    
    private bool vastFieldSpecified;
    
    private long vendor_idField;
    
    private bool vendor_idFieldSpecified;
    
    private string business_unitField;
    
    private string business_ownerField;
    
    private string business_owner_emailField;
    
    private string tagsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("customfield")]
    public AppCustomFieldType[] customfield {
        get {
            return this.customfieldField;
        }
        set {
            this.customfieldField = value;
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
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool app_idSpecified {
        get {
            return this.app_idFieldSpecified;
        }
        set {
            this.app_idFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string app_name {
        get {
            return this.app_nameField;
        }
        set {
            this.app_nameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string vendor {
        get {
            return this.vendorField;
        }
        set {
            this.vendorField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public BusinessCriticalityType business_criticality {
        get {
            return this.business_criticalityField;
        }
        set {
            this.business_criticalityField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool business_criticalitySpecified {
        get {
            return this.business_criticalityFieldSpecified;
        }
        set {
            this.business_criticalityFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string policy {
        get {
            return this.policyField;
        }
        set {
            this.policyField = value;
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
    public string teams {
        get {
            return this.teamsField;
        }
        set {
            this.teamsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public OriginType origin {
        get {
            return this.originField;
        }
        set {
            this.originField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool originSpecified {
        get {
            return this.originFieldSpecified;
        }
        set {
            this.originFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public IndustryVerticalType industry_vertical {
        get {
            return this.industry_verticalField;
        }
        set {
            this.industry_verticalField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool industry_verticalSpecified {
        get {
            return this.industry_verticalFieldSpecified;
        }
        set {
            this.industry_verticalFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public AppTypeType app_type {
        get {
            return this.app_typeField;
        }
        set {
            this.app_typeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool app_typeSpecified {
        get {
            return this.app_typeFieldSpecified;
        }
        set {
            this.app_typeFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public DeploymentMethodType deployment_method {
        get {
            return this.deployment_methodField;
        }
        set {
            this.deployment_methodField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool deployment_methodSpecified {
        get {
            return this.deployment_methodFieldSpecified;
        }
        set {
            this.deployment_methodFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool is_web_application {
        get {
            return this.is_web_applicationField;
        }
        set {
            this.is_web_applicationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool is_web_applicationSpecified {
        get {
            return this.is_web_applicationFieldSpecified;
        }
        set {
            this.is_web_applicationFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string archer_app_name {
        get {
            return this.archer_app_nameField;
        }
        set {
            this.archer_app_nameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string modified_date {
        get {
            return this.modified_dateField;
        }
        set {
            this.modified_dateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool cots {
        get {
            return this.cotsField;
        }
        set {
            this.cotsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool cotsSpecified {
        get {
            return this.cotsFieldSpecified;
        }
        set {
            this.cotsFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool vast {
        get {
            return this.vastField;
        }
        set {
            this.vastField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool vastSpecified {
        get {
            return this.vastFieldSpecified;
        }
        set {
            this.vastFieldSpecified = value;
        }
    }
    
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
    public string business_unit {
        get {
            return this.business_unitField;
        }
        set {
            this.business_unitField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string business_owner {
        get {
            return this.business_ownerField;
        }
        set {
            this.business_ownerField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string business_owner_email {
        get {
            return this.business_owner_emailField;
        }
        set {
            this.business_owner_emailField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string tags {
        get {
            return this.tagsField;
        }
        set {
            this.tagsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="https://analysiscenter.veracode.com/schema/2.0/appinfo")]
public partial class AppCustomFieldType {
    
    private string nameField;
    
    private string valueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string value {
        get {
            return this.valueField;
        }
        set {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="https://analysiscenter.veracode.com/schema/2.0/appinfo")]
public enum BusinessCriticalityType {
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Very High")]
    VeryHigh,
    
    /// <remarks/>
    High,
    
    /// <remarks/>
    Medium,
    
    /// <remarks/>
    Low,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Very Low")]
    VeryLow,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="https://analysiscenter.veracode.com/schema/2.0/appinfo")]
public enum OriginType {
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Not Specified")]
    NotSpecified,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("3rd party library")]
    Item3rdpartylibrary,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Purchased Application")]
    PurchasedApplication,
    
    /// <remarks/>
    Contractor,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Internally Developed")]
    InternallyDeveloped,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Open Source")]
    OpenSource,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Outsourced Team")]
    OutsourcedTeam,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="https://analysiscenter.veracode.com/schema/2.0/appinfo")]
public enum IndustryVerticalType {
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Not Specified")]
    NotSpecified,
    
    /// <remarks/>
    Aerospace,
    
    /// <remarks/>
    Agriculture,
    
    /// <remarks/>
    Apparel,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Automotive and Transport")]
    AutomotiveandTransport,
    
    /// <remarks/>
    Banking,
    
    /// <remarks/>
    Beverages,
    
    /// <remarks/>
    Biotechnology,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Business Services")]
    BusinessServices,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Charitable Organizations")]
    CharitableOrganizations,
    
    /// <remarks/>
    Chemicals,
    
    /// <remarks/>
    Communications,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Computer Hardware")]
    ComputerHardware,
    
    /// <remarks/>
    Software,
    
    /// <remarks/>
    Consulting,
    
    /// <remarks/>
    Construction,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Consumer Products Manufacturers")]
    ConsumerProductsManufacturers,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Consumer Services")]
    ConsumerServices,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Cultural Institutions")]
    CulturalInstitutions,
    
    /// <remarks/>
    Education,
    
    /// <remarks/>
    Electronics,
    
    /// <remarks/>
    Energy,
    
    /// <remarks/>
    Engineering,
    
    /// <remarks/>
    Environmental,
    
    /// <remarks/>
    Finance,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Food & Beverage")]
    FoodBeverage,
    
    /// <remarks/>
    Foundations,
    
    /// <remarks/>
    Government,
    
    /// <remarks/>
    Healthcare,
    
    /// <remarks/>
    Hospitality,
    
    /// <remarks/>
    Manufacturing,
    
    /// <remarks/>
    Insurance,
    
    /// <remarks/>
    Recreation,
    
    /// <remarks/>
    Machinery,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Media & Entertainment")]
    MediaEntertainment,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Membership Organizations")]
    MembershipOrganizations,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Metals and Mining")]
    MetalsandMining,
    
    /// <remarks/>
    Pharmaceuticals,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Real Estate")]
    RealEstate,
    
    /// <remarks/>
    Retail,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Security Products and Services")]
    SecurityProductsandServices,
    
    /// <remarks/>
    Technology,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Telecommunications Equipment")]
    TelecommunicationsEquipment,
    
    /// <remarks/>
    Telecommunications,
    
    /// <remarks/>
    Transportation,
    
    /// <remarks/>
    Other,
    
    /// <remarks/>
    Utilities,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="https://analysiscenter.veracode.com/schema/2.0/appinfo")]
public enum AppTypeType {
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Not Specified")]
    NotSpecified,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Application Design/Construction/IDE/Analysis")]
    ApplicationDesignConstructionIDEAnalysis,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Application Life-Cycle Management")]
    ApplicationLifeCycleManagement,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Application Server/Integration Server")]
    ApplicationServerIntegrationServer,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Back-Office Enterprise")]
    BackOfficeEnterprise,
    
    /// <remarks/>
    CRM,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Collaboration/Groupware/Messaging")]
    CollaborationGroupwareMessaging,
    
    /// <remarks/>
    Consumer,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Content Management/Authoring")]
    ContentManagementAuthoring,
    
    /// <remarks/>
    Engineering,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Enterprise Resource Planning")]
    EnterpriseResourcePlanning,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Information Access/Delivery/Mining/Portal")]
    InformationAccessDeliveryMiningPortal,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Information/Data Management/Database")]
    InformationDataManagementDatabase,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Middleware/Message-oriented/Transaction")]
    MiddlewareMessageorientedTransaction,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Network Management")]
    NetworkManagement,
    
    /// <remarks/>
    Networking,
    
    /// <remarks/>
    Other,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Other Development Tools")]
    OtherDevelopmentTools,
    
    /// <remarks/>
    Security,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("ServerWare/Clustering/Web/VM")]
    ServerWareClusteringWebVM,
    
    /// <remarks/>
    Storage,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("System-Level Software")]
    SystemLevelSoftware,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Systems Management")]
    SystemsManagement,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Testing Tools")]
    TestingTools,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="https://analysiscenter.veracode.com/schema/2.0/appinfo")]
public enum DeploymentMethodType {
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Not Specified")]
    NotSpecified,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Web Based")]
    WebBased,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Enterprise Application Enhancement")]
    EnterpriseApplicationEnhancement,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Client/Server")]
    ClientServer,
    
    /// <remarks/>
    Mobile,
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("Stand Alone")]
    StandAlone,
}
    }
