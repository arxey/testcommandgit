namespace OOO_Fishing
{
    partial class Sign
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sign));
            this.PanelTop = new System.Windows.Forms.Panel();
            this.LabelFishing = new System.Windows.Forms.Label();
            this.FishingPicture = new System.Windows.Forms.PictureBox();
            this.PanelBottom = new System.Windows.Forms.Panel();
            this.ButtonSign = new System.Windows.Forms.Button();
            this.LabelLogin = new System.Windows.Forms.Label();
            this.LoginText = new System.Windows.Forms.TextBox();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.CaptchaPb = new System.Windows.Forms.PictureBox();
            this.CaptchaText = new System.Windows.Forms.TextBox();
            this.LabelWait = new System.Windows.Forms.Label();
            this.TimerFailSign = new System.Windows.Forms.Timer(this.components);
            this.PanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FishingPicture)).BeginInit();
            this.PanelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CaptchaPb)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.PanelTop.Controls.Add(this.LabelFishing);
            this.PanelTop.Controls.Add(this.FishingPicture);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(517, 100);
            this.PanelTop.TabIndex = 0;
            // 
            // LabelFishing
            // 
            this.LabelFishing.AutoSize = true;
            this.LabelFishing.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelFishing.Location = new System.Drawing.Point(176, 38);
            this.LabelFishing.Name = "LabelFishing";
            this.LabelFishing.Size = new System.Drawing.Size(155, 26);
            this.LabelFishing.TabIndex = 1;
            this.LabelFishing.Text = "ООО \"Рыбалка\"";
            // 
            // FishingPicture
            // 
            this.FishingPicture.Image = ((System.Drawing.Image)(resources.GetObject("FishingPicture.Image")));
            this.FishingPicture.Location = new System.Drawing.Point(3, 3);
            this.FishingPicture.Name = "FishingPicture";
            this.FishingPicture.Size = new System.Drawing.Size(100, 94);
            this.FishingPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FishingPicture.TabIndex = 0;
            this.FishingPicture.TabStop = false;
            // 
            // PanelBottom
            // 
            this.PanelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.PanelBottom.Controls.Add(this.ButtonSign);
            this.PanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelBottom.Location = new System.Drawing.Point(0, 350);
            this.PanelBottom.Name = "PanelBottom";
            this.PanelBottom.Size = new System.Drawing.Size(517, 100);
            this.PanelBottom.TabIndex = 1;
            // 
            // ButtonSign
            // 
            this.ButtonSign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(140)))), ((int)(((byte)(81)))));
            this.ButtonSign.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonSign.Location = new System.Drawing.Point(211, 33);
            this.ButtonSign.Name = "ButtonSign";
            this.ButtonSign.Size = new System.Drawing.Size(88, 33);
            this.ButtonSign.TabIndex = 0;
            this.ButtonSign.Text = "Войти";
            this.ButtonSign.UseVisualStyleBackColor = false;
            this.ButtonSign.Click += new System.EventHandler(this.ButtonSign_Click);
            // 
            // LabelLogin
            // 
            this.LabelLogin.AutoSize = true;
            this.LabelLogin.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelLogin.Location = new System.Drawing.Point(31, 144);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(147, 26);
            this.LabelLogin.TabIndex = 2;
            this.LabelLogin.Text = "Введите логин";
            // 
            // LoginText
            // 
            this.LoginText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.LoginText.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginText.Location = new System.Drawing.Point(193, 144);
            this.LoginText.Multiline = true;
            this.LoginText.Name = "LoginText";
            this.LoginText.Size = new System.Drawing.Size(115, 37);
            this.LoginText.TabIndex = 3;
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPassword.Location = new System.Drawing.Point(31, 205);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(156, 26);
            this.LabelPassword.TabIndex = 4;
            this.LabelPassword.Text = "Введите пароль";
            // 
            // PasswordText
            // 
            this.PasswordText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.PasswordText.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordText.Location = new System.Drawing.Point(193, 205);
            this.PasswordText.Multiline = true;
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(115, 37);
            this.PasswordText.TabIndex = 5;
            // 
            // CaptchaPb
            // 
            this.CaptchaPb.Location = new System.Drawing.Point(333, 144);
            this.CaptchaPb.Name = "CaptchaPb";
            this.CaptchaPb.Size = new System.Drawing.Size(100, 50);
            this.CaptchaPb.TabIndex = 6;
            this.CaptchaPb.TabStop = false;
            // 
            // CaptchaText
            // 
            this.CaptchaText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.CaptchaText.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CaptchaText.Location = new System.Drawing.Point(333, 219);
            this.CaptchaText.Multiline = true;
            this.CaptchaText.Name = "CaptchaText";
            this.CaptchaText.Size = new System.Drawing.Size(100, 38);
            this.CaptchaText.TabIndex = 7;
            this.CaptchaText.Visible = false;
            // 
            // LabelWait
            // 
            this.LabelWait.AutoSize = true;
            this.LabelWait.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelWait.Location = new System.Drawing.Point(221, 256);
            this.LabelWait.Name = "LabelWait";
            this.LabelWait.Size = new System.Drawing.Size(0, 26);
            this.LabelWait.TabIndex = 8;
            this.LabelWait.Visible = false;
            // 
            // TimerFailSign
            // 
            this.TimerFailSign.Tick += new System.EventHandler(this.TimerFailSign_Tick);
            // 
            // Sign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(517, 450);
            this.Controls.Add(this.LabelWait);
            this.Controls.Add(this.CaptchaText);
            this.Controls.Add(this.CaptchaPb);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.LoginText);
            this.Controls.Add(this.LabelLogin);
            this.Controls.Add(this.PanelBottom);
            this.Controls.Add(this.PanelTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sign";
            this.Text = "Авторизация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Sign_FormClosing);
            this.Load += new System.EventHandler(this.Sign_Load);
            this.PanelTop.ResumeLayout(false);
            this.PanelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FishingPicture)).EndInit();
            this.PanelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CaptchaPb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.Label LabelFishing;
        private System.Windows.Forms.PictureBox FishingPicture;
        private System.Windows.Forms.Panel PanelBottom;
        private System.Windows.Forms.Button ButtonSign;
        private System.Windows.Forms.Label LabelLogin;
        private System.Windows.Forms.TextBox LoginText;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.PictureBox CaptchaPb;
        private System.Windows.Forms.TextBox CaptchaText;
        private System.Windows.Forms.Label LabelWait;
        private System.Windows.Forms.Timer TimerFailSign;
    }
}

