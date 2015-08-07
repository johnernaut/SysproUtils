using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SysproUtils
{
    public class ResultParser
    {
        public ResultParser()
        {
        }

        public List<string> Parse(string result)
        {
            var errs = new List<string>();

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(result);

            XmlNodeList xnList = doc.SelectNodes("/postapinvoice/Item/invoice");

            foreach (XmlNode item in xnList)
            {
                errs.Add(item["ErrorDescription"].InnerText);
            }

            xnList = doc.SelectNodes("/postapinvoice/Item/LedgerDistribution/ledgercode");

            foreach (XmlNode item in xnList)
            {
                errs.Add(item["ErrorDescription"].InnerText);
            }

            return errs;
        }
    }
}
