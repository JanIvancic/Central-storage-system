namespace CentralStorageSystem
{
    partial class FrmNewEquipment
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEquipmentName = new System.Windows.Forms.TextBox();
            this.txtEqupmentType = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.btnAddEquipment = new System.Windows.Forms.Button();
            this.cboFundingSource = new System.Windows.Forms.ComboBox();
            this.cboOrderer = new System.Windows.Forms.ComboBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unos nove opreme";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Naziv opreme";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Narucitelj";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Izvor financiranja";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(189, 498);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Vrsta";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(189, 629);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Opis";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(764, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 25);
            this.label7.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(189, 883);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Naziv projekta";
            // 
            // txtEquipmentName
            // 
            this.txtEquipmentName.Location = new System.Drawing.Point(194, 182);
            this.txtEquipmentName.Name = "txtEquipmentName";
            this.txtEquipmentName.Size = new System.Drawing.Size(375, 31);
            this.txtEquipmentName.TabIndex = 8;
            this.txtEquipmentName.TextChanged += new System.EventHandler(this.txtEquipmentName_TextChanged);
            // 
            // txtEqupmentType
            // 
            this.txtEqupmentType.Location = new System.Drawing.Point(194, 542);
            this.txtEqupmentType.Name = "txtEqupmentType";
            this.txtEqupmentType.Size = new System.Drawing.Size(375, 31);
            this.txtEqupmentType.TabIndex = 11;
            this.txtEqupmentType.TextChanged += new System.EventHandler(this.txtEqupmentType_TextChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(194, 671);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(375, 157);
            this.txtDescription.TabIndex = 12;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(194, 932);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(375, 31);
            this.txtProjectName.TabIndex = 13;
            // 
            // btnAddEquipment
            // 
            this.btnAddEquipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEquipment.Location = new System.Drawing.Point(349, 1002);
            this.btnAddEquipment.Name = "btnAddEquipment";
            this.btnAddEquipment.Size = new System.Drawing.Size(220, 60);
            this.btnAddEquipment.TabIndex = 14;
            this.btnAddEquipment.Text = "UNESI OPREMU";
            this.btnAddEquipment.UseVisualStyleBackColor = true;
            this.btnAddEquipment.Click += new System.EventHandler(this.btnAddEquipment_Click);
            // 
            // cboFundingSource
            // 
            this.cboFundingSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFundingSource.FormattingEnabled = true;
            this.cboFundingSource.Location = new System.Drawing.Point(194, 419);
            this.cboFundingSource.Name = "cboFundingSource";
            this.cboFundingSource.Size = new System.Drawing.Size(375, 33);
            this.cboFundingSource.TabIndex = 15;
            this.cboFundingSource.SelectedIndexChanged += new System.EventHandler(this.cboFundingSource_SelectedIndexChanged);
            // 
            // cboOrderer
            // 
            this.cboOrderer.FormattingEnabled = true;
            this.cboOrderer.Location = new System.Drawing.Point(194, 304);
            this.cboOrderer.Name = "cboOrderer";
            this.cboOrderer.Size = new System.Drawing.Size(375, 33);
            this.cboOrderer.TabIndex = 16;
            this.cboOrderer.SelectedIndexChanged += new System.EventHandler(this.cboOrderer_SelectedIndexChanged);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkRate = 0;
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // FrmNewEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 1205);
            this.Controls.Add(this.cboOrderer);
            this.Controls.Add(this.cboFundingSource);
            this.Controls.Add(this.btnAddEquipment);
            this.Controls.Add(this.txtProjectName);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtEqupmentType);
            this.Controls.Add(this.txtEquipmentName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmNewEquipment";
            this.Text = "Central Storage System | Nova oprema";
            this.Load += new System.EventHandler(this.FrmNewEquipment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEquipmentName;
        private System.Windows.Forms.TextBox txtEqupmentType;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.Button btnAddEquipment;
        private System.Windows.Forms.ComboBox cboFundingSource;
        private System.Windows.Forms.ComboBox cboOrderer;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}