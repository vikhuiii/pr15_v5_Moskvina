using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace pr15_Moskvina_
{
    public partial class Form1 : Form
    {
        private StudentGroup group;
        public Form1()
        {
            InitializeComponent();
        }
        private void UpdateStudList(List<Student> students)
        {
            listBox1.Items.Clear();
            if (students.Count == 0)
                listBox1.Items.Add("Нет студентов");
            else foreach (var student in students)
                    listBox1.Items.Add(student.ToString());
            Count.Text = $"Всего: {group.Count}";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var dialog = new AddStud(group.GetAllStuds());
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                group.AddStudent(dialog.Stud);
                UpdateStudList(group.GetAllStuds());
                MessageBox.Show("Студент успешно добавлен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (group.Count == 0)
            {
                MessageBox.Show("Нет студентов для удаления");
                return;
            }
            if (listBox1.SelectedIndex >= 0)
            {
                group.RemoveStudent(listBox1.SelectedIndex);
                UpdateStudList(group.GetAllStuds());
                MessageBox.Show("Студент удален");
            }
            else MessageBox.Show("Выберите студента для удаления");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (group.Count == 0)
            {
                MessageBox.Show("Нет студентов для поиска");
                return;
            }
            string search = textBox1.Text;
            if (search == "")
            {
                MessageBox.Show("Введите фамилию");
                return;
            }
            var searchRes = group.FindByLastName(search);
            if (searchRes.Count > 0)
            {
                UpdateStudList(searchRes);
            }
            else MessageBox.Show($"Студенты с фамилией '{search}' не найдены");
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            UpdateStudList(group.GetAllStuds());
        }

        private void Sort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                var searchRes = group.FindByLastName(textBox1.Text);
                var sortedRes = GetSorted(searchRes, Sort.SelectedIndex);
                UpdateStudList(sortedRes);
            }
            else UpdateStudList(GetSorted(group.GetAllStuds(), Sort.SelectedIndex));
        }
        private List<Student> GetSorted(List<Student> list, int index)
        {
            switch (index)
            {
                case 0:
                    return list;
                case 1: 
                    return group.SortByLastName(list);
                case 2: 
                    return group.SortByBirthDate(list);
                case 3: 
                    return group.SortByPhoneNum(list);
                default:
                    return list;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            group = new StudentGroup();
            Sort.Items.Add("Без сортировки");
            Sort.Items.Add("По фамилии");
            Sort.Items.Add("По дате рождения (сначала старше)");
            Sort.Items.Add("По номеру телефона");
        }
    }
}