
namespace K181133_Q2
{
    partial class Frm_Login
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
            this.heading_label = new System.Windows.Forms.Label();
            this.Signin_label = new System.Windows.Forms.Label();
            this.uname_label = new System.Windows.Forms.Label();
            this.pw_label = new System.Windows.Forms.Label();
            this.uname_input = new System.Windows.Forms.TextBox();
            this.pw_input = new System.Windows.Forms.TextBox();
            this.submit_btn = new System.Windows.Forms.Button();
            this.navbar = new System.Windows.Forms.Panel();
            this.sid_label = new System.Windows.Forms.Label();
            this.sid_cb = new System.Windows.Forms.ComboBox();
            this.navbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // heading_label
            // 
            this.heading_label.AutoSize = true;
            this.heading_label.BackColor = System.Drawing.Color.Brown;
            this.heading_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heading_label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.heading_label.Location = new System.Drawing.Point(278, 17);
            this.heading_label.Name = "heading_label";
            this.heading_label.Size = new System.Drawing.Size(213, 24);
            this.heading_label.TabIndex = 0;
            this.heading_label.Text = "On-Campus Elections";
            // 
            // Signin_label
            // 
            this.Signin_label.AutoSize = true;
            this.Signin_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signin_label.Location = new System.Drawing.Point(352, 88);
            this.Signin_label.Name = "Signin_label";
            this.Signin_label.Size = new System.Drawing.Size(63, 16);
            this.Signin_label.TabIndex = 1;
            this.Signin_label.Text = "SIGN IN";
            // 
            // uname_label
            // 
            this.uname_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.uname_label.AutoSize = true;
            this.uname_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uname_label.Location = new System.Drawing.Point(232, 209);
            this.uname_label.Name = "uname_label";
            this.uname_label.Size = new System.Drawing.Size(83, 16);
            this.uname_label.TabIndex = 2;
            this.uname_label.Text = "User Name :";
            // 
            // pw_label
            // 
            this.pw_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pw_label.AutoSize = true;
            this.pw_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pw_label.Location = new System.Drawing.Point(241, 269);
            this.pw_label.Name = "pw_label";
            this.pw_label.Size = new System.Drawing.Size(74, 16);
            this.pw_label.TabIndex = 3;
            this.pw_label.Text = "Password :";
            this.pw_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // uname_input
            // 
            this.uname_input.Location = new System.Drawing.Point(343, 209);
            this.uname_input.Name = "uname_input";
            this.uname_input.Size = new System.Drawing.Size(149, 20);
            this.uname_input.TabIndex = 4;
            // 
            // pw_input
            // 
            this.pw_input.AccessibleName = "";
            this.pw_input.Location = new System.Drawing.Point(343, 265);
            this.pw_input.Name = "pw_input";
            this.pw_input.PasswordChar = '*';
            this.pw_input.Size = new System.Drawing.Size(149, 20);
            this.pw_input.TabIndex = 5;
            // 
            // submit_btn
            // 
            this.submit_btn.Location = new System.Drawing.Point(578, 387);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(84, 34);
            this.submit_btn.TabIndex = 6;
            this.submit_btn.Text = "Login";
            this.submit_btn.UseVisualStyleBackColor = true;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // navbar
            // 
            this.navbar.BackColor = System.Drawing.Color.LightGray;
            this.navbar.Controls.Add(this.heading_label);
            this.navbar.Controls.Add(this.Signin_label);
            this.navbar.Location = new System.Drawing.Point(1, 2);
            this.navbar.Name = "navbar";
            this.navbar.Size = new System.Drawing.Size(799, 138);
            this.navbar.TabIndex = 8;
            // 
            // sid_label
            // 
            this.sid_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.sid_label.AutoSize = true;
            this.sid_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sid_label.Location = new System.Drawing.Point(241, 326);
            this.sid_label.Name = "sid_label";
            this.sid_label.Size = new System.Drawing.Size(63, 16);
            this.sid_label.TabIndex = 9;
            this.sid_label.Text = "Station Id";
            this.sid_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // sid_cb
            // 
            this.sid_cb.AllowDrop = true;
            this.sid_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sid_cb.FormattingEnabled = true;
            this.sid_cb.Items.AddRange(new object[] {
            "210001",
            "210002"});
            this.sid_cb.Location = new System.Drawing.Point(343, 321);
            this.sid_cb.Name = "sid_cb";
            this.sid_cb.Size = new System.Drawing.Size(149, 21);
            this.sid_cb.TabIndex = 10;
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(801, 466);
            this.Controls.Add(this.sid_cb);
            this.Controls.Add(this.sid_label);
            this.Controls.Add(this.pw_input);
            this.Controls.Add(this.uname_input);
            this.Controls.Add(this.navbar);
            this.Controls.Add(this.submit_btn);
            this.Controls.Add(this.pw_label);
            this.Controls.Add(this.uname_label);
            this.MaximizeBox = false;
            this.Name = "Frm_Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.navbar.ResumeLayout(false);
            this.navbar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label heading_label;
        private System.Windows.Forms.Label Signin_label;
        private System.Windows.Forms.Label uname_label;
        private System.Windows.Forms.Label pw_label;
        private System.Windows.Forms.TextBox uname_input;
        private System.Windows.Forms.TextBox pw_input;
        private System.Windows.Forms.Button submit_btn;
        private System.Windows.Forms.Panel navbar;
        private System.Windows.Forms.Label sid_label;
        private System.Windows.Forms.ComboBox sid_cb;
    }
}

