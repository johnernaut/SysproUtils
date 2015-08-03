namespace SysproUtils.APSTIN
{
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.IO;
    using System.Text;
    using System.Collections.Generic;


    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum ApplyIfEntireDocumentValid
    {

        /// <remarks/>
        Y,

        /// <remarks/>
        N,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum IgnoreWarnings
    {

        /// <remarks/>
        N,

        /// <remarks/>
        Y,

        /// <remarks/>
        W,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum LedgerDistributionCurrency
    {

        /// <remarks/>
        L,

        /// <remarks/>
        F,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class Parameters
    {

        private PostingPeriod postingPeriodField;

        private IgnoreWarnings ignoreWarningsField;

        private ApplyIfEntireDocumentValid applyIfEntireDocumentValidField;

        private ValidateOnly validateOnlyField;

        private PostZeroAdjustments postZeroAdjustmentsField;

        private string defaultDiscountDateField;

        private string defaultDueDateField;

        private LedgerDistributionCurrency ledgerDistributionCurrencyField;

        private AutomaticTaxCalculation automaticTaxCalculationField;

        private string permissibleTaxVarianceField;

        private string apArContraTrxField;

        private ParametersIgnoreAnalysis ignoreAnalysisField;

        private static System.Xml.Serialization.XmlSerializer serializer;

        public Parameters()
        {
            this.postingPeriodField = PostingPeriod.C;
            this.ignoreWarningsField = IgnoreWarnings.N;
            this.applyIfEntireDocumentValidField = ApplyIfEntireDocumentValid.Y;
            this.validateOnlyField = ValidateOnly.N;
            this.postZeroAdjustmentsField = PostZeroAdjustments.N;
            this.ledgerDistributionCurrencyField = LedgerDistributionCurrency.L;
            this.automaticTaxCalculationField = AutomaticTaxCalculation.N;
            this.ignoreAnalysisField = ParametersIgnoreAnalysis.Y;
        }

        public PostingPeriod PostingPeriod
        {
            get
            {
                return this.postingPeriodField;
            }
            set
            {
                this.postingPeriodField = value;
            }
        }

        public IgnoreWarnings IgnoreWarnings
        {
            get
            {
                return this.ignoreWarningsField;
            }
            set
            {
                this.ignoreWarningsField = value;
            }
        }

        public ApplyIfEntireDocumentValid ApplyIfEntireDocumentValid
        {
            get
            {
                return this.applyIfEntireDocumentValidField;
            }
            set
            {
                this.applyIfEntireDocumentValidField = value;
            }
        }

        public ValidateOnly ValidateOnly
        {
            get
            {
                return this.validateOnlyField;
            }
            set
            {
                this.validateOnlyField = value;
            }
        }

        public PostZeroAdjustments PostZeroAdjustments
        {
            get
            {
                return this.postZeroAdjustmentsField;
            }
            set
            {
                this.postZeroAdjustmentsField = value;
            }
        }

        public string DefaultDiscountDate
        {
            get
            {
                return this.defaultDiscountDateField;
            }
            set
            {
                this.defaultDiscountDateField = value;
            }
        }

        public string DefaultDueDate
        {
            get
            {
                return this.defaultDueDateField;
            }
            set
            {
                this.defaultDueDateField = value;
            }
        }

        public LedgerDistributionCurrency LedgerDistributionCurrency
        {
            get
            {
                return this.ledgerDistributionCurrencyField;
            }
            set
            {
                this.ledgerDistributionCurrencyField = value;
            }
        }

        public AutomaticTaxCalculation AutomaticTaxCalculation
        {
            get
            {
                return this.automaticTaxCalculationField;
            }
            set
            {
                this.automaticTaxCalculationField = value;
            }
        }

        public string PermissibleTaxVariance
        {
            get
            {
                return this.permissibleTaxVarianceField;
            }
            set
            {
                this.permissibleTaxVarianceField = value;
            }
        }

        public string ApArContraTrx
        {
            get
            {
                return this.apArContraTrxField;
            }
            set
            {
                this.apArContraTrxField = value;
            }
        }

        [System.ComponentModel.DefaultValueAttribute(ParametersIgnoreAnalysis.Y)]
        public ParametersIgnoreAnalysis IgnoreAnalysis
        {
            get
            {
                return this.ignoreAnalysisField;
            }
            set
            {
                this.ignoreAnalysisField = value;
            }
        }

        private static System.Xml.Serialization.XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new System.Xml.Serialization.XmlSerializer(typeof(Parameters));
                }
                return serializer;
            }
        }

        #region Serialize/Deserialize
        /// <summary>
        /// Serializes current Parameters object into an XML document
        /// </summary>
        /// <returns>string XML value</returns>
        public virtual string Serialize()
        {
            System.IO.StreamReader streamReader = null;
            System.IO.MemoryStream memoryStream = null;
            try
            {
                memoryStream = new System.IO.MemoryStream();
                Serializer.Serialize(memoryStream, this);
                memoryStream.Seek(0, System.IO.SeekOrigin.Begin);
                streamReader = new System.IO.StreamReader(memoryStream);
                return streamReader.ReadToEnd();
            }
            finally
            {
                if ((streamReader != null))
                {
                    streamReader.Dispose();
                }
                if ((memoryStream != null))
                {
                    memoryStream.Dispose();
                }
            }
        }

        /// <summary>
        /// Deserializes workflow markup into an Parameters object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output Parameters object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out Parameters obj, out System.Exception exception)
        {
            exception = null;
            obj = default(Parameters);
            try
            {
                obj = Deserialize(xml);
                return true;
            }
            catch (System.Exception ex)
            {
                exception = ex;
                return false;
            }
        }

        public static bool Deserialize(string xml, out Parameters obj)
        {
            System.Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }

        public static Parameters Deserialize(string xml)
        {
            System.IO.StringReader stringReader = null;
            try
            {
                stringReader = new System.IO.StringReader(xml);
                return ((Parameters)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
            }
            finally
            {
                if ((stringReader != null))
                {
                    stringReader.Dispose();
                }
            }
        }

        /// <summary>
        /// Serializes current Parameters object into file
        /// </summary>
        /// <param name="fileName">full path of outupt xml file</param>
        /// <param name="exception">output Exception value if failed</param>
        /// <returns>true if can serialize and save into file; otherwise, false</returns>
        public virtual bool SaveToFile(string fileName, out System.Exception exception)
        {
            exception = null;
            try
            {
                SaveToFile(fileName);
                return true;
            }
            catch (System.Exception e)
            {
                exception = e;
                return false;
            }
        }

        public virtual void SaveToFile(string fileName)
        {
            System.IO.StreamWriter streamWriter = null;
            try
            {
                string xmlString = Serialize();
                System.IO.FileInfo xmlFile = new System.IO.FileInfo(fileName);
                streamWriter = xmlFile.CreateText();
                streamWriter.WriteLine(xmlString);
                streamWriter.Close();
            }
            finally
            {
                if ((streamWriter != null))
                {
                    streamWriter.Dispose();
                }
            }
        }

        /// <summary>
        /// Deserializes xml markup from file into an Parameters object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output Parameters object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out Parameters obj, out System.Exception exception)
        {
            exception = null;
            obj = default(Parameters);
            try
            {
                obj = LoadFromFile(fileName);
                return true;
            }
            catch (System.Exception ex)
            {
                exception = ex;
                return false;
            }
        }

        public static bool LoadFromFile(string fileName, out Parameters obj)
        {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }

        public static Parameters LoadFromFile(string fileName)
        {
            System.IO.FileStream file = null;
            System.IO.StreamReader sr = null;
            try
            {
                file = new System.IO.FileStream(fileName, FileMode.Open, FileAccess.Read);
                sr = new System.IO.StreamReader(file);
                string xmlString = sr.ReadToEnd();
                sr.Close();
                file.Close();
                return Deserialize(xmlString);
            }
            finally
            {
                if ((file != null))
                {
                    file.Dispose();
                }
                if ((sr != null))
                {
                    sr.Dispose();
                }
            }
        }
        #endregion
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum PostingPeriod
    {

        /// <remarks/>
        C,

        /// <remarks/>
        P,

        /// <remarks/>
        B,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum ValidateOnly
    {

        /// <remarks/>
        N,

        /// <remarks/>
        Y,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum PostZeroAdjustments
    {

        /// <remarks/>
        N,

        /// <remarks/>
        Y,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum AutomaticTaxCalculation
    {

        /// <remarks/>
        N,

        /// <remarks/>
        Y,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public enum ParametersIgnoreAnalysis
    {

        /// <remarks/>
        Y,

        /// <remarks/>
        N,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class PostApInvoice
    {

        private Parameters parametersField;

        private static System.Xml.Serialization.XmlSerializer serializer;

        public PostApInvoice()
        {
            this.parametersField = new Parameters();
        }

        public Parameters Parameters
        {
            get
            {
                return this.parametersField;
            }
            set
            {
                this.parametersField = value;
            }
        }

        private static System.Xml.Serialization.XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new System.Xml.Serialization.XmlSerializer(typeof(PostApInvoice));
                }
                return serializer;
            }
        }

        #region Serialize/Deserialize
        /// <summary>
        /// Serializes current PostApInvoice object into an XML document
        /// </summary>
        /// <returns>string XML value</returns>
        public virtual string Serialize()
        {
            System.IO.StreamReader streamReader = null;
            System.IO.MemoryStream memoryStream = null;
            try
            {
                memoryStream = new System.IO.MemoryStream();
                Serializer.Serialize(memoryStream, this);
                memoryStream.Seek(0, System.IO.SeekOrigin.Begin);
                streamReader = new System.IO.StreamReader(memoryStream);
                return streamReader.ReadToEnd();
            }
            finally
            {
                if ((streamReader != null))
                {
                    streamReader.Dispose();
                }
                if ((memoryStream != null))
                {
                    memoryStream.Dispose();
                }
            }
        }

        /// <summary>
        /// Deserializes workflow markup into an PostApInvoice object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output PostApInvoice object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out PostApInvoice obj, out System.Exception exception)
        {
            exception = null;
            obj = default(PostApInvoice);
            try
            {
                obj = Deserialize(xml);
                return true;
            }
            catch (System.Exception ex)
            {
                exception = ex;
                return false;
            }
        }

        public static bool Deserialize(string xml, out PostApInvoice obj)
        {
            System.Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }

        public static PostApInvoice Deserialize(string xml)
        {
            System.IO.StringReader stringReader = null;
            try
            {
                stringReader = new System.IO.StringReader(xml);
                return ((PostApInvoice)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
            }
            finally
            {
                if ((stringReader != null))
                {
                    stringReader.Dispose();
                }
            }
        }

        /// <summary>
        /// Serializes current PostApInvoice object into file
        /// </summary>
        /// <param name="fileName">full path of outupt xml file</param>
        /// <param name="exception">output Exception value if failed</param>
        /// <returns>true if can serialize and save into file; otherwise, false</returns>
        public virtual bool SaveToFile(string fileName, out System.Exception exception)
        {
            exception = null;
            try
            {
                SaveToFile(fileName);
                return true;
            }
            catch (System.Exception e)
            {
                exception = e;
                return false;
            }
        }

        public virtual void SaveToFile(string fileName)
        {
            System.IO.StreamWriter streamWriter = null;
            try
            {
                string xmlString = Serialize();
                System.IO.FileInfo xmlFile = new System.IO.FileInfo(fileName);
                streamWriter = xmlFile.CreateText();
                streamWriter.WriteLine(xmlString);
                streamWriter.Close();
            }
            finally
            {
                if ((streamWriter != null))
                {
                    streamWriter.Dispose();
                }
            }
        }

        /// <summary>
        /// Deserializes xml markup from file into an PostApInvoice object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output PostApInvoice object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out PostApInvoice obj, out System.Exception exception)
        {
            exception = null;
            obj = default(PostApInvoice);
            try
            {
                obj = LoadFromFile(fileName);
                return true;
            }
            catch (System.Exception ex)
            {
                exception = ex;
                return false;
            }
        }

        public static bool LoadFromFile(string fileName, out PostApInvoice obj)
        {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }

        public static PostApInvoice LoadFromFile(string fileName)
        {
            System.IO.FileStream file = null;
            System.IO.StreamReader sr = null;
            try
            {
                file = new System.IO.FileStream(fileName, FileMode.Open, FileAccess.Read);
                sr = new System.IO.StreamReader(file);
                string xmlString = sr.ReadToEnd();
                sr.Close();
                file.Close();
                return Deserialize(xmlString);
            }
            finally
            {
                if ((file != null))
                {
                    file.Dispose();
                }
                if ((sr != null))
                {
                    sr.Dispose();
                }
            }
        }
        #endregion
    }
}
