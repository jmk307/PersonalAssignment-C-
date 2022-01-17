using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace 강지민_202011398_개인과제
{
    public class dt3ColumnManager
    {


        public DataTable dt3;


        public dt3ColumnManager()
        {
            
            this.dt3 = new DataTable();
            dt3.Columns.Add("id", typeof(string));
            dt3.Columns.Add("astrtCont", typeof(string));
            dt3.Columns.Add("name", typeof(string));
            dt3.Columns.Add("engName", typeof(string));
            dt3.Columns.Add("code", typeof(string));
            dt3.Columns.Add("address", typeof(string));
            dt3.Columns.Add("country", typeof(string));
            dt3.Columns.Add("businessRegistrationNumber", typeof(string));
            dt3.Columns.Add("corporationNumber", typeof(string));
            dt3.Columns.Add("inventionTitle", typeof(string));
            dt3.Columns.Add("inventionTitleEng", typeof(string));
            dt3.Columns.Add("applicationNumber", typeof(string));
            dt3.Columns.Add("applicationDate", typeof(string));
            dt3.Columns.Add("openNumber", typeof(string));
            dt3.Columns.Add("openDate", typeof(string));
            dt3.Columns.Add("publicationNumber", typeof(string));
            dt3.Columns.Add("publicationDate", typeof(string));
            dt3.Columns.Add("registerNumber", typeof(string));
            dt3.Columns.Add("registerDate", typeof(string));
            dt3.Columns.Add("originalApplicationKind", typeof(string));
            dt3.Columns.Add("originalApplicationNumber", typeof(string));
            dt3.Columns.Add("originalApplicationDate", typeof(string));
            dt3.Columns.Add("finalDisposal", typeof(string));
            dt3.Columns.Add("registerStatus", typeof(string));
            dt3.Columns.Add("examinerName", typeof(string));
            dt3.Columns.Add("originalExaminationRequestFlag", typeof(string));
            dt3.Columns.Add("originalExaminationRequestDate", typeof(string));
            dt3.Columns.Add("claimCount", typeof(string));
            dt3.Columns.Add("applicationFlag", typeof(string));
            dt3.Columns.Add("translationSubmitDate", typeof(string));
            dt3.Columns.Add("chk_pat", typeof(string));
            dt3.Columns.Add("ipcNumber", typeof(string));
            dt3.Columns.Add("ipcDate", typeof(string));

        }
    }
}
