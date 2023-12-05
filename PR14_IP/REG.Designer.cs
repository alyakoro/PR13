namespace PR14_IP
{
    partial class REG
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
            this.emaill = new System.Windows.Forms.Label();
            this.prlo = new System.Windows.Forms.Label();
            this.EMAIL = new System.Windows.Forms.TextBox();
            this.PAROL = new System.Windows.Forms.TextBox();
            this.log = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LOGIN = new System.Windows.Forms.TextBox();
            this.NAME = new System.Windows.Forms.TextBox();
            this.mm = new System.Windows.Forms.ComboBox();
            this.regg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // emaill
            // 
            this.emaill.AutoSize = true;
            this.emaill.Location = new System.Drawing.Point(14, 92);
            this.emaill.Name = "emaill";
            this.emaill.Size = new System.Drawing.Size(38, 13);
            this.emaill.TabIndex = 15;
            this.emaill.Text = "E-mail:";
            // 
            // prlo
            // 
            this.prlo.AutoSize = true;
            this.prlo.Location = new System.Drawing.Point(14, 66);
            this.prlo.Name = "prlo";
            this.prlo.Size = new System.Drawing.Size(48, 13);
            this.prlo.TabIndex = 14;
            this.prlo.Text = "Пароль:";
            // 
            // EMAIL
            // 
            this.EMAIL.Location = new System.Drawing.Point(68, 89);
            this.EMAIL.MaxLength = 30;
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.Size = new System.Drawing.Size(140, 20);
            this.EMAIL.TabIndex = 13;
            // 
            // PAROL
            // 
            this.PAROL.Location = new System.Drawing.Point(68, 63);
            this.PAROL.MaxLength = 30;
            this.PAROL.Name = "PAROL";
            this.PAROL.PasswordChar = '*';
            this.PAROL.Size = new System.Drawing.Size(230, 20);
            this.PAROL.TabIndex = 12;
            // 
            // log
            // 
            this.log.AutoSize = true;
            this.log.Location = new System.Drawing.Point(15, 41);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(41, 13);
            this.log.TabIndex = 10;
            this.log.Text = "Логин:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Имя:";
            // 
            // LOGIN
            // 
            this.LOGIN.Location = new System.Drawing.Point(68, 37);
            this.LOGIN.MaxLength = 10;
            this.LOGIN.Name = "LOGIN";
            this.LOGIN.Size = new System.Drawing.Size(230, 20);
            this.LOGIN.TabIndex = 11;
            // 
            // NAME
            // 
            this.NAME.Location = new System.Drawing.Point(68, 12);
            this.NAME.MaxLength = 30;
            this.NAME.Name = "NAME";
            this.NAME.Size = new System.Drawing.Size(230, 20);
            this.NAME.TabIndex = 8;
            // 
            // mm
            // 
            this.mm.FormattingEnabled = true;
            this.mm.Items.AddRange(new object[] {
            "@gmail.com",
            "@mail.ru",
            "@vk.com",
            "@rambler.ru"});
            this.mm.Location = new System.Drawing.Point(214, 88);
            this.mm.Name = "mm";
            this.mm.Size = new System.Drawing.Size(84, 21);
            this.mm.TabIndex = 16;
            // 
            // regg
            // 
            this.regg.Location = new System.Drawing.Point(17, 124);
            this.regg.Name = "regg";
            this.regg.Size = new System.Drawing.Size(281, 23);
            this.regg.TabIndex = 17;
            this.regg.Text = "Продолжить";
            this.regg.UseVisualStyleBackColor = true;
            this.regg.Click += new System.EventHandler(this.regg_Click);
            // 
            // REG
            // 
            this.AcceptButton = this.regg;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 161);
            this.Controls.Add(this.regg);
            this.Controls.Add(this.mm);
            this.Controls.Add(this.emaill);
            this.Controls.Add(this.prlo);
            this.Controls.Add(this.EMAIL);
            this.Controls.Add(this.PAROL);
            this.Controls.Add(this.LOGIN);
            this.Controls.Add(this.log);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NAME);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label emaill;
        private System.Windows.Forms.Label prlo;
        private System.Windows.Forms.TextBox EMAIL;
        private System.Windows.Forms.TextBox PAROL;
        private System.Windows.Forms.Label log;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LOGIN;
        private System.Windows.Forms.TextBox NAME;
        private System.Windows.Forms.ComboBox mmm;
        private System.Windows.Forms.Button regg;
        private System.Windows.Forms.ComboBox mm;
    }
}