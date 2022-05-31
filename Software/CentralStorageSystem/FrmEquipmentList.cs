using CentralStorageSystem.Models;
using CentralStorageSystem.Repos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentralStorageSystem
{
    public partial class FrmEquipmentList : Form
    {
        public static DataGridView dgvEquipment;

        public FrmEquipmentList()
        {
            InitializeComponent();
            dgvEquipment = dgvEquipmentList;
        }

        public static void UpdateDgv()
        {
            var allEquipment = EquipmentRepo.GetAllEquipment();
            dgvEquipment.DataSource = allEquipment;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmEquipmentList_Load(object sender, EventArgs e)
        {
            List<Equipment> allEqupment = EquipmentRepo.GetAllEquipment();

            dgvEquipment.DataSource = allEqupment;
        }

        private void btnAddEquipment_Click(object sender, EventArgs e)
        {
            FrmNewEquipment frmNewEquipment = new FrmNewEquipment();
            frmNewEquipment.ShowDialog();
        }

        private void dgvEquipmentList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var rowSelected = dgvEquipment.SelectedRows[0];

            if (rowSelected.Cells["StoredBy"].Value.ToString() == FrmLogin.OnlineEmployee.ToString())
            {
                btnEditEquipment.Visible = true;
                btnDeleteEquipment.Visible = true;
            } else
            {
                btnEditEquipment.Visible = false;
                btnDeleteEquipment.Visible = false;
            }
        }

        private void btnEditEquipment_Click(object sender, EventArgs e)
        {
            var rowSelected = dgvEquipment.SelectedRows[0];

            FrmEditEquipment frmEditEquipment = new FrmEditEquipment(rowSelected);
            frmEditEquipment.ShowDialog();
        }

        private void btnDeleteEquipment_Click(object sender, EventArgs e)
        {
            var rowSelected = dgvEquipment.SelectedRows[0];

            int IdToDelete = int.Parse(rowSelected.Cells["Id"].Value.ToString());

            string sql = $"DELETE FROM PopisOpreme WHERE Id = {IdToDelete}";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();

            var updatedEquipment = EquipmentRepo.GetAllEquipment();
            dgvEquipment.DataSource = updatedEquipment;
        }

        private void txtSearchbox_TextChanged(object sender, EventArgs e)
        {

            var foundEquipment = EquipmentRepo.GetEquipmentByName(txtSearchbox.Text);
            dgvEquipment.DataSource = foundEquipment;
        }
    }
}
