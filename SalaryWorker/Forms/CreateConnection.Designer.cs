namespace SalaryWorker
{
    partial class CreateConnection
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
            this.server_box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.user_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.enter = new System.Windows.Forms.Button();
            this.db_name = new System.Windows.Forms.TextBox();
            this.password_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // server_box
            // 
            this.server_box.Font = new System.Drawing.Font("Book Antiqua", 14.25F);
            this.server_box.Location = new System.Drawing.Point(50, 59);
            this.server_box.Name = "server_box";
            this.server_box.Size = new System.Drawing.Size(251, 31);
            this.server_box.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(96, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Введите адрес сервера:";
            // 
            // user_name
            // 
            this.user_name.Font = new System.Drawing.Font("Book Antiqua", 14.25F);
            this.user_name.Location = new System.Drawing.Point(50, 136);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(251, 31);
            this.user_name.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(73, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Введите имя пользователя БД:";
            // 
            // enter
            // 
            this.enter.Font = new System.Drawing.Font("Book Antiqua", 14.25F);
            this.enter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.enter.Location = new System.Drawing.Point(109, 383);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(151, 45);
            this.enter.TabIndex = 13;
            this.enter.Text = "Сохранить";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // db_name
            // 
            this.db_name.Font = new System.Drawing.Font("Book Antiqua", 14.25F);
            this.db_name.Location = new System.Drawing.Point(50, 307);
            this.db_name.Name = "db_name";
            this.db_name.Size = new System.Drawing.Size(251, 31);
            this.db_name.TabIndex = 12;
            // 
            // password_box
            // 
            this.password_box.Font = new System.Drawing.Font("Book Antiqua", 14.25F);
            this.password_box.Location = new System.Drawing.Point(50, 221);
            this.password_box.Name = "password_box";
            this.password_box.Size = new System.Drawing.Size(251, 31);
            this.password_box.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(73, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Введите название базы данных:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(67, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Введите пароль пользователя БД:";
            // 
            // CreateConnection
            // 
            this.AcceptButton = this.enter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 467);
            this.Controls.Add(this.server_box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.user_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.db_name);
            this.Controls.Add(this.password_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateConnection";
            this.Text = "CreateConnection";
            this.Load += new System.EventHandler(this.CreateConnection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox server_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox user_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.TextBox db_name;
        private System.Windows.Forms.TextBox password_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}