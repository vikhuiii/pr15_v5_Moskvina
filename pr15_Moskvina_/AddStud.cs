using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace pr15_Moskvina_
{
    public partial class AddStud : Form
    {
        public Student Stud { get; private set; }
        private readonly List<Student> _existingStudents;

        public AddStud(List<Student> existingStudents)
        {
            InitializeComponent();
            _existingStudents = existingStudents;

            txtFirtsName.KeyPress += TxtFirtsName_KeyPress;
            txtLastName.KeyPress += TxtLastName_KeyPress;
            txtPhone.KeyPress += TxtPhone_KeyPress;
        }

        private void TxtFirtsName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string firstName = txtFirtsName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string phone = txtPhone.Text.Trim();

            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) || string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("Все поля должны быть заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_existingStudents != null && _existingStudents.Any(s =>
                s.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase) &&
                s.LastName.Equals(lastName, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Такой студент уже существует в списке!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Stud = new Student
            {
                LastName = lastName,
                FirstName = firstName,
                BirthDate = dateBirth.Value,
                PhoneNum = phone
            };

             this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}