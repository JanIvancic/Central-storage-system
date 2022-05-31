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
    public partial class FrmEditEquipment : Form
    {
        public DataGridViewRow equipmentRow;
        public FrmEditEquipment(DataGridViewRow row)
        {
            InitializeComponent();
            equipmentRow = row;
        }

        private string GetCell(string cellName)
        {
            return equipmentRow.Cells[cellName].Value.ToString();
        }

        private void FrmEditEquipment_Load(object sender, EventArgs e)
        {
            List<Employee> allEmployees = EmployeeRepo.GetAllEmployees();
            allEmployees.ForEach(employee =>
            {
                cboOrderer.Items.Add(employee.ToString());
            });

            List<FundingSource> fundingSources = FundingSourceRepo.GetAllFundingSources();
            fundingSources.ForEach(source =>
            {
                cboFundingSource.Items.Add(source.Name);
            });


            txtEquipmentName.Text = GetCell("Name");
            cboOrderer.SelectedIndex = cboOrderer.FindString(GetCell("Orderer"));
            cboFundingSource.SelectedIndex = cboFundingSource.FindString(GetCell("FundingSource"));
            txtEqupmentType.Text = GetCell("Type");
            txtDescription.Text = GetCell("Description");
            txtProjectName.Text = GetCell("ProjectName");
        }

        private void btnAddEquipment_Click(object sender, EventArgs e)
        {
            string equipmentName = txtEquipmentName.Text;
            string ordererName = cboOrderer.SelectedIndex > -1 ? cboOrderer.SelectedItem.ToString() : "";
            string fundingSource = cboFundingSource.SelectedIndex > -1 ? cboFundingSource.SelectedItem.ToString() : "";
            string equipmentType = txtEqupmentType.Text;
            string desc = txtDescription.Text;
            string time = DateTime.Now.ToString();
            string storedBy = FrmLogin.OnlineEmployee.ToString();
            string projectName = txtProjectName.Text == "" ? "Bez projekta" : txtProjectName.Text;

            bool inputsValid = true;


            if (equipmentName == "")
            {
                txtEquipmentName.Focus();
                errorProvider.SetError(txtEquipmentName, "Potrebno je unesti ime opreme!");
                inputsValid = false;
            }

            if (ordererName == "")
            {
                cboOrderer.Focus();
                errorProvider.SetError(cboOrderer, "Potrebno je odabrati naručitelja!");
                inputsValid = false;
            }

            if (fundingSource == "")
            {
                cboFundingSource.Focus();
                errorProvider.SetError(cboFundingSource, "Potrebno je odabrati izvor placanja!");
                inputsValid = false;
            }

            if (equipmentType == "")
            {
                txtEqupmentType.Focus();
                errorProvider.SetError(txtEqupmentType, "Potrebno je unesti vrstu opreme!");
                inputsValid = false;
            }

            if (desc == "")
            {
                txtDescription.Focus();
                errorProvider.SetError(txtDescription, "Potrebno je upisati opis!");
                inputsValid = false;
            }

            if (!inputsValid) return;


            // Dodavanje u bazu
            string sqlUpdate = $"UPDATE PopisOpreme SET " +
                $"Naziv = '{equipmentName}'," +
                $"Narucitelj = '{ordererName}'," +
                $"IzvorFinanciranja = '{fundingSource}'," +
                $"Vrsta = '{equipmentType}'," +
                $"Opis = '{desc}'," +
                $"NazivProjekta = '{projectName}' " +
                $"WHERE Id = {equipmentRow.Cells["Id"].Value}";
               

            DB.OpenConnection();
            DB.ExecuteCommand(sqlUpdate);
            DB.CloseConnection();

            // Dodavanje u DataGridView
            FrmEquipmentList.UpdateDgv();

            Close();
        }
    }
}
