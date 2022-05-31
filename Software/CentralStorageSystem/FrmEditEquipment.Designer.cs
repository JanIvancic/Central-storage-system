namespace CentralStorageSystem
{
    partial class FrmEditEquipment
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
            this.cboOrderer = new System.Windows.Forms.ComboBox();
            this.cboFundingSource = new System.Windows.Forms.ComboBox();
            this.btnAddEquipment = new System.Windows.Forms.Button();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtEqupmentType = new System.Windows.Forms.TextBox();
            this.txtEquipmentName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // cboOrderer
            // 
            this.cboOrderer.FormattingEnabled = true;
            this.cboOrderer.Location = new System.Drawing.Point(215, 346);
            this.cboOrderer.Name = "cboOrderer";
            this.cboOrderer.Size = new System.Drawing.Size(375, 33);
            this.cboOrderer.TabIndex = 30;
            // 
            // cboFundingSource
            // 
            this.cboFundingSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFundingSource.FormattingEnabled = true;
            this.cboFundingSource.Location = new System.Drawing.Point(215, 461);
            this.cboFundingSource.Name = "cboFundingSource";
            this.cboFundingSource.Size = new System.Drawing.Size(375, 33);
            this.cboFundingSource.TabIndex = 29;
            // 
            // btnAddEquipment
            // 
            this.btnAddEquipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEquipment.Location = new System.Drawing.Point(316, 1044);
            this.btnAddEquipment.Name = "btnAddEquipment";
            this.btnAddEquipment.Size = new System.Drawing.Size(274, 60);
            this.btnAddEquipment.TabIndex = 28;
            this.btnAddEquipment.Text = "UNESI PROMJENU";
            this.btnAddEquipment.UseVisualStyleBackColor = true;
            this.btnAddEquipment.Click += new System.EventHandler(this.btnAddEquipment_Click);
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(215, 974);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(375, 31);
            this.txtProjectName.TabIndex = 27;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(215, 713);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(375, 157);
            this.txtDescription.TabIndex = 26;
            // 
            // txtEqupmentType
            // 
            this.txtEqupmentType.Location = new System.Drawing.Point(215, 584);
            this.txtEqupmentType.Name = "txtEqupmentType";
            this.txtEqupmentType.Size = new System.Drawing.Size(375, 31);
            this.txtEqupmentType.TabIndex = 25;
            // 
            // txtEquipmentName
            // 
            this.txtEquipmentName.Location = new System.Drawing.Point(215, 224);
            this.txtEquipmentName.Name = "txtEquipmentName";
            this.txtEquipmentName.Size = new System.Drawing.Size(375, 31);
            this.txtEquipmentName.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(210, 925);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 25);
            this.label8.TabIndex = 23;
            this.label8.Text = "Naziv projekta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(210, 671);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "Opis";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(210, 540);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "Vrsta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(210, 416);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Izvor financiranja";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Narucitelj";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Naziv opreme";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(522, 42);
            this.label1.TabIndex = 17;
            this.label1.Text = "Promjena podataka o opremi";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FrmEditEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 1188);
            this.Controls.Add(this.cboOrderer);
            this.Controls.Add(this.cboFundingSource);
            this.Controls.Add(this.btnAddEquipment);
            this.Controls.Add(this.txtProjectName);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtEqupmentType);
            this.Controls.Add(this.txtEquipmentName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmEditEquipment";
            this.Text = "FrmEditEquipment";
            this.Load += new System.EventHandler(this.FrmEditEquipment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboOrderer;
        private System.Windows.Forms.ComboBox cboFundingSource;
        private System.Windows.Forms.Button btnAddEquipment;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtEqupmentType;
        private System.Windows.Forms.TextBox txtEquipmentName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}