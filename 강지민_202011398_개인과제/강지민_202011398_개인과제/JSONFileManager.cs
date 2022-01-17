using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace 강지민_202011398_개인과제
{
    public class JSONFileManager
    {
        public DataTable dt1;
        public DataTable dt2;
        public DataTable dt3;
        public DataTable dt4;
        public DataTable mergeTable1 = new DataTable();
        public DataTable mergeTable2 = new DataTable();
        public DataTable mergeTable3 = new DataTable();

        public DataTable MergeTablesByIndex(DataTable dt1, DataTable dt2)
        {
            DataTable mergeTable = dt1.Clone();
            foreach (DataColumn col in dt2.Columns)
            {
                string newColumnName = col.ColumnName;
                int colNum = 1;
                while (mergeTable.Columns.Contains(newColumnName))
                {
                    newColumnName = $"{col.ColumnName}_{++colNum}";
                }
                mergeTable.Columns.Add(newColumnName, col.DataType);
            }
            var mergedRows = dt1.AsEnumerable().Zip(dt2.AsEnumerable(), (r1, r2) => r1.ItemArray.Concat(r2.ItemArray).ToArray());
            foreach (object[] rowFields in mergedRows)
                mergeTable.Rows.Add(rowFields);


            return mergeTable;
        }

        
        public JSONFileManager()
        {
            this.dt1 = (DataTable)JsonConvert.DeserializeObject(File.ReadAllText("./abstract.json"), (typeof(DataTable)));
            this.dt2 = (DataTable)JsonConvert.DeserializeObject(File.ReadAllText("./applicant.json"), (typeof(DataTable)));
            dt2.Columns.Remove("id");
            this.dt3 = (DataTable)JsonConvert.DeserializeObject(File.ReadAllText("./bibliosummary.json"), (typeof(DataTable)));
            dt3.Columns.Remove("id");
            this.dt4 = (DataTable)JsonConvert.DeserializeObject(File.ReadAllText("./ipc.json"), (typeof(DataTable)));
            dt4.Columns.Remove("id");            

            mergeTable1 = MergeTablesByIndex(dt1, dt2);
            mergeTable2 = MergeTablesByIndex(mergeTable1, dt3);
            mergeTable3 = MergeTablesByIndex(mergeTable2, dt4);
        }

        

    }
    
}
