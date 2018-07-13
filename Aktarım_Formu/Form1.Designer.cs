namespace Aktarım_Formu
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.explanation = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nameOfEngineerTb = new System.Windows.Forms.TextBox();
            this.timeofchange = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NewcopyGroup = new System.Windows.Forms.GroupBox();
            this.akkcics = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Genlcics = new System.Windows.Forms.CheckBox();
            this.createButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MemberName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CicsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insertButton = new System.Windows.Forms.Button();
            this.memberTypeCb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.memberNameTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.NewcopyGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Aktarım Tarihi :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(185, 28);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(116, 22);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Aktarım Yapan Yazılımcı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Açıklama :";
            // 
            // explanation
            // 
            this.explanation.Location = new System.Drawing.Point(185, 115);
            this.explanation.Multiline = true;
            this.explanation.Name = "explanation";
            this.explanation.Size = new System.Drawing.Size(496, 136);
            this.explanation.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nameOfEngineerTb);
            this.groupBox1.Controls.Add(this.timeofchange);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.explanation);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(687, 271);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aktarım Detayları";
            // 
            // nameOfEngineerTb
            // 
            this.nameOfEngineerTb.Location = new System.Drawing.Point(185, 69);
            this.nameOfEngineerTb.Name = "nameOfEngineerTb";
            this.nameOfEngineerTb.ReadOnly = true;
            this.nameOfEngineerTb.Size = new System.Drawing.Size(234, 22);
            this.nameOfEngineerTb.TabIndex = 9;
            // 
            // timeofchange
            // 
            this.timeofchange.FormatString = "t";
            this.timeofchange.FormattingEnabled = true;
            this.timeofchange.Items.AddRange(new object[] {
            "00:00",
            "00:15",
            "00:30",
            "00:45",
            "01:00",
            "01:15",
            "01:30",
            "01:45",
            "02:00",
            "02:15",
            "02:30",
            "02:45",
            "03:00",
            "03:15",
            "03:30",
            "03:45",
            "04:00",
            "04:15",
            "04:30",
            "04:45",
            "05:00",
            "05:15",
            "05:30",
            "05:45",
            "06:00",
            "06:15",
            "06:30",
            "06:45",
            "07:00",
            "07:15",
            "07:30",
            "07:45",
            "08:00",
            "08:15",
            "08:30",
            "08:45",
            "09:00",
            "09:15",
            "09:30",
            "09:45",
            "10:00",
            "10:15",
            "10:30",
            "10:45",
            "11:00",
            "11:15",
            "11:30",
            "11:45",
            "12:00",
            "12:15",
            "12:30",
            "12:45",
            "13:00",
            "13:15",
            "13:30",
            "13:45",
            "14:00",
            "14:15",
            "14:30",
            "14:45",
            "15:00",
            "15:15",
            "15:30",
            "15:45",
            "16:00",
            "16:15",
            "16:30",
            "16:45",
            "17:00",
            "17:15",
            "17:30",
            "17:45",
            "18:00",
            "18:15",
            "18:30",
            "18:45",
            "19:00",
            "19:15",
            "19:30",
            "19:45",
            "20:00",
            "20:15",
            "20:30",
            "20:45",
            "21:00",
            "21:15",
            "21:30",
            "21:45",
            "22:00",
            "22:15",
            "22:30",
            "22:45",
            "23:00",
            "23:15",
            "23:30",
            "23:45"});
            this.timeofchange.Location = new System.Drawing.Point(505, 33);
            this.timeofchange.Name = "timeofchange";
            this.timeofchange.Size = new System.Drawing.Size(104, 24);
            this.timeofchange.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(399, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Aktarım Saati :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NewcopyGroup);
            this.groupBox2.Controls.Add(this.createButton);
            this.groupBox2.Controls.Add(this.updateButton);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.insertButton);
            this.groupBox2.Controls.Add(this.memberTypeCb);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.memberNameTb);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 289);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(687, 417);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Aktarım Yapılacak Programlar";
            // 
            // NewcopyGroup
            // 
            this.NewcopyGroup.Controls.Add(this.akkcics);
            this.NewcopyGroup.Controls.Add(this.label7);
            this.NewcopyGroup.Controls.Add(this.Genlcics);
            this.NewcopyGroup.Location = new System.Drawing.Point(9, 106);
            this.NewcopyGroup.Name = "NewcopyGroup";
            this.NewcopyGroup.Size = new System.Drawing.Size(376, 41);
            this.NewcopyGroup.TabIndex = 7;
            this.NewcopyGroup.TabStop = false;
            // 
            // akkcics
            // 
            this.akkcics.AutoSize = true;
            this.akkcics.Location = new System.Drawing.Point(284, 17);
            this.akkcics.Name = "akkcics";
            this.akkcics.Size = new System.Drawing.Size(87, 21);
            this.akkcics.TabIndex = 11;
            this.akkcics.Text = "AKKCICS";
            this.akkcics.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Newcopy Cics :";
            // 
            // Genlcics
            // 
            this.Genlcics.AutoSize = true;
            this.Genlcics.Location = new System.Drawing.Point(179, 17);
            this.Genlcics.Name = "Genlcics";
            this.Genlcics.Size = new System.Drawing.Size(98, 21);
            this.Genlcics.TabIndex = 10;
            this.Genlcics.Text = "GENLCICS";
            this.Genlcics.UseVisualStyleBackColor = true;
            // 
            // createButton
            // 
            this.createButton.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createButton.Location = new System.Drawing.Point(408, 92);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(230, 46);
            this.createButton.TabIndex = 9;
            this.createButton.Text = "Aktarım Formu Oluştur";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(548, 37);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(90, 47);
            this.updateButton.TabIndex = 8;
            this.updateButton.Text = "Güncelle";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MemberName,
            this.MemberType,
            this.CicsName});
            this.dataGridView1.Location = new System.Drawing.Point(9, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(672, 258);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // MemberName
            // 
            this.MemberName.HeaderText = "Member Name";
            this.MemberName.Name = "MemberName";
            this.MemberName.ReadOnly = true;
            // 
            // MemberType
            // 
            this.MemberType.HeaderText = "Member Type";
            this.MemberType.Name = "MemberType";
            this.MemberType.ReadOnly = true;
            // 
            // CicsName
            // 
            this.CicsName.HeaderText = "Cics Name";
            this.CicsName.Name = "CicsName";
            this.CicsName.ReadOnly = true;
            // 
            // insertButton
            // 
            this.insertButton.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertButton.Location = new System.Drawing.Point(408, 37);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(90, 47);
            this.insertButton.TabIndex = 6;
            this.insertButton.Text = "Ekle";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // memberTypeCb
            // 
            this.memberTypeCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.memberTypeCb.Items.AddRange(new object[] {
            "Batch",
            "Online",
            "ISP",
            "JCL",
            "Map",
            "EXCI",
            "Assembly"});
            this.memberTypeCb.Location = new System.Drawing.Point(185, 76);
            this.memberTypeCb.Name = "memberTypeCb";
            this.memberTypeCb.Size = new System.Drawing.Size(192, 24);
            this.memberTypeCb.TabIndex = 3;
            this.memberTypeCb.SelectedIndexChanged += new System.EventHandler(this.memberTypeCb_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Member Type :";
            // 
            // memberNameTb
            // 
            this.memberNameTb.Location = new System.Drawing.Point(185, 37);
            this.memberNameTb.MaxLength = 8;
            this.memberNameTb.Name = "memberNameTb";
            this.memberNameTb.Size = new System.Drawing.Size(192, 22);
            this.memberNameTb.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Member Name :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(712, 714);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MAINFRAME PRODUCTION AKTARIM BİLGİLENDİRME FORMU";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.NewcopyGroup.ResumeLayout(false);
            this.NewcopyGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox explanation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox memberTypeCb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox memberNameTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberType;
        private System.Windows.Forms.DataGridViewTextBoxColumn CicsName;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox akkcics;
        private System.Windows.Forms.CheckBox Genlcics;
        private System.Windows.Forms.GroupBox NewcopyGroup;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox timeofchange;
        private System.Windows.Forms.TextBox nameOfEngineerTb;
    }
}

