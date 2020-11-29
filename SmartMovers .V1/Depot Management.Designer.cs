namespace SmartMovers.V1
{
    partial class Depot_Management
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Depot_Management));
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTelNo2 = new System.Windows.Forms.TextBox();
            this.txtTelNo1 = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.telephoneNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depotIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depotNumberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shavi__SmartMoversDataSet6 = new SmartMovers.V1.Shavi__SmartMoversDataSet6();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.depotIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depotNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depotBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shavi__SmartMoversDataSet5 = new SmartMovers.V1.Shavi__SmartMoversDataSet5();
            this.depotTableAdapter = new SmartMovers.V1.Shavi__SmartMoversDataSet5TableAdapters.DepotTableAdapter();
            this.depot_NumberTableAdapter = new SmartMovers.V1.Shavi__SmartMoversDataSet6TableAdapters.Depot_NumberTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depotNumberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shavi__SmartMoversDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depotBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shavi__SmartMoversDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(42, 484);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(327, 60);
            this.button3.TabIndex = 12;
            this.button3.Text = "DELETE INFORMATION";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(42, 406);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(327, 60);
            this.button2.TabIndex = 11;
            this.button2.Text = "UPDATE INFORMATION";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(42, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(327, 60);
            this.button1.TabIndex = 10;
            this.button1.Text = "SUBMIT INFORMATION";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTelNo2);
            this.groupBox1.Controls.Add(this.txtTelNo1);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtDID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Location = new System.Drawing.Point(31, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(571, 269);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Depot Information";
            // 
            // txtTelNo2
            // 
            this.txtTelNo2.Location = new System.Drawing.Point(314, 221);
            this.txtTelNo2.Name = "txtTelNo2";
            this.txtTelNo2.Size = new System.Drawing.Size(239, 30);
            this.txtTelNo2.TabIndex = 3;
            // 
            // txtTelNo1
            // 
            this.txtTelNo1.Location = new System.Drawing.Point(314, 176);
            this.txtTelNo1.Name = "txtTelNo1";
            this.txtTelNo1.Size = new System.Drawing.Size(239, 30);
            this.txtTelNo1.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(314, 118);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(239, 30);
            this.txtName.TabIndex = 3;
            // 
            // txtDID
            // 
            this.txtDID.Location = new System.Drawing.Point(314, 58);
            this.txtDID.Name = "txtDID";
            this.txtDID.Size = new System.Drawing.Size(239, 30);
            this.txtDID.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Product Depot Telephone No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Depot Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Depot ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Location = new System.Drawing.Point(608, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(655, 748);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Depot Information";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(161, 53);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(434, 30);
            this.txtSearch.TabIndex = 36;
            this.txtSearch.Text = "Search Depot Name...";
            this.txtSearch.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtSearch_MouseDoubleClick);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(18, 45);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(123, 38);
            this.btnSearch.TabIndex = 35;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.telephoneNoDataGridViewTextBoxColumn,
            this.depotIDDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.depotNumberBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(18, 506);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(613, 211);
            this.dataGridView2.TabIndex = 1;
            // 
            // telephoneNoDataGridViewTextBoxColumn
            // 
            this.telephoneNoDataGridViewTextBoxColumn.DataPropertyName = "Telephone_No";
            this.telephoneNoDataGridViewTextBoxColumn.HeaderText = "Telephone_No";
            this.telephoneNoDataGridViewTextBoxColumn.Name = "telephoneNoDataGridViewTextBoxColumn";
            // 
            // depotIDDataGridViewTextBoxColumn1
            // 
            this.depotIDDataGridViewTextBoxColumn1.DataPropertyName = "Depot_ID";
            this.depotIDDataGridViewTextBoxColumn1.HeaderText = "Depot_ID";
            this.depotIDDataGridViewTextBoxColumn1.Name = "depotIDDataGridViewTextBoxColumn1";
            // 
            // depotNumberBindingSource
            // 
            this.depotNumberBindingSource.DataMember = "Depot_Number";
            this.depotNumberBindingSource.DataSource = this.shavi__SmartMoversDataSet6;
            // 
            // shavi__SmartMoversDataSet6
            // 
            this.shavi__SmartMoversDataSet6.DataSetName = "Shavi__SmartMoversDataSet6";
            this.shavi__SmartMoversDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.depotIDDataGridViewTextBoxColumn,
            this.depotNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.depotBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(18, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(613, 368);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // depotIDDataGridViewTextBoxColumn
            // 
            this.depotIDDataGridViewTextBoxColumn.DataPropertyName = "Depot_ID";
            this.depotIDDataGridViewTextBoxColumn.HeaderText = "Depot_ID";
            this.depotIDDataGridViewTextBoxColumn.Name = "depotIDDataGridViewTextBoxColumn";
            // 
            // depotNameDataGridViewTextBoxColumn
            // 
            this.depotNameDataGridViewTextBoxColumn.DataPropertyName = "Depot_Name";
            this.depotNameDataGridViewTextBoxColumn.HeaderText = "Depot_Name";
            this.depotNameDataGridViewTextBoxColumn.Name = "depotNameDataGridViewTextBoxColumn";
            // 
            // depotBindingSource
            // 
            this.depotBindingSource.DataMember = "Depot";
            this.depotBindingSource.DataSource = this.shavi__SmartMoversDataSet5;
            // 
            // shavi__SmartMoversDataSet5
            // 
            this.shavi__SmartMoversDataSet5.DataSetName = "Shavi__SmartMoversDataSet5";
            this.shavi__SmartMoversDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // depotTableAdapter
            // 
            this.depotTableAdapter.ClearBeforeFill = true;
            // 
            // depot_NumberTableAdapter
            // 
            this.depot_NumberTableAdapter.ClearBeforeFill = true;
            // 
            // Depot_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1366, 833);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Depot_Management";
            this.Text = "Depot Management";
            this.Load += new System.EventHandler(this.Depot_Management_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depotNumberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shavi__SmartMoversDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depotBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shavi__SmartMoversDataSet5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTelNo2;
        private System.Windows.Forms.TextBox txtTelNo1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private Shavi__SmartMoversDataSet5 shavi__SmartMoversDataSet5;
        private System.Windows.Forms.BindingSource depotBindingSource;
        private Shavi__SmartMoversDataSet5TableAdapters.DepotTableAdapter depotTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn depotIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depotNameDataGridViewTextBoxColumn;
        private Shavi__SmartMoversDataSet6 shavi__SmartMoversDataSet6;
        private System.Windows.Forms.BindingSource depotNumberBindingSource;
        private Shavi__SmartMoversDataSet6TableAdapters.Depot_NumberTableAdapter depot_NumberTableAdapter;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depotIDDataGridViewTextBoxColumn1;
    }
}