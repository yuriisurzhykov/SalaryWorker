namespace SalaryWorker.Forms
{
    partial class GeneralStatement
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.month_comboBox = new System.Windows.Forms.ComboBox();
            this.year_comboBox = new System.Windows.Forms.ComboBox();
            this.generate = new System.Windows.Forms.Button();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.passport = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.department = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Profession = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pays = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.passport,
            this.department,
            this.Profession,
            this.pays});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 83);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(776, 355);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // month_comboBox
            // 
            this.month_comboBox.FormattingEnabled = true;
            this.month_comboBox.Items.AddRange(new object[] {
            "Январь",
            "Февраль",
            "Март",
            "Апрель",
            "Май",
            "Июнь",
            "Август",
            "Сентябрь",
            "Октябрь",
            "Ноябрь",
            "Декабрь"});
            this.month_comboBox.Location = new System.Drawing.Point(165, 23);
            this.month_comboBox.Name = "month_comboBox";
            this.month_comboBox.Size = new System.Drawing.Size(130, 21);
            this.month_comboBox.TabIndex = 2;
            this.month_comboBox.Text = "Месяц";
            this.month_comboBox.SelectedIndexChanged += new System.EventHandler(this.Month_comboBox_SelectedIndexChanged);
            // 
            // year_comboBox
            // 
            this.year_comboBox.FormattingEnabled = true;
            this.year_comboBox.Location = new System.Drawing.Point(361, 23);
            this.year_comboBox.Name = "year_comboBox";
            this.year_comboBox.Size = new System.Drawing.Size(130, 21);
            this.year_comboBox.TabIndex = 3;
            this.year_comboBox.Text = "Год";
            this.year_comboBox.SelectedIndexChanged += new System.EventHandler(this.Year_comboBox_SelectedIndexChanged);
            // 
            // generate
            // 
            this.generate.Location = new System.Drawing.Point(539, 23);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(142, 23);
            this.generate.TabIndex = 4;
            this.generate.Text = "Получить отчет";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // id
            // 
            this.id.Text = "ID";
            // 
            // passport
            // 
            this.passport.Text = "Паспорт";
            this.passport.Width = 98;
            // 
            // department
            // 
            this.department.Text = "Отдел";
            this.department.Width = 242;
            // 
            // Profession
            // 
            this.Profession.Text = "Профессия";
            this.Profession.Width = 229;
            // 
            // pays
            // 
            this.pays.Text = "Выплата";
            this.pays.Width = 140;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "< назад";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // GeneralStatement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.year_comboBox);
            this.Controls.Add(this.month_comboBox);
            this.Controls.Add(this.listView1);
            this.Name = "GeneralStatement";
            this.Text = "GeneralStatement";
            this.Load += new System.EventHandler(this.GeneralStatement_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ComboBox month_comboBox;
        private System.Windows.Forms.ComboBox year_comboBox;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader passport;
        private System.Windows.Forms.ColumnHeader department;
        private System.Windows.Forms.ColumnHeader Profession;
        private System.Windows.Forms.ColumnHeader pays;
        private System.Windows.Forms.Button button1;
    }
}