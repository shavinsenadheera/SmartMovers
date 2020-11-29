namespace SmartMovers.V1
{
    partial class LOGINCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOGINCustomer));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxStartLocation = new System.Windows.Forms.ComboBox();
            this.comboBoxEndLocation = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtLocationID = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtCustomerCategory = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtCID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.txtLoadID = new System.Windows.Forms.TextBox();
            this.comboBoxLoadType = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxProductType = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtPayID = new System.Windows.Forms.TextBox();
            this.brnREmove = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxStartLocation);
            this.groupBox2.Controls.Add(this.comboBoxEndLocation);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtLocationID);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Location = new System.Drawing.Point(12, 389);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(541, 213);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Location Information";
            // 
            // comboBoxStartLocation
            // 
            this.comboBoxStartLocation.FormattingEnabled = true;
            this.comboBoxStartLocation.Location = new System.Drawing.Point(224, 58);
            this.comboBoxStartLocation.Name = "comboBoxStartLocation";
            this.comboBoxStartLocation.Size = new System.Drawing.Size(292, 33);
            this.comboBoxStartLocation.TabIndex = 9;
            // 
            // comboBoxEndLocation
            // 
            this.comboBoxEndLocation.FormattingEnabled = true;
            this.comboBoxEndLocation.Location = new System.Drawing.Point(223, 104);
            this.comboBoxEndLocation.Name = "comboBoxEndLocation";
            this.comboBoxEndLocation.Size = new System.Drawing.Size(292, 33);
            this.comboBoxEndLocation.TabIndex = 10;
            this.comboBoxEndLocation.SelectedIndexChanged += new System.EventHandler(this.comboBoxEndLocation_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 112);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "End Location ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Start Location ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 161);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 25);
            this.label10.TabIndex = 8;
            this.label10.Text = "Location ID";
            // 
            // txtLocationID
            // 
            this.txtLocationID.Location = new System.Drawing.Point(224, 158);
            this.txtLocationID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLocationID.Name = "txtLocationID";
            this.txtLocationID.Size = new System.Drawing.Size(292, 30);
            this.txtLocationID.TabIndex = 5;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dateTimePicker1);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.txtPayment);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox4.Location = new System.Drawing.Point(12, 626);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(541, 177);
            this.groupBox4.TabIndex = 39;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Payment Information";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(170, 111);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(351, 30);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Payment Date";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(29, 60);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(89, 25);
            this.label18.TabIndex = 16;
            this.label18.Text = "Payment";
            // 
            // txtPayment
            // 
            this.txtPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayment.Location = new System.Drawing.Point(170, 60);
            this.txtPayment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(351, 30);
            this.txtPayment.TabIndex = 5;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtCustomerCategory);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.txtCID);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.txtProductID);
            this.groupBox5.Controls.Add(this.txtLoadID);
            this.groupBox5.Controls.Add(this.comboBoxLoadType);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.comboBoxProductType);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox5.Location = new System.Drawing.Point(12, 21);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(541, 347);
            this.groupBox5.TabIndex = 38;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ordered Load Information";
            // 
            // txtCustomerCategory
            // 
            this.txtCustomerCategory.BackColor = System.Drawing.Color.White;
            this.txtCustomerCategory.Location = new System.Drawing.Point(225, 96);
            this.txtCustomerCategory.Name = "txtCustomerCategory";
            this.txtCustomerCategory.Size = new System.Drawing.Size(296, 30);
            this.txtCustomerCategory.TabIndex = 22;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(13, 99);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(138, 25);
            this.label20.TabIndex = 21;
            this.label20.Text = "Your Category";
            // 
            // txtCID
            // 
            this.txtCID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCID.Location = new System.Drawing.Point(225, 57);
            this.txtCID.Name = "txtCID";
            this.txtCID.Size = new System.Drawing.Size(296, 30);
            this.txtCID.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 25);
            this.label11.TabIndex = 21;
            this.label11.Text = "Your ID";
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(225, 200);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(296, 30);
            this.txtProductID.TabIndex = 20;
            // 
            // txtLoadID
            // 
            this.txtLoadID.Location = new System.Drawing.Point(225, 292);
            this.txtLoadID.Name = "txtLoadID";
            this.txtLoadID.Size = new System.Drawing.Size(296, 30);
            this.txtLoadID.TabIndex = 20;
            // 
            // comboBoxLoadType
            // 
            this.comboBoxLoadType.FormattingEnabled = true;
            this.comboBoxLoadType.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large"});
            this.comboBoxLoadType.Location = new System.Drawing.Point(225, 244);
            this.comboBoxLoadType.Name = "comboBoxLoadType";
            this.comboBoxLoadType.Size = new System.Drawing.Size(296, 33);
            this.comboBoxLoadType.TabIndex = 19;
            this.comboBoxLoadType.Text = "Select load type";
            this.comboBoxLoadType.SelectedIndexChanged += new System.EventHandler(this.comboBoxLoadType_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 297);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 25);
            this.label12.TabIndex = 16;
            this.label12.Text = "Load ID";
            // 
            // comboBoxProductType
            // 
            this.comboBoxProductType.FormattingEnabled = true;
            this.comboBoxProductType.Items.AddRange(new object[] {
            "No Risk",
            "High Risk"});
            this.comboBoxProductType.Location = new System.Drawing.Point(225, 140);
            this.comboBoxProductType.Name = "comboBoxProductType";
            this.comboBoxProductType.Size = new System.Drawing.Size(296, 33);
            this.comboBoxProductType.TabIndex = 18;
            this.comboBoxProductType.Text = "Select product type";
            this.comboBoxProductType.SelectedIndexChanged += new System.EventHandler(this.comboBoxProductType_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 252);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(183, 25);
            this.label15.TabIndex = 12;
            this.label15.Text = "Ordered Load Type";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(13, 203);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(103, 25);
            this.label19.TabIndex = 14;
            this.label19.Text = "Product ID";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(13, 148);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(206, 25);
            this.label16.TabIndex = 14;
            this.label16.Text = "Ordered Product Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(638, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 41;
            this.label1.Text = "label1";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(643, 406);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(331, 41);
            this.button2.TabIndex = 42;
            this.button2.Text = "SUBMIT REQUEST";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(643, 472);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(331, 41);
            this.button1.TabIndex = 42;
            this.button1.Text = "EDIT REQUEST";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Maroon;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button3.Location = new System.Drawing.Point(607, 752);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(182, 41);
            this.button3.TabIndex = 42;
            this.button3.Text = "LOG OUT";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtPayID
            // 
            this.txtPayID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayID.Location = new System.Drawing.Point(874, 755);
            this.txtPayID.Name = "txtPayID";
            this.txtPayID.Size = new System.Drawing.Size(100, 34);
            this.txtPayID.TabIndex = 43;
            // 
            // brnREmove
            // 
            this.brnREmove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.brnREmove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.brnREmove.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnREmove.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.brnREmove.Location = new System.Drawing.Point(643, 534);
            this.brnREmove.Name = "brnREmove";
            this.brnREmove.Size = new System.Drawing.Size(331, 41);
            this.brnREmove.TabIndex = 35;
            this.brnREmove.Text = "REMOVE REQUEST";
            this.brnREmove.UseVisualStyleBackColor = false;
            this.brnREmove.Click += new System.EventHandler(this.brnREmove_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAccount.Location = new System.Drawing.Point(643, 72);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(331, 41);
            this.btnAccount.TabIndex = 44;
            this.btnAccount.Text = "GO TO YOUR ACCOUNT";
            this.btnAccount.UseVisualStyleBackColor = false;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // LOGINCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(996, 827);
            this.Controls.Add(this.btnAccount);
            this.Controls.Add(this.brnREmove);
            this.Controls.Add(this.txtPayID);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LOGINCustomer";
            this.Text = "Your Order";
            this.Load += new System.EventHandler(this.LOGINCustomer_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxStartLocation;
        private System.Windows.Forms.ComboBox comboBoxEndLocation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtLocationID;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtCustomerCategory;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtCID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.TextBox txtLoadID;
        private System.Windows.Forms.ComboBox comboBoxLoadType;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxProductType;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtPayID;
        private System.Windows.Forms.Button brnREmove;
        private System.Windows.Forms.Button btnAccount;
    }
}