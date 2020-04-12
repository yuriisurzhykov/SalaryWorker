namespace SalaryWorker.Forms
{
    partial class DeletingEmployee
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
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Passport = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Birthday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Profession = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.State = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Employment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.amount = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.основноеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.доабвитьСотрудникаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.начислениеЗарплатыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьРасчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.связьСРазработчикомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.подключениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сменитьПодключениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьПодключениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Passport,
            this.Birthday,
            this.Profession,
            this.State,
            this.Employment});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 97);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(776, 297);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "ID";
            this.Id.Width = 94;
            // 
            // Passport
            // 
            this.Passport.Text = "Passport";
            this.Passport.Width = 128;
            // 
            // Birthday
            // 
            this.Birthday.Text = "День рождения";
            this.Birthday.Width = 103;
            // 
            // Profession
            // 
            this.Profession.Text = "Профессия";
            this.Profession.Width = 150;
            // 
            // State
            // 
            this.State.Text = "Отдел";
            this.State.Width = 154;
            // 
            // Employment
            // 
            this.Employment.Text = "Дата трудоустройства";
            this.Employment.Width = 142;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 397);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выбрано:";
            // 
            // amount
            // 
            this.amount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.amount.AutoSize = true;
            this.amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amount.Location = new System.Drawing.Point(98, 397);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(18, 20);
            this.amount.TabIndex = 2;
            this.amount.Text = "0";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(713, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(214, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Найти";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Поиск по паспорту";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(13, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 23);
            this.textBox1.TabIndex = 10;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.основноеToolStripMenuItem,
            this.помощьToolStripMenuItem,
            this.подключениеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // основноеToolStripMenuItem
            // 
            this.основноеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.доабвитьСотрудникаToolStripMenuItem,
            this.начислениеЗарплатыToolStripMenuItem,
            this.создатьРасчетToolStripMenuItem,
            this.выйтиToolStripMenuItem});
            this.основноеToolStripMenuItem.Name = "основноеToolStripMenuItem";
            this.основноеToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.основноеToolStripMenuItem.Text = "Основное";
            // 
            // доабвитьСотрудникаToolStripMenuItem
            // 
            this.доабвитьСотрудникаToolStripMenuItem.Name = "доабвитьСотрудникаToolStripMenuItem";
            this.доабвитьСотрудникаToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.доабвитьСотрудникаToolStripMenuItem.Text = "Доабвить сотрудника";
            // 
            // начислениеЗарплатыToolStripMenuItem
            // 
            this.начислениеЗарплатыToolStripMenuItem.Name = "начислениеЗарплатыToolStripMenuItem";
            this.начислениеЗарплатыToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.начислениеЗарплатыToolStripMenuItem.Text = "Начисление зарплаты";
            // 
            // создатьРасчетToolStripMenuItem
            // 
            this.создатьРасчетToolStripMenuItem.Name = "создатьРасчетToolStripMenuItem";
            this.создатьРасчетToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.создатьРасчетToolStripMenuItem.Text = "Создать расчет";
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.выйтиToolStripMenuItem.Text = "Выйти";
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.связьСРазработчикомToolStripMenuItem});
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // связьСРазработчикомToolStripMenuItem
            // 
            this.связьСРазработчикомToolStripMenuItem.Name = "связьСРазработчикомToolStripMenuItem";
            this.связьСРазработчикомToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.связьСРазработчикомToolStripMenuItem.Text = "Связь с разработчиком";
            // 
            // подключениеToolStripMenuItem
            // 
            this.подключениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сменитьПодключениеToolStripMenuItem,
            this.закрытьПодключениеToolStripMenuItem});
            this.подключениеToolStripMenuItem.Name = "подключениеToolStripMenuItem";
            this.подключениеToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.подключениеToolStripMenuItem.Text = "Подключение";
            // 
            // сменитьПодключениеToolStripMenuItem
            // 
            this.сменитьПодключениеToolStripMenuItem.Name = "сменитьПодключениеToolStripMenuItem";
            this.сменитьПодключениеToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.сменитьПодключениеToolStripMenuItem.Text = "Сменить подключение";
            // 
            // закрытьПодключениеToolStripMenuItem
            // 
            this.закрытьПодключениеToolStripMenuItem.Name = "закрытьПодключениеToolStripMenuItem";
            this.закрытьПодключениеToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.закрытьПодключениеToolStripMenuItem.Text = "Закрыть подключение";
            // 
            // DeletingEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Name = "DeletingEmployee";
            this.Text = "Удаление сотрудника";
            this.Load += new System.EventHandler(this.DeletingEmployee_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label amount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Passport;
        private System.Windows.Forms.ColumnHeader Birthday;
        private System.Windows.Forms.ColumnHeader Profession;
        private System.Windows.Forms.ColumnHeader State;
        private System.Windows.Forms.ColumnHeader Employment;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem основноеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem доабвитьСотрудникаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem начислениеЗарплатыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьРасчетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem связьСРазработчикомToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem подключениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сменитьПодключениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьПодключениеToolStripMenuItem;
    }
}