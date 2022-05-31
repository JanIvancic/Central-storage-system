namespace CentralStorageSystem
{
    partial class FrmEquipmentList
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
            this.dgvEquipmentList = new System.Windows.Forms.DataGridView();
            this.txtSearchbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddEquipment = new System.Windows.Forms.Button();
            this.btnEditEquipment = new System.Windows.Forms.Button();
            this.btnDeleteEquipment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipmentList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEquipmentList
            // 
            this.dgvEquipmentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipmentList.Location = new System.Drawing.Point(41, 109);
            this.dgvEquipmentList.Name = "dgvEquipmentList";
            this.dgvEquipmentList.RowHeadersWidth = 82;
            this.dgvEquipmentList.RowTemplate.Height = 33;
            this.dgvEquipmentList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEquipmentList.Size = new System.Drawing.Size(2071, 535);
            this.dgvEquipmentList.TabIndex = 0;
            this.dgvEquipmentList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEquipmentList_CellClick);
            // 
            // txtSearchbox
            // 
            this.txtSearchbox.Location = new System.Drawing.Point(1873, 57);
            this.txtSearchbox.Name = "txtSearchbox";
            this.txtSearchbox.Size = new System.Drawing.Size(239, 31);
            this.txtSearchbox.TabIndex = 1;
            this.txtSearchbox.TextChanged += new System.EventHandler(this.txtSearchbox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1868, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pretrazivanje";
            // 
            // btnAddEquipment
            // 
            this.btnAddEquipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEquipment.Location = new System.Drawing.Point(41, 661);
            this.btnAddEquipment.Name = "btnAddEquipment";
            this.btnAddEquipment.Size = new System.Drawing.Size(300, 72);
            this.btnAddEquipment.TabIndex = 3;
            this.btnAddEquipment.Text = "Unos nove opreme";
            this.btnAddEquipment.UseVisualStyleBackColor = true;
            this.btnAddEquipment.Click += new System.EventHandler(this.btnAddEquipment_Click);
            // 
            // btnEditEquipment
            // 
            this.btnEditEquipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditEquipment.Location = new System.Drawing.Point(379, 661);
            this.btnEditEquipment.Name = "btnEditEquipment";
            this.btnEditEquipment.Size = new System.Drawing.Size(228, 72);
            this.btnEditEquipment.TabIndex = 4;
            this.btnEditEquipment.Text = "Izmjeni unos";
            this.btnEditEquipment.UseVisualStyleBackColor = true;
            this.btnEditEquipment.Visible = false;
            this.btnEditEquipment.Click += new System.EventHandler(this.btnEditEquipment_Click);
            // 
            // btnDeleteEquipment
            // 
            this.btnDeleteEquipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteEquipment.Location = new System.Drawing.Point(641, 661);
            this.btnDeleteEquipment.Name = "btnDeleteEquipment";
            this.btnDeleteEquipment.Size = new System.Drawing.Size(228, 72);
            this.btnDeleteEquipment.TabIndex = 5;
            this.btnDeleteEquipment.Text = "Obrisi unos";
            this.btnDeleteEquipment.UseVisualStyleBackColor = true;
            this.btnDeleteEquipment.Visible = false;
            this.btnDeleteEquipment.Click += new System.EventHandler(this.btnDeleteEquipment_Click);
            // 
            // FrmEquipmentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2148, 763);
            this.Controls.Add(this.btnDeleteEquipment);
            this.Controls.Add(this.btnEditEquipment);
            this.Controls.Add(this.btnAddEquipment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchbox);
            this.Controls.Add(this.dgvEquipmentList);
            this.Name = "FrmEquipmentList";
            this.Text = "Central Storage System | Popis opreme";
            this.Load += new System.EventHandler(this.FrmEquipmentList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipmentList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEquipmentList;
        private System.Windows.Forms.TextBox txtSearchbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddEquipment;
        private System.Windows.Forms.Button btnEditEquipment;
        private System.Windows.Forms.Button btnDeleteEquipment;
    }
}