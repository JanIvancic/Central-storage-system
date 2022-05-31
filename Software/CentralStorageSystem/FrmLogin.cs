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
    public partial class FrmLogin : Form
    {
        public static Employee OnlineEmployee { get; set; }

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Potrebno je unesti korisnicko ime!");
                return;
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Potrebno je unesti lozinku!");
                return;
            }

            Console.WriteLine(txtUsername.Text);
            Employee employee = EmployeeRepo.GetEmployeeByUsername(txtUsername.Text.ToString());
            if (employee == null || txtPassword.Text != employee.Password)
            {
                MessageBox.Show("Pogresni podaci za prijavu! Pokusajte ponovno!");
                return;
            }

            OnlineEmployee = employee;
            FrmEquipmentList frmEquipmentList = new FrmEquipmentList();
            Hide();
            frmEquipmentList.ShowDialog();
            Close();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
