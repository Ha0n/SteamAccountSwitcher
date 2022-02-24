namespace SteamAccountSwitcher
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.login_Btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Steam_GB = new System.Windows.Forms.GroupBox();
            this.rememberPwd_checkbox = new System.Windows.Forms.CheckBox();
            this.lastlogintime_lb = new System.Windows.Forms.Label();
            this.pername_lb = new System.Windows.Forms.Label();
            this.accname_lb = new System.Windows.Forms.Label();
            this.steam64id_lb = new System.Windows.Forms.Label();
            this.saccrefresh_Btn = new System.Windows.Forms.Button();
            this.account_CB = new System.Windows.Forms.ComboBox();
            this.copy64id_Btn = new System.Windows.Forms.Button();
            this.Steam_GB.SuspendLayout();
            this.SuspendLayout();
            // 
            // login_Btn
            // 
            this.login_Btn.Location = new System.Drawing.Point(215, 15);
            this.login_Btn.Name = "login_Btn";
            this.login_Btn.Size = new System.Drawing.Size(80, 25);
            this.login_Btn.TabIndex = 2;
            this.login_Btn.Text = "登录";
            this.login_Btn.UseVisualStyleBackColor = true;
            this.login_Btn.Click += new System.EventHandler(this.login_Btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Steam64位ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "用户名:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "资料名:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "上次登录时间:";
            // 
            // Steam_GB
            // 
            this.Steam_GB.Controls.Add(this.rememberPwd_checkbox);
            this.Steam_GB.Controls.Add(this.lastlogintime_lb);
            this.Steam_GB.Controls.Add(this.pername_lb);
            this.Steam_GB.Controls.Add(this.accname_lb);
            this.Steam_GB.Controls.Add(this.steam64id_lb);
            this.Steam_GB.Controls.Add(this.saccrefresh_Btn);
            this.Steam_GB.Controls.Add(this.account_CB);
            this.Steam_GB.Controls.Add(this.copy64id_Btn);
            this.Steam_GB.Controls.Add(this.label1);
            this.Steam_GB.Controls.Add(this.label2);
            this.Steam_GB.Controls.Add(this.label3);
            this.Steam_GB.Controls.Add(this.login_Btn);
            this.Steam_GB.Controls.Add(this.label4);
            this.Steam_GB.Location = new System.Drawing.Point(12, 11);
            this.Steam_GB.Name = "Steam_GB";
            this.Steam_GB.Size = new System.Drawing.Size(300, 130);
            this.Steam_GB.TabIndex = 11;
            this.Steam_GB.TabStop = false;
            this.Steam_GB.Text = "Steam账号快速切换";
            // 
            // rememberPwd_checkbox
            // 
            this.rememberPwd_checkbox.AutoSize = true;
            this.rememberPwd_checkbox.Enabled = false;
            this.rememberPwd_checkbox.Location = new System.Drawing.Point(217, 81);
            this.rememberPwd_checkbox.Name = "rememberPwd_checkbox";
            this.rememberPwd_checkbox.Size = new System.Drawing.Size(78, 19);
            this.rememberPwd_checkbox.TabIndex = 0;
            this.rememberPwd_checkbox.TabStop = false;
            this.rememberPwd_checkbox.Text = "记住密码";
            this.rememberPwd_checkbox.UseVisualStyleBackColor = true;
            // 
            // lastlogintime_lb
            // 
            this.lastlogintime_lb.AutoSize = true;
            this.lastlogintime_lb.Location = new System.Drawing.Point(95, 110);
            this.lastlogintime_lb.Name = "lastlogintime_lb";
            this.lastlogintime_lb.Size = new System.Drawing.Size(83, 15);
            this.lastlogintime_lb.TabIndex = 0;
            this.lastlogintime_lb.Text = "2000/1/1 00:00";
            // 
            // pername_lb
            // 
            this.pername_lb.AutoSize = true;
            this.pername_lb.Location = new System.Drawing.Point(60, 90);
            this.pername_lb.Name = "pername_lb";
            this.pername_lb.Size = new System.Drawing.Size(81, 15);
            this.pername_lb.TabIndex = 0;
            this.pername_lb.Text = "PersonaName";
            // 
            // accname_lb
            // 
            this.accname_lb.AutoSize = true;
            this.accname_lb.Location = new System.Drawing.Point(60, 70);
            this.accname_lb.Name = "accname_lb";
            this.accname_lb.Size = new System.Drawing.Size(84, 15);
            this.accname_lb.TabIndex = 0;
            this.accname_lb.Text = "AccountName";
            // 
            // steam64id_lb
            // 
            this.steam64id_lb.AutoSize = true;
            this.steam64id_lb.Location = new System.Drawing.Point(85, 50);
            this.steam64id_lb.Name = "steam64id_lb";
            this.steam64id_lb.Size = new System.Drawing.Size(109, 15);
            this.steam64id_lb.TabIndex = 0;
            this.steam64id_lb.Text = "00000000000000000";
            // 
            // saccrefresh_Btn
            // 
            this.saccrefresh_Btn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saccrefresh_Btn.Location = new System.Drawing.Point(235, 100);
            this.saccrefresh_Btn.Name = "saccrefresh_Btn";
            this.saccrefresh_Btn.Size = new System.Drawing.Size(43, 25);
            this.saccrefresh_Btn.TabIndex = 4;
            this.saccrefresh_Btn.Text = "刷新";
            this.saccrefresh_Btn.UseVisualStyleBackColor = true;
            this.saccrefresh_Btn.Click += new System.EventHandler(this.saccrefresh_Btn_Click);
            // 
            // account_CB
            // 
            this.account_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.account_CB.DropDownWidth = 165;
            this.account_CB.FormattingEnabled = true;
            this.account_CB.Location = new System.Drawing.Point(10, 17);
            this.account_CB.Name = "account_CB";
            this.account_CB.Size = new System.Drawing.Size(163, 23);
            this.account_CB.TabIndex = 1;
            this.account_CB.SelectedIndexChanged += new System.EventHandler(this.account_CB_SelectedIndexChanged);
            // 
            // copy64id_Btn
            // 
            this.copy64id_Btn.Location = new System.Drawing.Point(215, 50);
            this.copy64id_Btn.Name = "copy64id_Btn";
            this.copy64id_Btn.Size = new System.Drawing.Size(80, 25);
            this.copy64id_Btn.TabIndex = 3;
            this.copy64id_Btn.Text = "复制64位ID";
            this.copy64id_Btn.UseVisualStyleBackColor = true;
            this.copy64id_Btn.Click += new System.EventHandler(this.copy64id_Btn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 141);
            this.Controls.Add(this.Steam_GB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Steam账号切换";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Steam_GB.ResumeLayout(false);
            this.Steam_GB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Button login_Btn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox Steam_GB;
        private Button copy64id_Btn;
        private ComboBox account_CB;
        private Button saccrefresh_Btn;
        private Label lastlogintime_lb;
        private Label pername_lb;
        private Label accname_lb;
        private Label steam64id_lb;
        private CheckBox rememberPwd_checkbox;
    }
}