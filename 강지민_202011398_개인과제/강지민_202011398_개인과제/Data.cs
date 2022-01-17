using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace 강지민_202011398_개인과제
{
    public class Data
    {
        public string id;
        public string astrtCont;
        public string name;
        public string engName;
        public string code;
        public string address;
        public string country;
        public string businessRegistrationNumber;
        public string corporationNumber;
        public string inventionTitle;
        public string inventionTitleEng;
        public string applicationNumber;
        public string applicationDate;
        public string openNumber;
        public string openDate;
        public string publicationNumber;
        public string publicationDate;
        public string registerNumber;
        public string registerDate;
        public string originalApplicationKind;
        public string originalApplicationNumber;
        public string originalApplicationDate;
        public string finalDisposal;
        public string registerStatus;
        public string examinerName;
        public string originalExaminationRequestFlag;
        public string originalExaminationRequestDate;
        public string claimCount;
        public string applicationFlag;
        public string translationSubmitDate;
        public string chk_pat;
        public string ipcNumber;
        public string ipcDate;

        public Data(string id,
                    string astrtCont,
                    string name,
                    string engName,
                    string code,
                    string address,
                    string country,
                    string businessRegistrationNumber,
                    string corporationNumber,
                    string inventionTitle,
                    string inventionTitleEng,
                    string applicationNumber,
                    string applicationDate,
                    string openNumber,
                    string openDate,
                    string publicationNumber,
                    string publicationDate,
                    string registerNumber,
                    string registerDate,
                    string originalApplicationKind,
                    string originalApplicationNumber,
                    string originalApplicationDate,
                    string finalDisposal,
                    string registerStatus,
                    string examinerName,
                    string originalExaminationRequestFlag,
                    string originalExaminationRequestDate,
                    string claimCount,
                    string applicationFlag,
                    string translationSubmitDate,
                    string chk_pat,
                    string ipcNumber,
                    string ipcDate)
        {
            this.id = id;
            this.astrtCont = astrtCont;
            this.name = name;
            this.engName = engName;
            this.code = code;
            this.address = address;
            this.country = country;
            this.businessRegistrationNumber = businessRegistrationNumber;
            this.corporationNumber = corporationNumber;
            this.inventionTitle = inventionTitle;
            this.inventionTitleEng = inventionTitleEng;
            this.applicationNumber = applicationNumber;
            this.applicationDate = applicationDate;
            this.openNumber = openNumber;
            this.openDate = openDate;
            this.publicationNumber = publicationNumber;
            this.publicationDate = publicationDate;
            this.registerNumber = registerNumber;
            this.registerDate = registerDate;
            this.originalApplicationKind = originalApplicationKind;
            this.originalApplicationNumber = originalApplicationNumber;
            this.originalApplicationDate = originalApplicationDate;
            this.finalDisposal = finalDisposal;
            this.registerStatus = registerStatus;
            this.examinerName = examinerName;
            this.originalExaminationRequestFlag = originalExaminationRequestFlag;
            this.originalExaminationRequestDate = originalExaminationRequestDate;
            this.claimCount = claimCount;
            this.applicationFlag = applicationFlag;
            this.translationSubmitDate = translationSubmitDate;
            this.chk_pat = chk_pat;
            this.ipcNumber = ipcNumber;
            this.ipcDate = ipcDate;
        }

        //public DataRow getDatarow(DataTable dt)
        //{
        //    DataRow dr = dt.NewRow();

        //    dr[0] = id;
        //    dr[1] = astrtCont;
        //    dr[2] = name;
        //    dr[3] = engName;
        //    dr[4] = code;
        //    dr[5] = address;
        //    dr[6] = country;
        //    dr[7] = businessRegistrationNumber;
        //    dr[8] = corporationNumber;
        //    dr[9] = inventionTitle;
        //    dr[10] = inventionTitleEng;
        //    dr[11] = applicationNumber;
        //    dr[12] = applicationDate;
        //    dr[13] = openNumber;
        //    dr[14] = openDate;
        //    dr[15] = publicationNumber;
        //    dr[16] = publicationDate;
        //    dr[17] = registerNumber;
        //    dr[18] = registerDate;
        //    dr[19] = originalApplicationKind;
        //    dr[20] = originalApplicationNumber;
        //    dr[21] = originalApplicationDate;
        //    dr[22] = finalDisposal;
        //    dr[23] = registerStatus;
        //    dr[24] = examinerName;
        //    dr[25] = originalExaminationRequestFlag;
        //    dr[26] = originalExaminationRequestDate;
        //    dr[27] = claimCount;
        //    dr[28] = applicationFlag;
        //    dr[29] = translationSubmitDate;
        //    dr[30] = chk_pat;
        //    dr[31] = ipcNumber;
        //    dr[32] = ipcDate;
        //}

    }
}
