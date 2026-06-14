using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr15_Moskvina_
{
    public partial class AddStud : Form
    {
        public Student Stud { get; private set; }
        public AddStud()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (txtFirtsName.Text == "" || txtLastName.Text == "" || txtPhone.Text == "")
            {
                MessageBox.Show("Не все поля заполнены");
                return;
            }
            Stud = new Student
            {
                LastName = txtLastName.Text,
                FirstName = txtFirtsName.Text,
                BirthDate = dateBirth.Value,
                PhoneNum = txtPhone.Text
            };
        }
    }
}
