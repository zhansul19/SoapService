using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;


namespace SoapService.Models
{
    public class models
    {
        // 
        // Этот исходный код был создан с помощью xsd, версия=4.8.3928.0.
        // 


        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
            [System.SerializableAttribute()]
            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://message.persistence.interactive.nat")]
            [System.Xml.Serialization.XmlRootAttribute("data", Namespace = "", IsNullable = false)]
            public partial class Response
            {

                private string messageIdField;

                private System.DateTime messageDateField;

                private string requestIdField;

                private Participant senderField;

                private Participant receiverField;

                private MessageResult messageResultField;

                private Person[] personsField;

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string messageId
                {
                    get
                    {
                        return this.messageIdField;
                    }
                    set
                    {
                        this.messageIdField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public System.DateTime messageDate
                {
                    get
                    {
                        return this.messageDateField;
                    }
                    set
                    {
                        this.messageDateField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string requestId
                {
                    get
                    {
                        return this.requestIdField;
                    }
                    set
                    {
                        this.requestIdField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public Participant sender
                {
                    get
                    {
                        return this.senderField;
                    }
                    set
                    {
                        this.senderField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public Participant receiver
                {
                    get
                    {
                        return this.receiverField;
                    }
                    set
                    {
                        this.receiverField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public MessageResult messageResult
                {
                    get
                    {
                        return this.messageResultField;
                    }
                    set
                    {
                        this.messageResultField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                [System.Xml.Serialization.XmlArrayItemAttribute("person", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
                public Person[] persons
                {
                    get
                    {
                        return this.personsField;
                    }
                    set
                    {
                        this.personsField = value;
                    }
                }
            }

            /// <remarks/>
            [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
            [System.SerializableAttribute()]
            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dictionaries.persistence.interactive.nat")]
            public partial class Participant
            {

                private string codeField;

                private string nameRuField;

                private string nameKzField;

                private System.Nullable<System.DateTime> changeDateField;

                private bool changeDateFieldSpecified;

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string code
                {
                    get
                    {
                        return this.codeField;
                    }
                    set
                    {
                        this.codeField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string nameRu
                {
                    get
                    {
                        return this.nameRuField;
                    }
                    set
                    {
                        this.nameRuField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string nameKz
                {
                    get
                    {
                        return this.nameKzField;
                    }
                    set
                    {
                        this.nameKzField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
                public System.Nullable<System.DateTime> changeDate
                {
                    get
                    {
                        return this.changeDateField;
                    }
                    set
                    {
                        this.changeDateField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlIgnoreAttribute()]
                public bool changeDateSpecified
                {
                    get
                    {
                        return this.changeDateFieldSpecified;
                    }
                    set
                    {
                        this.changeDateFieldSpecified = value;
                    }
                }
            }

            /// <remarks/>
            [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
            [System.SerializableAttribute()]
            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dictionaries.persistence.interactive.nat")]
            public partial class AddressType
            {

                private string codeField;

                private string nameRuField;

                private string nameKzField;

                private System.Nullable<System.DateTime> changeDateField;

                private bool changeDateFieldSpecified;

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string code
                {
                    get
                    {
                        return this.codeField;
                    }
                    set
                    {
                        this.codeField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string nameRu
                {
                    get
                    {
                        return this.nameRuField;
                    }
                    set
                    {
                        this.nameRuField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string nameKz
                {
                    get
                    {
                        return this.nameKzField;
                    }
                    set
                    {
                        this.nameKzField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
                public System.Nullable<System.DateTime> changeDate
                {
                    get
                    {
                        return this.changeDateField;
                    }
                    set
                    {
                        this.changeDateField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlIgnoreAttribute()]
                public bool changeDateSpecified
                {
                    get
                    {
                        return this.changeDateFieldSpecified;
                    }
                    set
                    {
                        this.changeDateFieldSpecified = value;
                    }
                }
            }

            /// <remarks/>
            [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
            [System.SerializableAttribute()]
            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://person.persistence.interactive.nat")]
            public partial class Address
            {

                private AddressType typeField;

                private Country countryField;

                private District districtField;

                private Region regionField;

                private ForeignData foreignDataField;

                private string cityField;

                private string streetField;

                private string buildingField;

                private string corpusField;

                private string flatField;

                private System.DateTime beginDateField;

                private bool beginDateFieldSpecified;

                private System.DateTime endDateField;

                private bool endDateFieldSpecified;

                private string arCodeField;

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public AddressType type
                {
                    get
                    {
                        return this.typeField;
                    }
                    set
                    {
                        this.typeField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public Country country
                {
                    get
                    {
                        return this.countryField;
                    }
                    set
                    {
                        this.countryField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public District district
                {
                    get
                    {
                        return this.districtField;
                    }
                    set
                    {
                        this.districtField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public Region region
                {
                    get
                    {
                        return this.regionField;
                    }
                    set
                    {
                        this.regionField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public ForeignData foreignData
                {
                    get
                    {
                        return this.foreignDataField;
                    }
                    set
                    {
                        this.foreignDataField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string city
                {
                    get
                    {
                        return this.cityField;
                    }
                    set
                    {
                        this.cityField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string street
                {
                    get
                    {
                        return this.streetField;
                    }
                    set
                    {
                        this.streetField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string building
                {
                    get
                    {
                        return this.buildingField;
                    }
                    set
                    {
                        this.buildingField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string corpus
                {
                    get
                    {
                        return this.corpusField;
                    }
                    set
                    {
                        this.corpusField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string flat
                {
                    get
                    {
                        return this.flatField;
                    }
                    set
                    {
                        this.flatField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "date")]
                public System.DateTime beginDate
                {
                    get
                    {
                        return this.beginDateField;
                    }
                    set
                    {
                        this.beginDateField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlIgnoreAttribute()]
                public bool beginDateSpecified
                {
                    get
                    {
                        return this.beginDateFieldSpecified;
                    }
                    set
                    {
                        this.beginDateFieldSpecified = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "date")]
                public System.DateTime endDate
                {
                    get
                    {
                        return this.endDateField;
                    }
                    set
                    {
                        this.endDateField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlIgnoreAttribute()]
                public bool endDateSpecified
                {
                    get
                    {
                        return this.endDateFieldSpecified;
                    }
                    set
                    {
                        this.endDateFieldSpecified = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string arCode
                {
                    get
                    {
                        return this.arCodeField;
                    }
                    set
                    {
                        this.arCodeField = value;
                    }
                }
            }

            /// <remarks/>
            [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
            [System.SerializableAttribute()]
            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dictionaries.persistence.interactive.nat")]
            public partial class Country
            {

                private string codeField;

                private string nameRuField;

                private string nameKzField;

                private System.Nullable<System.DateTime> changeDateField;

                private bool changeDateFieldSpecified;

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string code
                {
                    get
                    {
                        return this.codeField;
                    }
                    set
                    {
                        this.codeField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string nameRu
                {
                    get
                    {
                        return this.nameRuField;
                    }
                    set
                    {
                        this.nameRuField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string nameKz
                {
                    get
                    {
                        return this.nameKzField;
                    }
                    set
                    {
                        this.nameKzField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
                public System.Nullable<System.DateTime> changeDate
                {
                    get
                    {
                        return this.changeDateField;
                    }
                    set
                    {
                        this.changeDateField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlIgnoreAttribute()]
                public bool changeDateSpecified
                {
                    get
                    {
                        return this.changeDateFieldSpecified;
                    }
                    set
                    {
                        this.changeDateFieldSpecified = value;
                    }
                }
            }

            /// <remarks/>
            [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
            [System.SerializableAttribute()]
            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dictionaries.persistence.interactive.nat")]
            public partial class District
            {

                private string codeField;

                private string nameRuField;

                private string nameKzField;

                private System.Nullable<System.DateTime> changeDateField;

                private bool changeDateFieldSpecified;

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string code
                {
                    get
                    {
                        return this.codeField;
                    }
                    set
                    {
                        this.codeField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string nameRu
                {
                    get
                    {
                        return this.nameRuField;
                    }
                    set
                    {
                        this.nameRuField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string nameKz
                {
                    get
                    {
                        return this.nameKzField;
                    }
                    set
                    {
                        this.nameKzField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
                public System.Nullable<System.DateTime> changeDate
                {
                    get
                    {
                        return this.changeDateField;
                    }
                    set
                    {
                        this.changeDateField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlIgnoreAttribute()]
                public bool changeDateSpecified
                {
                    get
                    {
                        return this.changeDateFieldSpecified;
                    }
                    set
                    {
                        this.changeDateFieldSpecified = value;
                    }
                }
            }

            /// <remarks/>
            [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
            [System.SerializableAttribute()]
            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dictionaries.persistence.interactive.nat")]
            public partial class Region
            {

                private string codeField;

                private string nameRuField;

                private string nameKzField;

                private System.Nullable<System.DateTime> changeDateField;

                private bool changeDateFieldSpecified;

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string code
                {
                    get
                    {
                        return this.codeField;
                    }
                    set
                    {
                        this.codeField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string nameRu
                {
                    get
                    {
                        return this.nameRuField;
                    }
                    set
                    {
                        this.nameRuField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string nameKz
                {
                    get
                    {
                        return this.nameKzField;
                    }
                    set
                    {
                        this.nameKzField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
                public System.Nullable<System.DateTime> changeDate
                {
                    get
                    {
                        return this.changeDateField;
                    }
                    set
                    {
                        this.changeDateField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlIgnoreAttribute()]
                public bool changeDateSpecified
                {
                    get
                    {
                        return this.changeDateFieldSpecified;
                    }
                    set
                    {
                        this.changeDateFieldSpecified = value;
                    }
                }
            }

            /// <remarks/>
            [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
            [System.SerializableAttribute()]
            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://person.persistence.interactive.nat")]
            public partial class ForeignData
            {

                private string districtNameField;

                private string regionNameField;

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string districtName
                {
                    get
                    {
                        return this.districtNameField;
                    }
                    set
                    {
                        this.districtNameField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string regionName
                {
                    get
                    {
                        return this.regionNameField;
                    }
                    set
                    {
                        this.regionNameField = value;
                    }
                }
            }

            /// <remarks/>
            [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
            [System.SerializableAttribute()]
            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dictionaries.persistence.interactive.nat")]
            public partial class DocumentInvalidity
            {

                private string codeField;

                private string nameRuField;

                private string nameKzField;

                private System.Nullable<System.DateTime> changeDateField;

                private bool changeDateFieldSpecified;

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string code
                {
                    get
                    {
                        return this.codeField;
                    }
                    set
                    {
                        this.codeField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string nameRu
                {
                    get
                    {
                        return this.nameRuField;
                    }
                    set
                    {
                        this.nameRuField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string nameKz
                {
                    get
                    {
                        return this.nameKzField;
                    }
                    set
                    {
                        this.nameKzField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
                public System.Nullable<System.DateTime> changeDate
                {
                    get
                    {
                        return this.changeDateField;
                    }
                    set
                    {
                        this.changeDateField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlIgnoreAttribute()]
                public bool changeDateSpecified
                {
                    get
                    {
                        return this.changeDateFieldSpecified;
                    }
                    set
                    {
                        this.changeDateFieldSpecified = value;
                    }
                }
            }

            /// <remarks/>
            [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
            [System.SerializableAttribute()]
            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dictionaries.persistence.interactive.nat")]
            public partial class DocumentOrganization
            {

                private string codeField;

                private string nameRuField;

                private string nameKzField;

                private System.Nullable<System.DateTime> changeDateField;

                private bool changeDateFieldSpecified;

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string code
                {
                    get
                    {
                        return this.codeField;
                    }
                    set
                    {
                        this.codeField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string nameRu
                {
                    get
                    {
                        return this.nameRuField;
                    }
                    set
                    {
                        this.nameRuField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string nameKz
                {
                    get
                    {
                        return this.nameKzField;
                    }
                    set
                    {
                        this.nameKzField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
                public System.Nullable<System.DateTime> changeDate
                {
                    get
                    {
                        return this.changeDateField;
                    }
                    set
                    {
                        this.changeDateField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlIgnoreAttribute()]
                public bool changeDateSpecified
                {
                    get
                    {
                        return this.changeDateFieldSpecified;
                    }
                    set
                    {
                        this.changeDateFieldSpecified = value;
                    }
                }
            }

            /// <remarks/>
            [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
            [System.SerializableAttribute()]
            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dictionaries.persistence.interactive.nat")]
            public partial class DocumentType
            {

                private string codeField;

                private string nameRuField;

                private string nameKzField;

                private System.Nullable<System.DateTime> changeDateField;

                private bool changeDateFieldSpecified;

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string code
                {
                    get
                    {
                        return this.codeField;
                    }
                    set
                    {
                        this.codeField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string nameRu
                {
                    get
                    {
                        return this.nameRuField;
                    }
                    set
                    {
                        this.nameRuField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string nameKz
                {
                    get
                    {
                        return this.nameKzField;
                    }
                    set
                    {
                        this.nameKzField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
                public System.Nullable<System.DateTime> changeDate
                {
                    get
                    {
                        return this.changeDateField;
                    }
                    set
                    {
                        this.changeDateField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlIgnoreAttribute()]
                public bool changeDateSpecified
                {
                    get
                    {
                        return this.changeDateFieldSpecified;
                    }
                    set
                    {
                        this.changeDateFieldSpecified = value;
                    }
                }
            }

            /// <remarks/>
            [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
            [System.SerializableAttribute()]
            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://document.persistence.interactive.nat")]
            public partial class Document
            {

                private DocumentType typeField;

                private string numberField;

                private string seriesField;

                private System.DateTime beginDateField;

                private System.DateTime endDateField;

                private bool endDateFieldSpecified;

                private DocumentOrganization issueOrganizationField;

                private DocumentInvalidity statusField;

                private System.DateTime invalidityDateField;

                private bool invalidityDateFieldSpecified;

                private string surnameField;

                private string nameField;

                private string patronymicField;

                private System.DateTime birthDateField;

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public DocumentType type
                {
                    get
                    {
                        return this.typeField;
                    }
                    set
                    {
                        this.typeField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string number
                {
                    get
                    {
                        return this.numberField;
                    }
                    set
                    {
                        this.numberField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string series
                {
                    get
                    {
                        return this.seriesField;
                    }
                    set
                    {
                        this.seriesField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "date")]
                public System.DateTime beginDate
                {
                    get
                    {
                        return this.beginDateField;
                    }
                    set
                    {
                        this.beginDateField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "date")]
                public System.DateTime endDate
                {
                    get
                    {
                        return this.endDateField;
                    }
                    set
                    {
                        this.endDateField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlIgnoreAttribute()]
                public bool endDateSpecified
                {
                    get
                    {
                        return this.endDateFieldSpecified;
                    }
                    set
                    {
                        this.endDateFieldSpecified = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public DocumentOrganization issueOrganization
                {
                    get
                    {
                        return this.issueOrganizationField;
                    }
                    set
                    {
                        this.issueOrganizationField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public DocumentInvalidity status
                {
                    get
                    {
                        return this.statusField;
                    }
                    set
                    {
                        this.statusField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "date")]
                public System.DateTime invalidityDate
                {
                    get
                    {
                        return this.invalidityDateField;
                    }
                    set
                    {
                        this.invalidityDateField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlIgnoreAttribute()]
                public bool invalidityDateSpecified
                {
                    get
                    {
                        return this.invalidityDateFieldSpecified;
                    }
                    set
                    {
                        this.invalidityDateFieldSpecified = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string surname
                {
                    get
                    {
                        return this.surnameField;
                    }
                    set
                    {
                        this.surnameField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string name
                {
                    get
                    {
                        return this.nameField;
                    }
                    set
                    {
                        this.nameField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string patronymic
                {
                    get
                    {
                        return this.patronymicField;
                    }
                    set
                    {
                        this.patronymicField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "date")]
                public System.DateTime birthDate
                {
                    get
                    {
                        return this.birthDateField;
                    }
                    set
                    {
                        this.birthDateField = value;
                    }
                }
            }

            /// <remarks/>
            [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
            [System.SerializableAttribute()]
            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dictionaries.persistence.interactive.nat")]
            public partial class repatriationReason
            {

                private string codeField;

                private string nameRuField;

                private string nameKzField;

                private System.Nullable<System.DateTime> changeDateField;

                private bool changeDateFieldSpecified;

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string code
                {
                    get
                    {
                        return this.codeField;
                    }
                    set
                    {
                        this.codeField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string nameRu
                {
                    get
                    {
                        return this.nameRuField;
                    }
                    set
                    {
                        this.nameRuField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string nameKz
                {
                    get
                    {
                        return this.nameKzField;
                    }
                    set
                    {
                        this.nameKzField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
                public System.Nullable<System.DateTime> changeDate
                {
                    get
                    {
                        return this.changeDateField;
                    }
                    set
                    {
                        this.changeDateField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlIgnoreAttribute()]
                public bool changeDateSpecified
                {
                    get
                    {
                        return this.changeDateFieldSpecified;
                    }
                    set
                    {
                        this.changeDateFieldSpecified = value;
                    }
                }
            }

            /// <remarks/>
            [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
            [System.SerializableAttribute()]
            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dictionaries.persistence.interactive.nat")]
            public partial class repatriationOrg
            {

                private string codeField;

                private string nameRuField;

                private string nameKzField;

                private System.Nullable<System.DateTime> changeDateField;

                private bool changeDateFieldSpecified;

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string code
                {
                    get
                    {
                        return this.codeField;
                    }
                    set
                    {
                        this.codeField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string nameRu
                {
                    get
                    {
                        return this.nameRuField;
                    }
                    set
                    {
                        this.nameRuField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string nameKz
                {
                    get
                    {
                        return this.nameKzField;
                    }
                    set
                    {
                        this.nameKzField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
                public System.Nullable<System.DateTime> changeDate
                {
                    get
                    {
                        return this.changeDateField;
                    }
                    set
                    {
                        this.changeDateField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlIgnoreAttribute()]
                public bool changeDateSpecified
                {
                    get
                    {
                        return this.changeDateFieldSpecified;
                    }
                    set
                    {
                        this.changeDateFieldSpecified = value;
                    }
                }
            }

            /// <remarks/>
            [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
            [System.SerializableAttribute()]
            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dictionaries.persistence.interactive.nat")]
            public partial class repatriationStatus
            {

                private string codeField;

                private string nameRuField;

                private string nameKzField;

                private System.Nullable<System.DateTime> changeDateField;

                private bool changeDateFieldSpecified;

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string code
                {
                    get
                    {
                        return this.codeField;
                    }
                    set
                    {
                        this.codeField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string nameRu
                {
                    get
                    {
                        return this.nameRuField;
                    }
                    set
                    {
                        this.nameRuField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string nameKz
                {
                    get
                    {
                        return this.nameKzField;
                    }
                    set
                    {
                        this.nameKzField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
                public System.Nullable<System.DateTime> changeDate
                {
                    get
                    {
                        return this.changeDateField;
                    }
                    set
                    {
                        this.changeDateField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlIgnoreAttribute()]
                public bool changeDateSpecified
                {
                    get
                    {
                        return this.changeDateFieldSpecified;
                    }
                    set
                    {
                        this.changeDateFieldSpecified = value;
                    }
                }
            }

            /// <remarks/>
            [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
            [System.SerializableAttribute()]
            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://person.persistence.interactive.nat")]
            public partial class personRepatriationStatus
            {

                private repatriationStatus repatriationStatusField;

                private System.DateTime repatriationDateField;

                private bool repatriationDateFieldSpecified;

                private System.DateTime repatriationEndDateField;

                private bool repatriationEndDateFieldSpecified;

                private string repatriationNumberField;

                private repatriationOrg repatriationOrgField;

                private repatriationReason repatriationReasonField;

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public repatriationStatus repatriationStatus
                {
                    get
                    {
                        return this.repatriationStatusField;
                    }
                    set
                    {
                        this.repatriationStatusField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public System.DateTime repatriationDate
                {
                    get
                    {
                        return this.repatriationDateField;
                    }
                    set
                    {
                        this.repatriationDateField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlIgnoreAttribute()]
                public bool repatriationDateSpecified
                {
                    get
                    {
                        return this.repatriationDateFieldSpecified;
                    }
                    set
                    {
                        this.repatriationDateFieldSpecified = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public System.DateTime repatriationEndDate
                {
                    get
                    {
                        return this.repatriationEndDateField;
                    }
                    set
                    {
                        this.repatriationEndDateField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlIgnoreAttribute()]
                public bool repatriationEndDateSpecified
                {
                    get
                    {
                        return this.repatriationEndDateFieldSpecified;
                    }
                    set
                    {
                        this.repatriationEndDateFieldSpecified = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string repatriationNumber
                {
                    get
                    {
                        return this.repatriationNumberField;
                    }
                    set
                    {
                        this.repatriationNumberField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public repatriationOrg repatriationOrg
                {
                    get
                    {
                        return this.repatriationOrgField;
                    }
                    set
                    {
                        this.repatriationOrgField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public repatriationReason repatriationReason
                {
                    get
                    {
                        return this.repatriationReasonField;
                    }
                    set
                    {
                        this.repatriationReasonField = value;
                    }
                }
            }

            /// <remarks/>
            [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
            [System.SerializableAttribute()]
            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dictionaries.persistence.interactive.nat")]
            public partial class ExcludeReason
            {

                private string codeField;

                private string nameRuField;

                private string nameKzField;

                private System.Nullable<System.DateTime> changeDateField;

                private bool changeDateFieldSpecified;

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string code
                {
                    get
                    {
                        return this.codeField;
                    }
                    set
                    {
                        this.codeField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string nameRu
                {
                    get
                    {
                        return this.nameRuField;
                    }
                    set
                    {
                        this.nameRuField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string nameKz
                {
                    get
                    {
                        return this.nameKzField;
                    }
                    set
                    {
                        this.nameKzField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
                public System.Nullable<System.DateTime> changeDate
                {
                    get
                    {
                        return this.changeDateField;
                    }
                    set
                    {
                        this.changeDateField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlIgnoreAttribute()]
                public bool changeDateSpecified
                {
                    get
                    {
                        return this.changeDateFieldSpecified;
                    }
                    set
                    {
                        this.changeDateFieldSpecified = value;
                    }
                }
            }

            /// <remarks/>
            [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
            [System.SerializableAttribute()]
            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://person.persistence.interactive.nat")]
            public partial class PersonExcludeStatus
            {

                private ExcludeReason excludeReasonField;

                private System.DateTime excludeReasonDateField;

                private bool excludeReasonDateFieldSpecified;

                private System.DateTime excludeDateField;

                private bool excludeDateFieldSpecified;

                private Participant excludeParticipantField;

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public ExcludeReason excludeReason
                {
                    get
                    {
                        return this.excludeReasonField;
                    }
                    set
                    {
                        this.excludeReasonField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "date")]
                public System.DateTime excludeReasonDate
                {
                    get
                    {
                        return this.excludeReasonDateField;
                    }
                    set
                    {
                        this.excludeReasonDateField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlIgnoreAttribute()]
                public bool excludeReasonDateSpecified
                {
                    get
                    {
                        return this.excludeReasonDateFieldSpecified;
                    }
                    set
                    {
                        this.excludeReasonDateFieldSpecified = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "date")]
                public System.DateTime excludeDate
                {
                    get
                    {
                        return this.excludeDateField;
                    }
                    set
                    {
                        this.excludeDateField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlIgnoreAttribute()]
                public bool excludeDateSpecified
                {
                    get
                    {
                        return this.excludeDateFieldSpecified;
                    }
                    set
                    {
                        this.excludeDateFieldSpecified = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public Participant excludeParticipant
                {
                    get
                    {
                        return this.excludeParticipantField;
                    }
                    set
                    {
                        this.excludeParticipantField = value;
                    }
                }
            }

            /// <remarks/>
            [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
            [System.SerializableAttribute()]
            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://person.persistence.interactive.nat")]
            public partial class DisappearStatus
            {

                private bool disappearField;

                private System.DateTime disappearDateField;

                private System.DateTime disappearEndDateField;

                private bool disappearEndDateFieldSpecified;

                private string disappearNumberField;

                private GpTerritorial gpTerritorialField;

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public bool disappear
                {
                    get
                    {
                        return this.disappearField;
                    }
                    set
                    {
                        this.disappearField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "date")]
                public System.DateTime disappearDate
                {
                    get
                    {
                        return this.disappearDateField;
                    }
                    set
                    {
                        this.disappearDateField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "date")]
                public System.DateTime disappearEndDate
                {
                    get
                    {
                        return this.disappearEndDateField;
                    }
                    set
                    {
                        this.disappearEndDateField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlIgnoreAttribute()]
                public bool disappearEndDateSpecified
                {
                    get
                    {
                        return this.disappearEndDateFieldSpecified;
                    }
                    set
                    {
                        this.disappearEndDateFieldSpecified = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string disappearNumber
                {
                    get
                    {
                        return this.disappearNumberField;
                    }
                    set
                    {
                        this.disappearNumberField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public GpTerritorial gpTerritorial
                {
                    get
                    {
                        return this.gpTerritorialField;
                    }
                    set
                    {
                        this.gpTerritorialField = value;
                    }
                }
            }

            /// <remarks/>
            [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
            [System.SerializableAttribute()]
            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dictionaries.persistence.interactive.nat")]
            public partial class GpTerritorial
            {

                private string codeField;

                private string nameRuField;

                private string nameKzField;

                private System.Nullable<System.DateTime> changeDateField;

                private bool changeDateFieldSpecified;

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string code
                {
                    get
                    {
                        return this.codeField;
                    }
                    set
                    {
                        this.codeField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string nameRu
                {
                    get
                    {
                        return this.nameRuField;
                    }
                    set
                    {
                        this.nameRuField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string nameKz
                {
                    get
                    {
                        return this.nameKzField;
                    }
                    set
                    {
                        this.nameKzField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
                public System.Nullable<System.DateTime> changeDate
                {
                    get
                    {
                        return this.changeDateField;
                    }
                    set
                    {
                        this.changeDateField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlIgnoreAttribute()]
                public bool changeDateSpecified
                {
                    get
                    {
                        return this.changeDateFieldSpecified;
                    }
                    set
                    {
                        this.changeDateFieldSpecified = value;
                    }
                }
            }

            /// <remarks/>
            [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
            [System.SerializableAttribute()]
            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://person.persistence.interactive.nat")]
            public partial class MissingStatus
            {

                private bool missingField;

                private System.DateTime missingDateField;

                private System.DateTime missingEndDateField;

                private bool missingEndDateFieldSpecified;

                private string missingNumberField;

                private GpTerritorial gpTerritorialField;

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public bool missing
                {
                    get
                    {
                        return this.missingField;
                    }
                    set
                    {
                        this.missingField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "date")]
                public System.DateTime missingDate
                {
                    get
                    {
                        return this.missingDateField;
                    }
                    set
                    {
                        this.missingDateField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "date")]
                public System.DateTime missingEndDate
                {
                    get
                    {
                        return this.missingEndDateField;
                    }
                    set
                    {
                        this.missingEndDateField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlIgnoreAttribute()]
                public bool missingEndDateSpecified
                {
                    get
                    {
                        return this.missingEndDateFieldSpecified;
                    }
                    set
                    {
                        this.missingEndDateFieldSpecified = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string missingNumber
                {
                    get
                    {
                        return this.missingNumberField;
                    }
                    set
                    {
                        this.missingNumberField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public GpTerritorial gpTerritorial
                {
                    get
                    {
                        return this.gpTerritorialField;
                    }
                    set
                    {
                        this.gpTerritorialField = value;
                    }
                }
            }

            /// <remarks/>
            [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
            [System.SerializableAttribute()]
            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dictionaries.persistence.interactive.nat")]
            public partial class Court
            {

                private string codeField;

                private string nameRuField;

                private string nameKzField;

                private System.Nullable<System.DateTime> changeDateField;

                private bool changeDateFieldSpecified;

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string code
                {
                    get
                    {
                        return this.codeField;
                    }
                    set
                    {
                        this.codeField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string nameRu
                {
                    get
                    {
                        return this.nameRuField;
                    }
                    set
                    {
                        this.nameRuField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string nameKz
                {
                    get
                    {
                        return this.nameKzField;
                    }
                    set
                    {
                        this.nameKzField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
                public System.Nullable<System.DateTime> changeDate
                {
                    get
                    {
                        return this.changeDateField;
                    }
                    set
                    {
                        this.changeDateField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlIgnoreAttribute()]
                public bool changeDateSpecified
                {
                    get
                    {
                        return this.changeDateFieldSpecified;
                    }
                    set
                    {
                        this.changeDateFieldSpecified = value;
                    }
                }
            }

            /// <remarks/>
            [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
            [System.SerializableAttribute()]
            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dictionaries.persistence.interactive.nat")]
            public partial class CapableStatus
            {

                private string codeField;

                private string nameRuField;

                private string nameKzField;

                private System.Nullable<System.DateTime> changeDateField;

                private bool changeDateFieldSpecified;

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string code
                {
                    get
                    {
                        return this.codeField;
                    }
                    set
                    {
                        this.codeField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string nameRu
                {
                    get
                    {
                        return this.nameRuField;
                    }
                    set
                    {
                        this.nameRuField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string nameKz
                {
                    get
                    {
                        return this.nameKzField;
                    }
                    set
                    {
                        this.nameKzField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
                public System.Nullable<System.DateTime> changeDate
                {
                    get
                    {
                        return this.changeDateField;
                    }
                    set
                    {
                        this.changeDateField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlIgnoreAttribute()]
                public bool changeDateSpecified
                {
                    get
                    {
                        return this.changeDateFieldSpecified;
                    }
                    set
                    {
                        this.changeDateFieldSpecified = value;
                    }
                }
            }

            /// <remarks/>
            [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
            [System.SerializableAttribute()]
            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://person.persistence.interactive.nat")]
            public partial class PersonCapableStatus
            {

                private CapableStatus capableStatusField;

                private System.DateTime capableDateField;

                private System.DateTime capableEndDateField;

                private bool capableEndDateFieldSpecified;

                private string capableNumberField;

                private Court courtField;

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public CapableStatus capableStatus
                {
                    get
                    {
                        return this.capableStatusField;
                    }
                    set
                    {
                        this.capableStatusField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "date")]
                public System.DateTime capableDate
                {
                    get
                    {
                        return this.capableDateField;
                    }
                    set
                    {
                        this.capableDateField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "date")]
                public System.DateTime capableEndDate
                {
                    get
                    {
                        return this.capableEndDateField;
                    }
                    set
                    {
                        this.capableEndDateField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlIgnoreAttribute()]
                public bool capableEndDateSpecified
                {
                    get
                    {
                        return this.capableEndDateFieldSpecified;
                    }
                    set
                    {
                        this.capableEndDateFieldSpecified = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string capableNumber
                {
                    get
                    {
                        return this.capableNumberField;
                    }
                    set
                    {
                        this.capableNumberField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public Court court
                {
                    get
                    {
                        return this.courtField;
                    }
                    set
                    {
                        this.courtField = value;
                    }
                }
            }

            /// <remarks/>
            [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
            [System.SerializableAttribute()]
            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dictionaries.persistence.interactive.nat")]
            public partial class AddressInvalidity
            {

                private string codeField;

                private string nameRuField;

                private string nameKzField;

                private System.Nullable<System.DateTime> changeDateField;

                private bool changeDateFieldSpecified;

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string code
                {
                    get
                    {
                        return this.codeField;
                    }
                    set
                    {
                        this.codeField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string nameRu
                {
                    get
                    {
                        return this.nameRuField;
                    }
                    set
                    {
                        this.nameRuField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string nameKz
                {
                    get
                    {
                        return this.nameKzField;
                    }
                    set
                    {
                        this.nameKzField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
                public System.Nullable<System.DateTime> changeDate
                {
                    get
                    {
                        return this.changeDateField;
                    }
                    set
                    {
                        this.changeDateField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlIgnoreAttribute()]
                public bool changeDateSpecified
                {
                    get
                    {
                        return this.changeDateFieldSpecified;
                    }
                    set
                    {
                        this.changeDateFieldSpecified = value;
                    }
                }
            }

            /// <remarks/>
            [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
            [System.SerializableAttribute()]
            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dictionaries.persistence.interactive.nat")]
            public partial class AddressStatus
            {

                private string codeField;

                private string nameRuField;

                private string nameKzField;

                private System.Nullable<System.DateTime> changeDateField;

                private bool changeDateFieldSpecified;

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string code
                {
                    get
                    {
                        return this.codeField;
                    }
                    set
                    {
                        this.codeField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string nameRu
                {
                    get
                    {
                        return this.nameRuField;
                    }
                    set
                    {
                        this.nameRuField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string nameKz
                {
                    get
                    {
                        return this.nameKzField;
                    }
                    set
                    {
                        this.nameKzField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
                public System.Nullable<System.DateTime> changeDate
                {
                    get
                    {
                        return this.changeDateField;
                    }
                    set
                    {
                        this.changeDateField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlIgnoreAttribute()]
                public bool changeDateSpecified
                {
                    get
                    {
                        return this.changeDateFieldSpecified;
                    }
                    set
                    {
                        this.changeDateFieldSpecified = value;
                    }
                }
            }

            /// <remarks/>
            [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
            [System.SerializableAttribute()]
            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://person.persistence.interactive.nat")]
            public partial class RegAddress
            {

                private Country countryField;

                private District districtField;

                private Region regionField;

                private ForeignData foreignDataField;

                private string cityField;

                private string streetField;

                private string buildingField;

                private string corpusField;

                private string flatField;

                private System.DateTime beginDateField;

                private bool beginDateFieldSpecified;

                private System.DateTime endDateField;

                private bool endDateFieldSpecified;

                private AddressStatus statusField;

                private AddressInvalidity invalidityField;

                private string arCodeField;

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public Country country
                {
                    get
                    {
                        return this.countryField;
                    }
                    set
                    {
                        this.countryField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public District district
                {
                    get
                    {
                        return this.districtField;
                    }
                    set
                    {
                        this.districtField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public Region region
                {
                    get
                    {
                        return this.regionField;
                    }
                    set
                    {
                        this.regionField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public ForeignData foreignData
                {
                    get
                    {
                        return this.foreignDataField;
                    }
                    set
                    {
                        this.foreignDataField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string city
                {
                    get
                    {
                        return this.cityField;
                    }
                    set
                    {
                        this.cityField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string street
                {
                    get
                    {
                        return this.streetField;
                    }
                    set
                    {
                        this.streetField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string building
                {
                    get
                    {
                        return this.buildingField;
                    }
                    set
                    {
                        this.buildingField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string corpus
                {
                    get
                    {
                        return this.corpusField;
                    }
                    set
                    {
                        this.corpusField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string flat
                {
                    get
                    {
                        return this.flatField;
                    }
                    set
                    {
                        this.flatField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "date")]
                public System.DateTime beginDate
                {
                    get
                    {
                        return this.beginDateField;
                    }
                    set
                    {
                        this.beginDateField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlIgnoreAttribute()]
                public bool beginDateSpecified
                {
                    get
                    {
                        return this.beginDateFieldSpecified;
                    }
                    set
                    {
                        this.beginDateFieldSpecified = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "date")]
                public System.DateTime endDate
                {
                    get
                    {
                        return this.endDateField;
                    }
                    set
                    {
                        this.endDateField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlIgnoreAttribute()]
                public bool endDateSpecified
                {
                    get
                    {
                        return this.endDateFieldSpecified;
                    }
                    set
                    {
                        this.endDateFieldSpecified = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public AddressStatus status
                {
                    get
                    {
                        return this.statusField;
                    }
                    set
                    {
                        this.statusField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public AddressInvalidity invalidity
                {
                    get
                    {
                        return this.invalidityField;
                    }
                    set
                    {
                        this.invalidityField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string arCode
                {
                    get
                    {
                        return this.arCodeField;
                    }
                    set
                    {
                        this.arCodeField = value;
                    }
                }
            }

            /// <remarks/>
            [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
            [System.SerializableAttribute()]
            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://person.persistence.interactive.nat")]
            public partial class BirthPlace
            {

                private Country countryField;

                private District districtField;

                private Region regionField;

                private ForeignData foreignDataField;

                private string cityField;

                private string birthTeCodeARField;

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public Country country
                {
                    get
                    {
                        return this.countryField;
                    }
                    set
                    {
                        this.countryField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public District district
                {
                    get
                    {
                        return this.districtField;
                    }
                    set
                    {
                        this.districtField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public Region region
                {
                    get
                    {
                        return this.regionField;
                    }
                    set
                    {
                        this.regionField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public ForeignData foreignData
                {
                    get
                    {
                        return this.foreignDataField;
                    }
                    set
                    {
                        this.foreignDataField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string city
                {
                    get
                    {
                        return this.cityField;
                    }
                    set
                    {
                        this.cityField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string birthTeCodeAR
                {
                    get
                    {
                        return this.birthTeCodeARField;
                    }
                    set
                    {
                        this.birthTeCodeARField = value;
                    }
                }
            }

            /// <remarks/>
            [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
            [System.SerializableAttribute()]
            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://person.persistence.interactive.nat")]
            public partial class Certificate
            {

                private string numberField;

                private System.DateTime beginDateField;

                private bool beginDateFieldSpecified;

                private string issueOrganisationField;

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string number
                {
                    get
                    {
                        return this.numberField;
                    }
                    set
                    {
                        this.numberField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "date")]
                public System.DateTime beginDate
                {
                    get
                    {
                        return this.beginDateField;
                    }
                    set
                    {
                        this.beginDateField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlIgnoreAttribute()]
                public bool beginDateSpecified
                {
                    get
                    {
                        return this.beginDateFieldSpecified;
                    }
                    set
                    {
                        this.beginDateFieldSpecified = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string issueOrganisation
                {
                    get
                    {
                        return this.issueOrganisationField;
                    }
                    set
                    {
                        this.issueOrganisationField = value;
                    }
                }
            }

            /// <remarks/>
            [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
            [System.SerializableAttribute()]
            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dictionaries.persistence.interactive.nat")]
            public partial class ImprisoneStatus
            {

                private string codeField;

                private string nameRuField;

                private string nameKzField;

                private System.Nullable<System.DateTime> changeDateField;

                private bool changeDateFieldSpecified;

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string code
                {
                    get
                    {
                        return this.codeField;
                    }
                    set
                    {
                        this.codeField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string nameRu
                {
                    get
                    {
                        return this.nameRuField;
                    }
                    set
                    {
                        this.nameRuField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string nameKz
                {
                    get
                    {
                        return this.nameKzField;
                    }
                    set
                    {
                        this.nameKzField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
                public System.Nullable<System.DateTime> changeDate
                {
                    get
                    {
                        return this.changeDateField;
                    }
                    set
                    {
                        this.changeDateField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlIgnoreAttribute()]
                public bool changeDateSpecified
                {
                    get
                    {
                        return this.changeDateFieldSpecified;
                    }
                    set
                    {
                        this.changeDateFieldSpecified = value;
                    }
                }
            }

            /// <remarks/>
            [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
            [System.SerializableAttribute()]
            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://person.persistence.interactive.nat")]
            public partial class PersonImprisoneStatus
            {

                private ImprisoneStatus imprisonedStatusField;

                private System.DateTime imprisonedBeginDateField;

                private bool imprisonedBeginDateFieldSpecified;

                private System.DateTime imprisonedEndDateField;

                private bool imprisonedEndDateFieldSpecified;

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public ImprisoneStatus imprisonedStatus
                {
                    get
                    {
                        return this.imprisonedStatusField;
                    }
                    set
                    {
                        this.imprisonedStatusField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "date")]
                public System.DateTime imprisonedBeginDate
                {
                    get
                    {
                        return this.imprisonedBeginDateField;
                    }
                    set
                    {
                        this.imprisonedBeginDateField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlIgnoreAttribute()]
                public bool imprisonedBeginDateSpecified
                {
                    get
                    {
                        return this.imprisonedBeginDateFieldSpecified;
                    }
                    set
                    {
                        this.imprisonedBeginDateFieldSpecified = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "date")]
                public System.DateTime imprisonedEndDate
                {
                    get
                    {
                        return this.imprisonedEndDateField;
                    }
                    set
                    {
                        this.imprisonedEndDateField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlIgnoreAttribute()]
                public bool imprisonedEndDateSpecified
                {
                    get
                    {
                        return this.imprisonedEndDateFieldSpecified;
                    }
                    set
                    {
                        this.imprisonedEndDateFieldSpecified = value;
                    }
                }
            }

            /// <remarks/>
            [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
            [System.SerializableAttribute()]
            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dictionaries.persistence.interactive.nat")]
            public partial class PersonStatus
            {

                private string codeField;

                private string nameRuField;

                private string nameKzField;

                private System.Nullable<System.DateTime> changeDateField;

                private bool changeDateFieldSpecified;

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string code
                {
                    get
                    {
                        return this.codeField;
                    }
                    set
                    {
                        this.codeField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string nameRu
                {
                    get
                    {
                        return this.nameRuField;
                    }
                    set
                    {
                        this.nameRuField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string nameKz
                {
                    get
                    {
                        return this.nameKzField;
                    }
                    set
                    {
                        this.nameKzField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
                public System.Nullable<System.DateTime> changeDate
                {
                    get
                    {
                        return this.changeDateField;
                    }
                    set
                    {
                        this.changeDateField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlIgnoreAttribute()]
                public bool changeDateSpecified
                {
                    get
                    {
                        return this.changeDateFieldSpecified;
                    }
                    set
                    {
                        this.changeDateFieldSpecified = value;
                    }
                }
            }

            /// <remarks/>
            [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
            [System.SerializableAttribute()]
            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dictionaries.persistence.interactive.nat")]
            public partial class Nationality
            {

                private string codeField;

                private string nameRuField;

                private string nameKzField;

                private System.Nullable<System.DateTime> changeDateField;

                private bool changeDateFieldSpecified;

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string code
                {
                    get
                    {
                        return this.codeField;
                    }
                    set
                    {
                        this.codeField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string nameRu
                {
                    get
                    {
                        return this.nameRuField;
                    }
                    set
                    {
                        this.nameRuField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string nameKz
                {
                    get
                    {
                        return this.nameKzField;
                    }
                    set
                    {
                        this.nameKzField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
                public System.Nullable<System.DateTime> changeDate
                {
                    get
                    {
                        return this.changeDateField;
                    }
                    set
                    {
                        this.changeDateField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlIgnoreAttribute()]
                public bool changeDateSpecified
                {
                    get
                    {
                        return this.changeDateFieldSpecified;
                    }
                    set
                    {
                        this.changeDateFieldSpecified = value;
                    }
                }
            }

            /// <remarks/>
            [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
            [System.SerializableAttribute()]
            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dictionaries.persistence.interactive.nat")]
            public partial class Gender
            {

                private string codeField;

                private string nameRuField;

                private string nameKzField;

                private System.Nullable<System.DateTime> changeDateField;

                private bool changeDateFieldSpecified;

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string code
                {
                    get
                    {
                        return this.codeField;
                    }
                    set
                    {
                        this.codeField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string nameRu
                {
                    get
                    {
                        return this.nameRuField;
                    }
                    set
                    {
                        this.nameRuField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string nameKz
                {
                    get
                    {
                        return this.nameKzField;
                    }
                    set
                    {
                        this.nameKzField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
                public System.Nullable<System.DateTime> changeDate
                {
                    get
                    {
                        return this.changeDateField;
                    }
                    set
                    {
                        this.changeDateField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlIgnoreAttribute()]
                public bool changeDateSpecified
                {
                    get
                    {
                        return this.changeDateFieldSpecified;
                    }
                    set
                    {
                        this.changeDateFieldSpecified = value;
                    }
                }
            }

            /// <remarks/>
            [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
            [System.SerializableAttribute()]
            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://person.persistence.interactive.nat")]
            public partial class Person
            {

                private long idField;

                private bool idFieldSpecified;

                private string iinField;

                private string surnameField;

                private string nameField;

                private string patronymicField;

                private string engFirstNameField;

                private string engSurnameField;

                private System.DateTime birthDateField;

                private System.DateTime deathDateField;

                private bool deathDateFieldSpecified;

                private Gender genderField;

                private Nationality nationalityField;

                private Country citizenshipField;

                private PersonStatus lifeStatusField;

                private PersonImprisoneStatus imprisonedStatusField;

                private Certificate birthCertificateField;

                private Certificate deathCertificateField;

                private BirthPlace birthPlaceField;

                private RegAddress regAddressField;

                private PersonCapableStatus personCapableStatusField;

                private MissingStatus missingStatusField;

                private DisappearStatus disappearStatusField;

                private PersonExcludeStatus excludeStatusField;

                private personRepatriationStatus repatriationStatusField;

                private System.DateTime citizenshipBeginDateField;

                private System.DateTime citizenshipEndDateField;

                private Document[] documentsField;

                private Address[] addressesField;

                private bool removedField;

                private bool removedFieldSpecified;

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public long id
                {
                    get
                    {
                        return this.idField;
                    }
                    set
                    {
                        this.idField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlIgnoreAttribute()]
                public bool idSpecified
                {
                    get
                    {
                        return this.idFieldSpecified;
                    }
                    set
                    {
                        this.idFieldSpecified = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string iin
                {
                    get
                    {
                        return this.iinField;
                    }
                    set
                    {
                        this.iinField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string surname
                {
                    get
                    {
                        return this.surnameField;
                    }
                    set
                    {
                        this.surnameField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string name
                {
                    get
                    {
                        return this.nameField;
                    }
                    set
                    {
                        this.nameField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string patronymic
                {
                    get
                    {
                        return this.patronymicField;
                    }
                    set
                    {
                        this.patronymicField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string engFirstName
                {
                    get
                    {
                        return this.engFirstNameField;
                    }
                    set
                    {
                        this.engFirstNameField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string engSurname
                {
                    get
                    {
                        return this.engSurnameField;
                    }
                    set
                    {
                        this.engSurnameField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "date")]
                public System.DateTime birthDate
                {
                    get
                    {
                        return this.birthDateField;
                    }
                    set
                    {
                        this.birthDateField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "date")]
                public System.DateTime deathDate
                {
                    get
                    {
                        return this.deathDateField;
                    }
                    set
                    {
                        this.deathDateField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlIgnoreAttribute()]
                public bool deathDateSpecified
                {
                    get
                    {
                        return this.deathDateFieldSpecified;
                    }
                    set
                    {
                        this.deathDateFieldSpecified = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public Gender gender
                {
                    get
                    {
                        return this.genderField;
                    }
                    set
                    {
                        this.genderField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public Nationality nationality
                {
                    get
                    {
                        return this.nationalityField;
                    }
                    set
                    {
                        this.nationalityField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public Country citizenship
                {
                    get
                    {
                        return this.citizenshipField;
                    }
                    set
                    {
                        this.citizenshipField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public PersonStatus lifeStatus
                {
                    get
                    {
                        return this.lifeStatusField;
                    }
                    set
                    {
                        this.lifeStatusField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public PersonImprisoneStatus imprisonedStatus
                {
                    get
                    {
                        return this.imprisonedStatusField;
                    }
                    set
                    {
                        this.imprisonedStatusField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public Certificate birthCertificate
                {
                    get
                    {
                        return this.birthCertificateField;
                    }
                    set
                    {
                        this.birthCertificateField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public Certificate deathCertificate
                {
                    get
                    {
                        return this.deathCertificateField;
                    }
                    set
                    {
                        this.deathCertificateField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public BirthPlace birthPlace
                {
                    get
                    {
                        return this.birthPlaceField;
                    }
                    set
                    {
                        this.birthPlaceField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public RegAddress regAddress
                {
                    get
                    {
                        return this.regAddressField;
                    }
                    set
                    {
                        this.regAddressField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public PersonCapableStatus personCapableStatus
                {
                    get
                    {
                        return this.personCapableStatusField;
                    }
                    set
                    {
                        this.personCapableStatusField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public MissingStatus missingStatus
                {
                    get
                    {
                        return this.missingStatusField;
                    }
                    set
                    {
                        this.missingStatusField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public DisappearStatus disappearStatus
                {
                    get
                    {
                        return this.disappearStatusField;
                    }
                    set
                    {
                        this.disappearStatusField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public PersonExcludeStatus excludeStatus
                {
                    get
                    {
                        return this.excludeStatusField;
                    }
                    set
                    {
                        this.excludeStatusField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public personRepatriationStatus repatriationStatus
                {
                    get
                    {
                        return this.repatriationStatusField;
                    }
                    set
                    {
                        this.repatriationStatusField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "date")]
                public System.DateTime citizenshipBeginDate
                {
                    get
                    {
                        return this.citizenshipBeginDateField;
                    }
                    set
                    {
                        this.citizenshipBeginDateField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "date")]
                public System.DateTime citizenshipEndDate
                {
                    get
                    {
                        return this.citizenshipEndDateField;
                    }
                    set
                    {
                        this.citizenshipEndDateField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                [System.Xml.Serialization.XmlArrayItemAttribute("document", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
                public Document[] documents
                {
                    get
                    {
                        return this.documentsField;
                    }
                    set
                    {
                        this.documentsField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                [System.Xml.Serialization.XmlArrayItemAttribute("address", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
                public Address[] addresses
                {
                    get
                    {
                        return this.addressesField;
                    }
                    set
                    {
                        this.addressesField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public bool removed
                {
                    get
                    {
                        return this.removedField;
                    }
                    set
                    {
                        this.removedField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlIgnoreAttribute()]
                public bool removedSpecified
                {
                    get
                    {
                        return this.removedFieldSpecified;
                    }
                    set
                    {
                        this.removedFieldSpecified = value;
                    }
                }
            }

            /// <remarks/>
            [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
            [System.SerializableAttribute()]
            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://dictionaries.persistence.interactive.nat")]
            public partial class MessageResult
            {

                private string codeField;

                private string nameRuField;

                private string nameKzField;

                private System.Nullable<System.DateTime> changeDateField;

                private bool changeDateFieldSpecified;

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string code
                {
                    get
                    {
                        return this.codeField;
                    }
                    set
                    {
                        this.codeField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string nameRu
                {
                    get
                    {
                        return this.nameRuField;
                    }
                    set
                    {
                        this.nameRuField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string nameKz
                {
                    get
                    {
                        return this.nameKzField;
                    }
                    set
                    {
                        this.nameKzField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
                public System.Nullable<System.DateTime> changeDate
                {
                    get
                    {
                        return this.changeDateField;
                    }
                    set
                    {
                        this.changeDateField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlIgnoreAttribute()]
                public bool changeDateSpecified
                {
                    get
                    {
                        return this.changeDateFieldSpecified;
                    }
                    set
                    {
                        this.changeDateFieldSpecified = value;
                    }
                }
            }

            /// <remarks/>
            [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
            [System.SerializableAttribute()]
            [System.Diagnostics.DebuggerStepThroughAttribute()]
            [System.ComponentModel.DesignerCategoryAttribute("code")]
            [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://actualization.persistence.interactive.nat")]
            [System.Xml.Serialization.XmlRootAttribute("notice", Namespace = "", IsNullable = false)]
            public partial class UNoticeSync
            {

                private string messageIdField;

                private System.DateTime messageDateField;

                private string requestIdField;

                private Participant senderField;

                private Participant receiverField;

                private MessageResult messageResultField;

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string messageId
                {
                    get
                    {
                        return this.messageIdField;
                    }
                    set
                    {
                        this.messageIdField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public System.DateTime messageDate
                {
                    get
                    {
                        return this.messageDateField;
                    }
                    set
                    {
                        this.messageDateField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public string requestId
                {
                    get
                    {
                        return this.requestIdField;
                    }
                    set
                    {
                        this.requestIdField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public Participant sender
                {
                    get
                    {
                        return this.senderField;
                    }
                    set
                    {
                        this.senderField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public Participant receiver
                {
                    get
                    {
                        return this.receiverField;
                    }
                    set
                    {
                        this.receiverField = value;
                    }
                }

                /// <remarks/>
                [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
                public MessageResult messageResult
                {
                    get
                    {
                        return this.messageResultField;
                    }
                    set
                    {
                        this.messageResultField = value;
                    }
                }
            }

    }
    }