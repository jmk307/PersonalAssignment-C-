
namespace 강지민_202011398_개인과제
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Save = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Load = new System.Windows.Forms.Button();
            this.rbtn_Id = new System.Windows.Forms.RadioButton();
            this.rbtn_Abstract = new System.Windows.Forms.RadioButton();
            this.rbtn_author = new System.Windows.Forms.RadioButton();
            this.rbtn_IPC_Number = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 28);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(981, 613);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(981, 613);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(981, 613);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "장바구니";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 30;
            this.dataGridView2.Size = new System.Drawing.Size(975, 498);
            this.dataGridView2.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Reset);
            this.panel2.Controls.Add(this.Save);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 501);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(975, 110);
            this.panel2.TabIndex = 1;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(749, 24);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(210, 61);
            this.Save.TabIndex = 0;
            this.Save.Text = "장바구니 저장";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(515, 24);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(210, 61);
            this.Reset.TabIndex = 1;
            this.Reset.Text = "장바구니 초기화";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(981, 613);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "특허데이터";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(975, 482);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Search);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.rbtn_IPC_Number);
            this.panel1.Controls.Add(this.rbtn_author);
            this.panel1.Controls.Add(this.rbtn_Abstract);
            this.panel1.Controls.Add(this.rbtn_Id);
            this.panel1.Controls.Add(this.Load);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 485);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(975, 130);
            this.panel1.TabIndex = 1;
            // 
            // Load
            // 
            this.Load.Location = new System.Drawing.Point(17, 26);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(169, 74);
            this.Load.TabIndex = 0;
            this.Load.Text = "특허데이터 보기";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // rbtn_Id
            // 
            this.rbtn_Id.AutoSize = true;
            this.rbtn_Id.Location = new System.Drawing.Point(504, 27);
            this.rbtn_Id.Name = "rbtn_Id";
            this.rbtn_Id.Size = new System.Drawing.Size(46, 22);
            this.rbtn_Id.TabIndex = 1;
            this.rbtn_Id.TabStop = true;
            this.rbtn_Id.Text = "Id";
            this.rbtn_Id.UseVisualStyleBackColor = true;
            // 
            // rbtn_Abstract
            // 
            this.rbtn_Abstract.AutoSize = true;
            this.rbtn_Abstract.Location = new System.Drawing.Point(581, 27);
            this.rbtn_Abstract.Name = "rbtn_Abstract";
            this.rbtn_Abstract.Size = new System.Drawing.Size(69, 22);
            this.rbtn_Abstract.TabIndex = 2;
            this.rbtn_Abstract.TabStop = true;
            this.rbtn_Abstract.Text = "초록";
            this.rbtn_Abstract.UseVisualStyleBackColor = true;
            // 
            // rbtn_author
            // 
            this.rbtn_author.AutoSize = true;
            this.rbtn_author.Location = new System.Drawing.Point(670, 27);
            this.rbtn_author.Name = "rbtn_author";
            this.rbtn_author.Size = new System.Drawing.Size(69, 22);
            this.rbtn_author.TabIndex = 3;
            this.rbtn_author.TabStop = true;
            this.rbtn_author.Text = "저자";
            this.rbtn_author.UseVisualStyleBackColor = true;
            // 
            // rbtn_IPC_Number
            // 
            this.rbtn_IPC_Number.AutoSize = true;
            this.rbtn_IPC_Number.Location = new System.Drawing.Point(745, 27);
            this.rbtn_IPC_Number.Name = "rbtn_IPC_Number";
            this.rbtn_IPC_Number.Size = new System.Drawing.Size(59, 22);
            this.rbtn_IPC_Number.TabIndex = 4;
            this.rbtn_IPC_Number.TabStop = true;
            this.rbtn_IPC_Number.Text = "IPC";
            this.rbtn_IPC_Number.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(505, 58);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(299, 43);
            this.textBox1.TabIndex = 5;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(834, 58);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(101, 43);
            this.Search.TabIndex = 6;
            this.Search.Text = "검색";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(236, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 36);
            this.label1.TabIndex = 7;
            this.label1.Text = "헤더를 더블클릭하면\r\n장바구니에 담을 수 있음!";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(989, 645);
            this.tabControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 645);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "나만의 특허관리 프로그램";
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button Save;
        public System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Search;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton rbtn_IPC_Number;
        private System.Windows.Forms.RadioButton rbtn_author;
        private System.Windows.Forms.RadioButton rbtn_Abstract;
        private System.Windows.Forms.RadioButton rbtn_Id;
        public System.Windows.Forms.Button Load;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.TabControl tabControl1;
    }
}

