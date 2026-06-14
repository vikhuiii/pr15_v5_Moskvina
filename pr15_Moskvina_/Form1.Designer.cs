namespace pr15_Moskvina_
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panelBttns = new System.Windows.Forms.Panel();
            this.Count = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.Sort = new System.Windows.Forms.ComboBox();
            this.panelBttns.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(0, 79);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(604, 340);
            this.listBox1.TabIndex = 0;
            // 
            // panelBttns
            // 
            this.panelBttns.Controls.Add(this.Sort);
            this.panelBttns.Controls.Add(this.btnShowAll);
            this.panelBttns.Controls.Add(this.textBox1);
            this.panelBttns.Controls.Add(this.Count);
            this.panelBttns.Controls.Add(this.btnSearch);
            this.panelBttns.Controls.Add(this.btnRemove);
            this.panelBttns.Controls.Add(this.btnAdd);
            this.panelBttns.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBttns.Location = new System.Drawing.Point(0, 0);
            this.panelBttns.Name = "panelBttns";
            this.panelBttns.Size = new System.Drawing.Size(604, 80);
            this.panelBttns.TabIndex = 1;
            // 
            // Count
            // 
            this.Count.AutoSize = true;
            this.Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Count.Location = new System.Drawing.Point(3, 60);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(66, 16);
            this.Count.TabIndex = 5;
            this.Count.Text = "Всего: 0";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(255, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(154, 30);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Поиск по фамилии";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(129, 19);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(120, 30);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Удалить";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(3, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 30);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Добавить студента";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(255, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(73, 20);
            this.textBox1.TabIndex = 6;
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(334, 53);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(75, 23);
            this.btnShowAll.TabIndex = 7;
            this.btnShowAll.Text = "Очистить";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // Sort
            // 
            this.Sort.FormattingEnabled = true;
            this.Sort.Location = new System.Drawing.Point(415, 25);
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(120, 21);
            this.Sort.TabIndex = 8;
            this.Sort.Text = "Сортировка";
            this.Sort.SelectedIndexChanged += new System.EventHandler(this.Sort_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 411);
            this.Controls.Add(this.panelBttns);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Студенты";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelBttns.ResumeLayout(false);
            this.panelBttns.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panelBttns;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label Count;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.ComboBox Sort;
    }
}

