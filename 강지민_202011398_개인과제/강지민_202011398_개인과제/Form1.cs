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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        DataTable dt3 = new DataTable();
        private void Load_Click(object sender, EventArgs e)
        {
            JSONFileManager mgr = new JSONFileManager();
            dataGridView1.DataSource = mgr.mergeTable3;
            

            string json = JsonConvert.SerializeObject(mgr.mergeTable3, Formatting.Indented);
            string savePath = "./개인과제data.json";
            File.WriteAllText(savePath, json);

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
            dataGridView2.DataSource = dt3;
        }

        private void Search_Click_1(object sender, EventArgs e)
        {           
            if (rbtn_Id.Checked)
            {
                string searchValue = textBox1.Text;
                int rowIndex = -1;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                try
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.Cells[0].Value.ToString().Contains(searchValue))
                        {
                            rowIndex = row.Index;
                            dataGridView1.ClearSelection();
                            row.Selected = true;
                            dataGridView1.FirstDisplayedScrollingRowIndex = rowIndex;
                            dataGridView1.Focus();
                            break;                            
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("No solutions with that name.");
                }
            } else if (rbtn_Abstract.Checked)
            {
                string searchValue = textBox1.Text;
                int rowIndex = -1;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                try
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.Cells[1].Value.ToString().Contains(searchValue))
                        {
                            rowIndex = row.Index;
                            dataGridView1.ClearSelection();
                            row.Selected = true;
                            dataGridView1.FirstDisplayedScrollingRowIndex = rowIndex;
                            dataGridView1.Focus();
                            break;
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("No solutions with that name.");
                }
            } else if (rbtn_author.Checked)
            {
                string searchValue = textBox1.Text;
                int rowIndex = -1;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                try
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.Cells[2].Value.ToString().Contains(searchValue))
                        {
                            rowIndex = row.Index;
                            dataGridView1.ClearSelection();
                            row.Selected = true;
                            dataGridView1.FirstDisplayedScrollingRowIndex = rowIndex;
                            dataGridView1.Focus();
                            break;
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("No solutions with that name.");
                }
            } else if (rbtn_IPC_Number.Checked)
            {
                string searchValue = textBox1.Text;
                int rowIndex = -1;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                try
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.Cells[31].Value.ToString().Contains(searchValue))
                        {
                            rowIndex = row.Index;
                            dataGridView1.ClearSelection();
                            row.Selected = true;
                            dataGridView1.FirstDisplayedScrollingRowIndex = rowIndex;
                            dataGridView1.Focus();
                            break;
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("No solutions with that name.");
                }
            }

        }

        
        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {            
            DataRow row = (dataGridView1.Rows[e.RowIndex].DataBoundItem as DataRowView).Row;
            dt3.Rows.Add(row.ItemArray);
        }

        private void Save_Click(object sender, EventArgs e)
        {            
            string json = JsonConvert.SerializeObject(dt3, Formatting.Indented);
            string savePath = "./장바구니data.json";
            File.WriteAllText(savePath, json);
        }

        private void Reset_Click(object sender, EventArgs e)
        {            
            dt3.Clear();
        }
    }
}
