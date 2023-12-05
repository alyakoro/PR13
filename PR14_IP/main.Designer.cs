namespace PR14_IP
{
    partial class main
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
            this.NAME = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.log = new System.Windows.Forms.Label();
            this.LOGIN = new System.Windows.Forms.TextBox();
            this.PAROL = new System.Windows.Forms.TextBox();
            this.EMAIL = new System.Windows.Forms.TextBox();
            this.prlo = new System.Windows.Forms.Label();
            this.emaill = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NAME
            // 
            this.NAME.Location = new System.Drawing.Point(66, 34);
            this.NAME.Name = "NAME";
            this.NAME.ReadOnly = true;
            this.NAME.Size = new System.Drawing.Size(177, 20);
            this.NAME.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Имя:";
            // 
            // log
            // 
            this.log.AutoSize = true;
            this.log.Location = new System.Drawing.Point(13, 63);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(41, 13);
            this.log.TabIndex = 2;
            this.log.Text = "Логин:";
            // 
            // LOGIN
            // 
            this.LOGIN.Location = new System.Drawing.Point(66, 59);
            this.LOGIN.Name = "LOGIN";
            this.LOGIN.ReadOnly = true;
            this.LOGIN.Size = new System.Drawing.Size(177, 20);
            this.LOGIN.TabIndex = 3;
            // 
            // PAROL
            // 
            this.PAROL.Location = new System.Drawing.Point(66, 85);
            this.PAROL.Name = "PAROL";
            this.PAROL.PasswordChar = '*';
            this.PAROL.ReadOnly = true;
            this.PAROL.Size = new System.Drawing.Size(177, 20);
            this.PAROL.TabIndex = 4;
            // 
            // EMAIL
            // 
            this.EMAIL.Location = new System.Drawing.Point(66, 111);
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.ReadOnly = true;
            this.EMAIL.Size = new System.Drawing.Size(177, 20);
            this.EMAIL.TabIndex = 5;
            // 
            // prlo
            // 
            this.prlo.AutoSize = true;
            this.prlo.Location = new System.Drawing.Point(12, 88);
            this.prlo.Name = "prlo";
            this.prlo.Size = new System.Drawing.Size(48, 13);
            this.prlo.TabIndex = 6;
            this.prlo.Text = "Пароль:";
            // 
            // emaill
            // 
            this.emaill.AutoSize = true;
            this.emaill.Location = new System.Drawing.Point(12, 114);
            this.emaill.Name = "emaill";
            this.emaill.Size = new System.Drawing.Size(38, 13);
            this.emaill.TabIndex = 7;
            this.emaill.Text = "E-mail:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Итоговые данные:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Зарегестрироваться";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 170);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.emaill);
            this.Controls.Add(this.prlo);
            this.Controls.Add(this.EMAIL);
            this.Controls.Add(this.PAROL);
            this.Controls.Add(this.LOGIN);
            this.Controls.Add(this.log);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NAME);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "main";
            this.Text = "INFO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NAME;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label log;
        private System.Windows.Forms.TextBox LOGIN;
        private System.Windows.Forms.TextBox PAROL;
        private System.Windows.Forms.TextBox EMAIL;
        private System.Windows.Forms.Label prlo;
        private System.Windows.Forms.Label emaill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

