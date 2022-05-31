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
    public partial class FrmNewEquipment : Form
    {
        public FrmNewEquipment()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FrmNewEquipment_Load(object sender, EventArgs e)
        {
            List<Employee> allEmployees = EmployeeRepo.GetAllEmployees();
            allEmployees.ForEach(employee =>
            {
                cboOrderer.Items.Add(employee);
            });

            List<FundingSource> fundingSources = FundingSourceRepo.GetAllFundingSources();
            fundingSources.ForEach(source =>
            {
                cboFundingSource.Items.Add(source.Name);
            });
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
            string sqlInsert = "INSERT INTO PopisOpreme" +
                "(Naziv, Narucitelj, IzvorFinanciranja, Vrsta, Opis, VrijemePrimitka, Zaprimio, NazivProjekta)" +
                $"VALUES ('{equipmentName}', '{ordererName}', '{fundingSource}', '{equipmentType}', '{desc}', '{time}', '{storedBy}', '{projectName}')";

            DB.OpenConnection();
            DB.ExecuteCommand(sqlInsert);
            DB.CloseConnection();

            // Dodavanje u DataGridView
            FrmEquipmentList.UpdateDgv();

            Close();
        }

        private void txtEquipmentName_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtEquipmentName, "");
        }

        private void txtEqupmentType_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtEqupmentType, "");
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtDescription, "");
        }

        private void cboOrderer_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(cboOrderer, "");
        }

        private void cboFundingSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(cboFundingSource, "");
        }
    }
}
