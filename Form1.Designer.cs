namespace Structurer
{
    partial class form_main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu_main = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openStructToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveStructToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_FileName = new System.Windows.Forms.TextBox();
            this.txt_StructFile = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripLbl1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tStripLbl_Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.btn_Parse = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grid_Result = new System.Windows.Forms.DataGridView();
            this.data_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rtxt_Result = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.data_Struct = new System.Windows.Forms.DataGridView();
            this.str_type = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.str_size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.str_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menu_main.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Result)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_Struct)).BeginInit();
            this.SuspendLayout();
            // 
            // menu_main
            // 
            this.menu_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menu_main.Location = new System.Drawing.Point(0, 0);
            this.menu_main.Name = "menu_main";
            this.menu_main.Size = new System.Drawing.Size(518, 24);
            this.menu_main.TabIndex = 5;
            this.menu_main.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.openStructToolStripMenuItem,
            this.saveStructToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.openFileToolStripMenuItem.Text = "Open File";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // openStructToolStripMenuItem
            // 
            this.openStructToolStripMenuItem.Name = "openStructToolStripMenuItem";
            this.openStructToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.openStructToolStripMenuItem.Text = "Open Struct";
            this.openStructToolStripMenuItem.Click += new System.EventHandler(this.openStructToolStripMenuItem_Click);
            // 
            // saveStructToolStripMenuItem
            // 
            this.saveStructToolStripMenuItem.Name = "saveStructToolStripMenuItem";
            this.saveStructToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.saveStructToolStripMenuItem.Text = "Save Struct";
            this.saveStructToolStripMenuItem.Click += new System.EventHandler(this.saveStructToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "File:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Structure:";
            // 
            // txt_FileName
            // 
            this.txt_FileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_FileName.Location = new System.Drawing.Point(70, 30);
            this.txt_FileName.Name = "txt_FileName";
            this.txt_FileName.ReadOnly = true;
            this.txt_FileName.Size = new System.Drawing.Size(432, 20);
            this.txt_FileName.TabIndex = 8;
            // 
            // txt_StructFile
            // 
            this.txt_StructFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_StructFile.Location = new System.Drawing.Point(70, 58);
            this.txt_StructFile.Name = "txt_StructFile";
            this.txt_StructFile.ReadOnly = true;
            this.txt_StructFile.Size = new System.Drawing.Size(432, 20);
            this.txt_StructFile.TabIndex = 9;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripLbl1,
            this.tStripLbl_Status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 449);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(518, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(150, 16);
            // 
            // toolStripLbl1
            // 
            this.toolStripLbl1.Name = "toolStripLbl1";
            this.toolStripLbl1.Size = new System.Drawing.Size(42, 17);
            this.toolStripLbl1.Text = "Status:";
            // 
            // tStripLbl_Status
            // 
            this.tStripLbl_Status.Name = "tStripLbl_Status";
            this.tStripLbl_Status.Size = new System.Drawing.Size(31, 17);
            this.tStripLbl_Status.Text = "Wait";
            // 
            // btn_Parse
            // 
            this.btn_Parse.Location = new System.Drawing.Point(12, 84);
            this.btn_Parse.Name = "btn_Parse";
            this.btn_Parse.Size = new System.Drawing.Size(75, 23);
            this.btn_Parse.TabIndex = 13;
            this.btn_Parse.Text = "Parse File";
            this.btn_Parse.UseVisualStyleBackColor = true;
            this.btn_Parse.Click += new System.EventHandler(this.btn_Parse_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 113);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.89602F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.10398F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(494, 327);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tabControl1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(488, 185);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Result";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 16);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(482, 166);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grid_Result);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(474, 140);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Table";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grid_Result
            // 
            this.grid_Result.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_Result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Result.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.data_name,
            this.data_value});
            this.grid_Result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_Result.Location = new System.Drawing.Point(3, 3);
            this.grid_Result.Name = "grid_Result";
            this.grid_Result.Size = new System.Drawing.Size(468, 134);
            this.grid_Result.TabIndex = 1;
            // 
            // data_name
            // 
            this.data_name.HeaderText = "Name";
            this.data_name.Name = "data_name";
            this.data_name.ReadOnly = true;
            // 
            // data_value
            // 
            this.data_value.HeaderText = "Value";
            this.data_value.Name = "data_value";
            this.data_value.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.rtxt_Result);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(474, 140);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Text";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rtxt_Result
            // 
            this.rtxt_Result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxt_Result.Location = new System.Drawing.Point(3, 3);
            this.rtxt_Result.Name = "rtxt_Result";
            this.rtxt_Result.Size = new System.Drawing.Size(468, 134);
            this.rtxt_Result.TabIndex = 0;
            this.rtxt_Result.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.data_Struct);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 130);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Structure";
            // 
            // data_Struct
            // 
            this.data_Struct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_Struct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Struct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.str_type,
            this.str_size,
            this.str_name});
            this.data_Struct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_Struct.Location = new System.Drawing.Point(3, 16);
            this.data_Struct.Name = "data_Struct";
            this.data_Struct.Size = new System.Drawing.Size(482, 111);
            this.data_Struct.TabIndex = 0;
            // 
            // str_type
            // 
            this.str_type.HeaderText = "Type";
            this.str_type.Items.AddRange(new object[] {
            "Byte",
            "Int16",
            "Int32",
            "Int64",
            "String",
            "--",
            "Block",
            "BlockEnd"});
            this.str_type.Name = "str_type";
            // 
            // str_size
            // 
            this.str_size.HeaderText = "Size";
            this.str_size.Name = "str_size";
            // 
            // str_name
            // 
            this.str_name.HeaderText = "Name";
            this.str_name.Name = "str_name";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 471);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btn_Parse);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txt_StructFile);
            this.Controls.Add(this.txt_FileName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu_main);
            this.MainMenuStrip = this.menu_main;
            this.Name = "form_main";
            this.Text = "Struct Discover";
            this.menu_main.ResumeLayout(false);
            this.menu_main.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Result)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_Struct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu_main;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_FileName;
        private System.Windows.Forms.TextBox txt_StructFile;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripLbl1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel tStripLbl_Status;
        private System.Windows.Forms.Button btn_Parse;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView data_Struct;
        private System.Windows.Forms.DataGridView grid_Result;
        private System.Windows.Forms.RichTextBox rtxt_Result;
        private System.Windows.Forms.DataGridViewComboBoxColumn str_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn str_size;
        private System.Windows.Forms.DataGridViewTextBoxColumn str_name;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openStructToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveStructToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_value;
    }
}

