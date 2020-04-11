namespace SalaryWorker
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.основныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.главноеМенюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сменитьПодключениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.связьСРазработчикомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accept = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.основныеToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(356, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // основныеToolStripMenuItem
            // 
            this.основныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.главноеМенюToolStripMenuItem,
            this.сменитьПодключениеToolStripMenuItem,
            this.выйтиToolStripMenuItem});
            this.основныеToolStripMenuItem.Name = "основныеToolStripMenuItem";
            this.основныеToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.основныеToolStripMenuItem.Text = "Основные";
            // 
            // главноеМенюToolStripMenuItem
            // 
            this.главноеМенюToolStripMenuItem.Name = "главноеМенюToolStripMenuItem";
            this.главноеМенюToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.главноеМенюToolStripMenuItem.Text = "Главное меню";
            // 
            // сменитьПодключениеToolStripMenuItem
            // 
            this.сменитьПодключениеToolStripMenuItem.Name = "сменитьПодключениеToolStripMenuItem";
            this.сменитьПодключениеToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.сменитьПодключениеToolStripMenuItem.Text = "Сменить подключение";
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
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
            // accept
            // 
            this.accept.Location = new System.Drawing.Point(124, 192);
            this.accept.Name = "accept";
            this.accept.Size = new System.Drawing.Size(97, 35);
            this.accept.TabIndex = 1;
            this.accept.Text = "Сохранить";
            this.accept.UseVisualStyleBackColor = true;
            this.accept.Click += new System.EventHandler(this.Accept_Click);
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(77, 118);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(199, 29);
            this.name.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(49, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите название профессии";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(356, 365);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.accept);
            this.tabPage1.Controls.Add(this.name);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(348, 339);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Добавление профессии";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(348, 339);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Добавление отдела";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(57, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Введите название отдела";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(71, 135);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 29);
            this.textBox1.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(8, 296);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 36);
            this.button2.TabIndex = 7;
            this.button2.Text = "< назад";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(8, 296);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(71, 36);
            this.button3.TabIndex = 8;
            this.button3.Text = "< назад";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AcceptButton = this.accept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 393);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Добавление простых данных";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem основныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem главноеМенюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сменитьПодключениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem связьСРазработчикомToolStripMenuItem;
        private System.Windows.Forms.Button accept;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}

