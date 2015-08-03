namespace SysproUtils.APSTINDOC
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
    public enum DiscountBasis
    {

        /// <remarks/>
        T,

        /// <remarks/>
        P,

        /// <remarks/>
        V,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class Item
    {

        private string eSignatureField;

        private string supplierField;

        private TransactionCode transactionCodeField;

        private string branchField;

        private string invoiceField;

        private string transactionValueField;

        private string freightChargeField;

        private string miscellaneousChargeField;

        private string notationField;

        private string transactionReferenceField;

        private string journalNotationField;

        private DiscountBasis discountBasisField;

        private string discountableValueField;

        private string discountPercentageValueField;

        private string discountAdjustmentField;

        private string invoiceDateField;

        private string dueDateField;

        private string discountDateField;

        private string exchRateAtEntryField;

        private string fixedExchRateField;

        private TaxBasis taxBasisField;

        private string calculateQstOnTaxField;

        private TaxCode taxCodeField;

        private string taxValueField;

        private SecondTaxCode secondTaxCodeField;

        private string secondTaxValueField;

        private EcAcquisition ecAcquisitionField;

        private string nationalityField;

        private ReestablishInvoice reestablishInvoiceField;

        private string analysisEntryField;

        private ItemAnalysisLineEntry analysisLineEntryField;

        private List<GrnDetails> grnDetailsField;

        private List<LedgerDistribution> ledgerDistributionField;

        private static System.Xml.Serialization.XmlSerializer serializer;

        public Item()
        {
            this.ledgerDistributionField = new List<LedgerDistribution>();
            this.grnDetailsField = new List<GrnDetails>();
            this.analysisLineEntryField = new ItemAnalysisLineEntry();
            this.transactionCodeField = TransactionCode.I;
            this.discountBasisField = DiscountBasis.T;
            this.taxBasisField = TaxBasis.E;
            this.ecAcquisitionField = EcAcquisition.Y;
            this.reestablishInvoiceField = ReestablishInvoice.N;
        }

        public string eSignature
        {
            get
            {
                return this.eSignatureField;
            }
            set
            {
                this.eSignatureField = value;
            }
        }

        public string Supplier
        {
            get
            {
                return this.supplierField;
            }
            set
            {
                this.supplierField = value;
            }
        }

        public TransactionCode TransactionCode
        {
            get
            {
                return this.transactionCodeField;
            }
            set
            {
                this.transactionCodeField = value;
            }
        }

        public string Branch
        {
            get
            {
                return this.branchField;
            }
            set
            {
                this.branchField = value;
            }
        }

        public string Invoice
        {
            get
            {
                return this.invoiceField;
            }
            set
            {
                this.invoiceField = value;
            }
        }

        public string TransactionValue
        {
            get
            {
                return this.transactionValueField;
            }
            set
            {
                this.transactionValueField = value;
            }
        }

        public string FreightCharge
        {
            get
            {
                return this.freightChargeField;
            }
            set
            {
                this.freightChargeField = value;
            }
        }

        public string MiscellaneousCharge
        {
            get
            {
                return this.miscellaneousChargeField;
            }
            set
            {
                this.miscellaneousChargeField = value;
            }
        }

        public string Notation
        {
            get
            {
                return this.notationField;
            }
            set
            {
                this.notationField = value;
            }
        }

        public string TransactionReference
        {
            get
            {
                return this.transactionReferenceField;
            }
            set
            {
                this.transactionReferenceField = value;
            }
        }

        public string JournalNotation
        {
            get
            {
                return this.journalNotationField;
            }
            set
            {
                this.journalNotationField = value;
            }
        }

        public DiscountBasis DiscountBasis
        {
            get
            {
                return this.discountBasisField;
            }
            set
            {
                this.discountBasisField = value;
            }
        }

        public string DiscountableValue
        {
            get
            {
                return this.discountableValueField;
            }
            set
            {
                this.discountableValueField = value;
            }
        }

        public string DiscountPercentageValue
        {
            get
            {
                return this.discountPercentageValueField;
            }
            set
            {
                this.discountPercentageValueField = value;
            }
        }

        public string DiscountAdjustment
        {
            get
            {
                return this.discountAdjustmentField;
            }
            set
            {
                this.discountAdjustmentField = value;
            }
        }

        public string InvoiceDate
        {
            get
            {
                return this.invoiceDateField;
            }
            set
            {
                this.invoiceDateField = value;
            }
        }

        public string DueDate
        {
            get
            {
                return this.dueDateField;
            }
            set
            {
                this.dueDateField = value;
            }
        }

        public string DiscountDate
        {
            get
            {
                return this.discountDateField;
            }
            set
            {
                this.discountDateField = value;
            }
        }

        public string ExchRateAtEntry
        {
            get
            {
                return this.exchRateAtEntryField;
            }
            set
            {
                this.exchRateAtEntryField = value;
            }
        }

        public string FixedExchRate
        {
            get
            {
                return this.fixedExchRateField;
            }
            set
            {
                this.fixedExchRateField = value;
            }
        }

        public TaxBasis TaxBasis
        {
            get
            {
                return this.taxBasisField;
            }
            set
            {
                this.taxBasisField = value;
            }
        }

        public string CalculateQstOnTax
        {
            get
            {
                return this.calculateQstOnTaxField;
            }
            set
            {
                this.calculateQstOnTaxField = value;
            }
        }

        public TaxCode TaxCode
        {
            get
            {
                return this.taxCodeField;
            }
            set
            {
                this.taxCodeField = value;
            }
        }

        public string TaxValue
        {
            get
            {
                return this.taxValueField;
            }
            set
            {
                this.taxValueField = value;
            }
        }

        public SecondTaxCode SecondTaxCode
        {
            get
            {
                return this.secondTaxCodeField;
            }
            set
            {
                this.secondTaxCodeField = value;
            }
        }

        public string SecondTaxValue
        {
            get
            {
                return this.secondTaxValueField;
            }
            set
            {
                this.secondTaxValueField = value;
            }
        }

        public EcAcquisition EcAcquisition
        {
            get
            {
                return this.ecAcquisitionField;
            }
            set
            {
                this.ecAcquisitionField = value;
            }
        }

        public string Nationality
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

        public ReestablishInvoice ReestablishInvoice
        {
            get
            {
                return this.reestablishInvoiceField;
            }
            set
            {
                this.reestablishInvoiceField = value;
            }
        }

        public string AnalysisEntry
        {
            get
            {
                return this.analysisEntryField;
            }
            set
            {
                this.analysisEntryField = value;
            }
        }

        public ItemAnalysisLineEntry AnalysisLineEntry
        {
            get
            {
                return this.analysisLineEntryField;
            }
            set
            {
                this.analysisLineEntryField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("GrnDetails")]
        public List<GrnDetails> GrnDetails
        {
            get
            {
                return this.grnDetailsField;
            }
            set
            {
                this.grnDetailsField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("LedgerDistribution")]
        public List<LedgerDistribution> LedgerDistribution
        {
            get
            {
                return this.ledgerDistributionField;
            }
            set
            {
                this.ledgerDistributionField = value;
            }
        }

        private static System.Xml.Serialization.XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new System.Xml.Serialization.XmlSerializer(typeof(Item));
                }
                return serializer;
            }
        }

        #region Serialize/Deserialize
        /// <summary>
        /// Serializes current Item object into an XML document
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
        /// Deserializes workflow markup into an Item object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output Item object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out Item obj, out System.Exception exception)
        {
            exception = null;
            obj = default(Item);
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

        public static bool Deserialize(string xml, out Item obj)
        {
            System.Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }

        public static Item Deserialize(string xml)
        {
            System.IO.StringReader stringReader = null;
            try
            {
                stringReader = new System.IO.StringReader(xml);
                return ((Item)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
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
        /// Serializes current Item object into file
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
        /// Deserializes xml markup from file into an Item object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output Item object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out Item obj, out System.Exception exception)
        {
            exception = null;
            obj = default(Item);
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

        public static bool LoadFromFile(string fileName, out Item obj)
        {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }

        public static Item LoadFromFile(string fileName)
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
    public enum TransactionCode
    {

        /// <remarks/>
        A,

        /// <remarks/>
        I,

        /// <remarks/>
        D,

        /// <remarks/>
        C,

        /// <remarks/>
        P,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum TaxBasis
    {

        /// <remarks/>
        E,

        /// <remarks/>
        I,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum TaxCode
    {

        /// <remarks/>
        A,

        /// <remarks/>
        B,

        /// <remarks/>
        C,

        /// <remarks/>
        D,

        /// <remarks/>
        E,

        /// <remarks/>
        F,

        /// <remarks/>
        G,

        /// <remarks/>
        H,

        /// <remarks/>
        I,

        /// <remarks/>
        J,

        /// <remarks/>
        K,

        /// <remarks/>
        L,

        /// <remarks/>
        M,

        /// <remarks/>
        N,

        /// <remarks/>
        O,

        /// <remarks/>
        P,

        /// <remarks/>
        Q,

        /// <remarks/>
        R,

        /// <remarks/>
        S,

        /// <remarks/>
        T,

        /// <remarks/>
        U,

        /// <remarks/>
        V,

        /// <remarks/>
        W,

        /// <remarks/>
        X,

        /// <remarks/>
        Y,

        /// <remarks/>
        Z,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum SecondTaxCode
    {

        /// <remarks/>
        A,

        /// <remarks/>
        B,

        /// <remarks/>
        C,

        /// <remarks/>
        D,

        /// <remarks/>
        E,

        /// <remarks/>
        F,

        /// <remarks/>
        GH,

        /// <remarks/>
        I,

        /// <remarks/>
        J,

        /// <remarks/>
        K,

        /// <remarks/>
        L,

        /// <remarks/>
        M,

        /// <remarks/>
        N,

        /// <remarks/>
        O,

        /// <remarks/>
        P,

        /// <remarks/>
        Q,

        /// <remarks/>
        R,

        /// <remarks/>
        S,

        /// <remarks/>
        T,

        /// <remarks/>
        U,

        /// <remarks/>
        V,

        /// <remarks/>
        W,

        /// <remarks/>
        X,

        /// <remarks/>
        Y,

        /// <remarks/>
        Z,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum EcAcquisition
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
    public enum ReestablishInvoice
    {

        /// <remarks/>
        N,

        /// <remarks/>
        Y,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ItemAnalysisLineEntry
    {

        private string analysisCode1Field;

        private string analysisCode2Field;

        private string analysisCode3Field;

        private string analysisCode4Field;

        private string analysisCode5Field;

        private string startDateField;

        private string endDateField;

        private string entryAmountField;

        private string commentField;

        private static System.Xml.Serialization.XmlSerializer serializer;

        public string AnalysisCode1
        {
            get
            {
                return this.analysisCode1Field;
            }
            set
            {
                this.analysisCode1Field = value;
            }
        }

        public string AnalysisCode2
        {
            get
            {
                return this.analysisCode2Field;
            }
            set
            {
                this.analysisCode2Field = value;
            }
        }

        public string AnalysisCode3
        {
            get
            {
                return this.analysisCode3Field;
            }
            set
            {
                this.analysisCode3Field = value;
            }
        }

        public string AnalysisCode4
        {
            get
            {
                return this.analysisCode4Field;
            }
            set
            {
                this.analysisCode4Field = value;
            }
        }

        public string AnalysisCode5
        {
            get
            {
                return this.analysisCode5Field;
            }
            set
            {
                this.analysisCode5Field = value;
            }
        }

        public string StartDate
        {
            get
            {
                return this.startDateField;
            }
            set
            {
                this.startDateField = value;
            }
        }

        public string EndDate
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

        public string EntryAmount
        {
            get
            {
                return this.entryAmountField;
            }
            set
            {
                this.entryAmountField = value;
            }
        }

        public string Comment
        {
            get
            {
                return this.commentField;
            }
            set
            {
                this.commentField = value;
            }
        }

        private static System.Xml.Serialization.XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new System.Xml.Serialization.XmlSerializer(typeof(ItemAnalysisLineEntry));
                }
                return serializer;
            }
        }

        #region Serialize/Deserialize
        /// <summary>
        /// Serializes current ItemAnalysisLineEntry object into an XML document
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
        /// Deserializes workflow markup into an ItemAnalysisLineEntry object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output ItemAnalysisLineEntry object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out ItemAnalysisLineEntry obj, out System.Exception exception)
        {
            exception = null;
            obj = default(ItemAnalysisLineEntry);
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

        public static bool Deserialize(string xml, out ItemAnalysisLineEntry obj)
        {
            System.Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }

        public static ItemAnalysisLineEntry Deserialize(string xml)
        {
            System.IO.StringReader stringReader = null;
            try
            {
                stringReader = new System.IO.StringReader(xml);
                return ((ItemAnalysisLineEntry)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
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
        /// Serializes current ItemAnalysisLineEntry object into file
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
        /// Deserializes xml markup from file into an ItemAnalysisLineEntry object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output ItemAnalysisLineEntry object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out ItemAnalysisLineEntry obj, out System.Exception exception)
        {
            exception = null;
            obj = default(ItemAnalysisLineEntry);
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

        public static bool LoadFromFile(string fileName, out ItemAnalysisLineEntry obj)
        {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }

        public static ItemAnalysisLineEntry LoadFromFile(string fileName)
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
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class GrnDetails
    {

        private string grnDetailKeyField;

        private GrnMatchType grnMatchTypeField;

        private string grnMatchValueField;

        private string grnPartialMatchQuantityField;

        private string grnPartialMatchValueField;

        private string grnSupplierField;

        private string grnGrnField;

        private string grnFlagField;

        private string grnJournalField;

        private string grnEntryField;

        private static System.Xml.Serialization.XmlSerializer serializer;

        public string GrnDetailKey
        {
            get
            {
                return this.grnDetailKeyField;
            }
            set
            {
                this.grnDetailKeyField = value;
            }
        }

        public GrnMatchType GrnMatchType
        {
            get
            {
                return this.grnMatchTypeField;
            }
            set
            {
                this.grnMatchTypeField = value;
            }
        }

        public string GrnMatchValue
        {
            get
            {
                return this.grnMatchValueField;
            }
            set
            {
                this.grnMatchValueField = value;
            }
        }

        public string GrnPartialMatchQuantity
        {
            get
            {
                return this.grnPartialMatchQuantityField;
            }
            set
            {
                this.grnPartialMatchQuantityField = value;
            }
        }

        public string GrnPartialMatchValue
        {
            get
            {
                return this.grnPartialMatchValueField;
            }
            set
            {
                this.grnPartialMatchValueField = value;
            }
        }

        public string GrnSupplier
        {
            get
            {
                return this.grnSupplierField;
            }
            set
            {
                this.grnSupplierField = value;
            }
        }

        public string GrnGrn
        {
            get
            {
                return this.grnGrnField;
            }
            set
            {
                this.grnGrnField = value;
            }
        }

        public string GrnFlag
        {
            get
            {
                return this.grnFlagField;
            }
            set
            {
                this.grnFlagField = value;
            }
        }

        public string GrnJournal
        {
            get
            {
                return this.grnJournalField;
            }
            set
            {
                this.grnJournalField = value;
            }
        }

        public string GrnEntry
        {
            get
            {
                return this.grnEntryField;
            }
            set
            {
                this.grnEntryField = value;
            }
        }

        private static System.Xml.Serialization.XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new System.Xml.Serialization.XmlSerializer(typeof(GrnDetails));
                }
                return serializer;
            }
        }

        #region Serialize/Deserialize
        /// <summary>
        /// Serializes current GrnDetails object into an XML document
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
        /// Deserializes workflow markup into an GrnDetails object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output GrnDetails object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out GrnDetails obj, out System.Exception exception)
        {
            exception = null;
            obj = default(GrnDetails);
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

        public static bool Deserialize(string xml, out GrnDetails obj)
        {
            System.Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }

        public static GrnDetails Deserialize(string xml)
        {
            System.IO.StringReader stringReader = null;
            try
            {
                stringReader = new System.IO.StringReader(xml);
                return ((GrnDetails)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
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
        /// Serializes current GrnDetails object into file
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
        /// Deserializes xml markup from file into an GrnDetails object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output GrnDetails object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out GrnDetails obj, out System.Exception exception)
        {
            exception = null;
            obj = default(GrnDetails);
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

        public static bool LoadFromFile(string fileName, out GrnDetails obj)
        {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }

        public static GrnDetails LoadFromFile(string fileName)
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
    public enum GrnMatchType
    {

        /// <remarks/>
        P,

        /// <remarks/>
        U,

        /// <remarks/>
        O,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class LedgerDistribution
    {

        private string ledgerCodeField;

        private string passwordForLedgerCodeField;

        private LedgerTaxCode ledgerTaxCodeField;

        private LedgerSecondTaxCode ledgerSecondTaxCodeField;

        private string ledgerNotationField;

        private string ledgerValueField;

        private string analysisEntryField;

        private LedgerDistributionAnalysisLineEntry analysisLineEntryField;

        private static System.Xml.Serialization.XmlSerializer serializer;

        public LedgerDistribution()
        {
            this.analysisLineEntryField = new LedgerDistributionAnalysisLineEntry();
        }

        public string LedgerCode
        {
            get
            {
                return this.ledgerCodeField;
            }
            set
            {
                this.ledgerCodeField = value;
            }
        }

        public string PasswordForLedgerCode
        {
            get
            {
                return this.passwordForLedgerCodeField;
            }
            set
            {
                this.passwordForLedgerCodeField = value;
            }
        }

        public LedgerTaxCode LedgerTaxCode
        {
            get
            {
                return this.ledgerTaxCodeField;
            }
            set
            {
                this.ledgerTaxCodeField = value;
            }
        }

        public LedgerSecondTaxCode LedgerSecondTaxCode
        {
            get
            {
                return this.ledgerSecondTaxCodeField;
            }
            set
            {
                this.ledgerSecondTaxCodeField = value;
            }
        }

        public string LedgerNotation
        {
            get
            {
                return this.ledgerNotationField;
            }
            set
            {
                this.ledgerNotationField = value;
            }
        }

        public string LedgerValue
        {
            get
            {
                return this.ledgerValueField;
            }
            set
            {
                this.ledgerValueField = value;
            }
        }

        public string AnalysisEntry
        {
            get
            {
                return this.analysisEntryField;
            }
            set
            {
                this.analysisEntryField = value;
            }
        }

        public LedgerDistributionAnalysisLineEntry AnalysisLineEntry
        {
            get
            {
                return this.analysisLineEntryField;
            }
            set
            {
                this.analysisLineEntryField = value;
            }
        }

        private static System.Xml.Serialization.XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new System.Xml.Serialization.XmlSerializer(typeof(LedgerDistribution));
                }
                return serializer;
            }
        }

        #region Serialize/Deserialize
        /// <summary>
        /// Serializes current LedgerDistribution object into an XML document
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
        /// Deserializes workflow markup into an LedgerDistribution object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output LedgerDistribution object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out LedgerDistribution obj, out System.Exception exception)
        {
            exception = null;
            obj = default(LedgerDistribution);
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

        public static bool Deserialize(string xml, out LedgerDistribution obj)
        {
            System.Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }

        public static LedgerDistribution Deserialize(string xml)
        {
            System.IO.StringReader stringReader = null;
            try
            {
                stringReader = new System.IO.StringReader(xml);
                return ((LedgerDistribution)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
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
        /// Serializes current LedgerDistribution object into file
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
        /// Deserializes xml markup from file into an LedgerDistribution object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output LedgerDistribution object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out LedgerDistribution obj, out System.Exception exception)
        {
            exception = null;
            obj = default(LedgerDistribution);
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

        public static bool LoadFromFile(string fileName, out LedgerDistribution obj)
        {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }

        public static LedgerDistribution LoadFromFile(string fileName)
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
    public enum LedgerTaxCode
    {

        /// <remarks/>
        A,

        /// <remarks/>
        B,

        /// <remarks/>
        C,

        /// <remarks/>
        D,

        /// <remarks/>
        E,

        /// <remarks/>
        F,

        /// <remarks/>
        G,

        /// <remarks/>
        H,

        /// <remarks/>
        I,

        /// <remarks/>
        J,

        /// <remarks/>
        K,

        /// <remarks/>
        L,

        /// <remarks/>
        M,

        /// <remarks/>
        N,

        /// <remarks/>
        O,

        /// <remarks/>
        P,

        /// <remarks/>
        Q,

        /// <remarks/>
        R,

        /// <remarks/>
        S,

        /// <remarks/>
        T,

        /// <remarks/>
        U,

        /// <remarks/>
        V,

        /// <remarks/>
        W,

        /// <remarks/>
        X,

        /// <remarks/>
        Y,

        /// <remarks/>
        Z,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("")]
        Item,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public enum LedgerSecondTaxCode
    {

        /// <remarks/>
        A,

        /// <remarks/>
        B,

        /// <remarks/>
        C,

        /// <remarks/>
        D,

        /// <remarks/>
        E,

        /// <remarks/>
        F,

        /// <remarks/>
        G,

        /// <remarks/>
        H,

        /// <remarks/>
        I,

        /// <remarks/>
        J,

        /// <remarks/>
        KL,

        /// <remarks/>
        M,

        /// <remarks/>
        NO,

        /// <remarks/>
        P,

        /// <remarks/>
        Q,

        /// <remarks/>
        R,

        /// <remarks/>
        S,

        /// <remarks/>
        T,

        /// <remarks/>
        U,

        /// <remarks/>
        V,

        /// <remarks/>
        W,

        /// <remarks/>
        X,

        /// <remarks/>
        Y,

        /// <remarks/>
        Z,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("")]
        Item,
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class LedgerDistributionAnalysisLineEntry
    {

        private string analysisCode1Field;

        private string analysisCode2Field;

        private string analysisCode3Field;

        private string analysisCode4Field;

        private string analysisCode5Field;

        private string startDateField;

        private string endDateField;

        private string entryAmountField;

        private string commentField;

        private static System.Xml.Serialization.XmlSerializer serializer;

        public string AnalysisCode1
        {
            get
            {
                return this.analysisCode1Field;
            }
            set
            {
                this.analysisCode1Field = value;
            }
        }

        public string AnalysisCode2
        {
            get
            {
                return this.analysisCode2Field;
            }
            set
            {
                this.analysisCode2Field = value;
            }
        }

        public string AnalysisCode3
        {
            get
            {
                return this.analysisCode3Field;
            }
            set
            {
                this.analysisCode3Field = value;
            }
        }

        public string AnalysisCode4
        {
            get
            {
                return this.analysisCode4Field;
            }
            set
            {
                this.analysisCode4Field = value;
            }
        }

        public string AnalysisCode5
        {
            get
            {
                return this.analysisCode5Field;
            }
            set
            {
                this.analysisCode5Field = value;
            }
        }

        public string StartDate
        {
            get
            {
                return this.startDateField;
            }
            set
            {
                this.startDateField = value;
            }
        }

        public string EndDate
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

        public string EntryAmount
        {
            get
            {
                return this.entryAmountField;
            }
            set
            {
                this.entryAmountField = value;
            }
        }

        public string Comment
        {
            get
            {
                return this.commentField;
            }
            set
            {
                this.commentField = value;
            }
        }

        private static System.Xml.Serialization.XmlSerializer Serializer
        {
            get
            {
                if ((serializer == null))
                {
                    serializer = new System.Xml.Serialization.XmlSerializer(typeof(LedgerDistributionAnalysisLineEntry));
                }
                return serializer;
            }
        }

        #region Serialize/Deserialize
        /// <summary>
        /// Serializes current LedgerDistributionAnalysisLineEntry object into an XML document
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
        /// Deserializes workflow markup into an LedgerDistributionAnalysisLineEntry object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output LedgerDistributionAnalysisLineEntry object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out LedgerDistributionAnalysisLineEntry obj, out System.Exception exception)
        {
            exception = null;
            obj = default(LedgerDistributionAnalysisLineEntry);
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

        public static bool Deserialize(string xml, out LedgerDistributionAnalysisLineEntry obj)
        {
            System.Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }

        public static LedgerDistributionAnalysisLineEntry Deserialize(string xml)
        {
            System.IO.StringReader stringReader = null;
            try
            {
                stringReader = new System.IO.StringReader(xml);
                return ((LedgerDistributionAnalysisLineEntry)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
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
        /// Serializes current LedgerDistributionAnalysisLineEntry object into file
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
        /// Deserializes xml markup from file into an LedgerDistributionAnalysisLineEntry object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output LedgerDistributionAnalysisLineEntry object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out LedgerDistributionAnalysisLineEntry obj, out System.Exception exception)
        {
            exception = null;
            obj = default(LedgerDistributionAnalysisLineEntry);
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

        public static bool LoadFromFile(string fileName, out LedgerDistributionAnalysisLineEntry obj)
        {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }

        public static LedgerDistributionAnalysisLineEntry LoadFromFile(string fileName)
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
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class PostApInvoice
    {

        private List<Item> itemField;

        private static System.Xml.Serialization.XmlSerializer serializer;

        public PostApInvoice()
        {
            this.itemField = new List<Item>();
        }

        [System.Xml.Serialization.XmlElementAttribute("Item")]
        public List<Item> Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
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
