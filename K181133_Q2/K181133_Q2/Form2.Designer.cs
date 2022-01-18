
namespace K181133_Q2
{
    partial class frm_VDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.NIC_label = new System.Windows.Forms.Label();
            this.nic_input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Gcid_tb = new System.Windows.Forms.TextBox();
            this.Gsec_cb = new System.Windows.Forms.ComboBox();
            this.GeneralSecretary_tb = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.VPcid_tb = new System.Windows.Forms.TextBox();
            this.VPres_cb = new System.Windows.Forms.ComboBox();
            this.VicePresident_tb = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Pcid_tb = new System.Windows.Forms.TextBox();
            this.Pres_cb = new System.Windows.Forms.ComboBox();
            this.President_tb = new System.Windows.Forms.TextBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.sid_label = new System.Windows.Forms.Label();
            this.sid_tb = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Brown;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(426, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "On-Campus Elections";
            // 
            // NIC_label
            // 
            this.NIC_label.AutoSize = true;
            this.NIC_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NIC_label.Location = new System.Drawing.Point(70, 177);
            this.NIC_label.Name = "NIC_label";
            this.NIC_label.Size = new System.Drawing.Size(70, 16);
            this.NIC_label.TabIndex = 5;
            this.NIC_label.Text = "Enter NIC: ";
            // 
            // nic_input
            // 
            this.nic_input.Location = new System.Drawing.Point(183, 176);
            this.nic_input.Name = "nic_input";
            this.nic_input.Size = new System.Drawing.Size(153, 20);
            this.nic_input.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(426, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter Details To Vote";
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(12, 15);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(70, 34);
            this.back_btn.TabIndex = 12;
            this.back_btn.Text = "<----";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Candidate Details :";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel3.Controls.Add(this.Gcid_tb);
            this.panel3.Controls.Add(this.Gsec_cb);
            this.panel3.Controls.Add(this.GeneralSecretary_tb);
            this.panel3.Location = new System.Drawing.Point(626, 307);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 192);
            this.panel3.TabIndex = 21;
            // 
            // Gcid_tb
            // 
            this.Gcid_tb.Enabled = false;
            this.Gcid_tb.Location = new System.Drawing.Point(54, 73);
            this.Gcid_tb.Name = "Gcid_tb";
            this.Gcid_tb.Size = new System.Drawing.Size(100, 20);
            this.Gcid_tb.TabIndex = 25;
            // 
            // Gsec_cb
            // 
            this.Gsec_cb.FormattingEnabled = true;
            this.Gsec_cb.Location = new System.Drawing.Point(42, 145);
            this.Gsec_cb.Name = "Gsec_cb";
            this.Gsec_cb.Size = new System.Drawing.Size(121, 21);
            this.Gsec_cb.TabIndex = 9;
            // 
            // GeneralSecretary_tb
            // 
            this.GeneralSecretary_tb.Enabled = false;
            this.GeneralSecretary_tb.Location = new System.Drawing.Point(54, 13);
            this.GeneralSecretary_tb.Name = "GeneralSecretary_tb";
            this.GeneralSecretary_tb.Size = new System.Drawing.Size(100, 20);
            this.GeneralSecretary_tb.TabIndex = 2;
            this.GeneralSecretary_tb.Text = "General Secretary";
            this.GeneralSecretary_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.VPcid_tb);
            this.panel2.Controls.Add(this.VPres_cb);
            this.panel2.Controls.Add(this.VicePresident_tb);
            this.panel2.Location = new System.Drawing.Point(374, 307);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 192);
            this.panel2.TabIndex = 20;
            // 
            // VPcid_tb
            // 
            this.VPcid_tb.Enabled = false;
            this.VPcid_tb.Location = new System.Drawing.Point(50, 73);
            this.VPcid_tb.Name = "VPcid_tb";
            this.VPcid_tb.Size = new System.Drawing.Size(100, 20);
            this.VPcid_tb.TabIndex = 25;
            // 
            // VPres_cb
            // 
            this.VPres_cb.FormattingEnabled = true;
            this.VPres_cb.Location = new System.Drawing.Point(41, 145);
            this.VPres_cb.Name = "VPres_cb";
            this.VPres_cb.Size = new System.Drawing.Size(121, 21);
            this.VPres_cb.TabIndex = 8;
            // 
            // VicePresident_tb
            // 
            this.VicePresident_tb.Enabled = false;
            this.VicePresident_tb.Location = new System.Drawing.Point(50, 13);
            this.VicePresident_tb.Name = "VicePresident_tb";
            this.VicePresident_tb.Size = new System.Drawing.Size(100, 20);
            this.VicePresident_tb.TabIndex = 2;
            this.VicePresident_tb.Text = "Vice President";
            this.VicePresident_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.Pcid_tb);
            this.panel1.Controls.Add(this.Pres_cb);
            this.panel1.Controls.Add(this.President_tb);
            this.panel1.Location = new System.Drawing.Point(110, 307);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 192);
            this.panel1.TabIndex = 19;
            // 
            // Pcid_tb
            // 
            this.Pcid_tb.Enabled = false;
            this.Pcid_tb.Location = new System.Drawing.Point(46, 73);
            this.Pcid_tb.Name = "Pcid_tb";
            this.Pcid_tb.Size = new System.Drawing.Size(100, 20);
            this.Pcid_tb.TabIndex = 24;
            // 
            // Pres_cb
            // 
            this.Pres_cb.FormattingEnabled = true;
            this.Pres_cb.Location = new System.Drawing.Point(46, 145);
            this.Pres_cb.Name = "Pres_cb";
            this.Pres_cb.Size = new System.Drawing.Size(121, 21);
            this.Pres_cb.TabIndex = 7;
            // 
            // President_tb
            // 
            this.President_tb.Enabled = false;
            this.President_tb.Location = new System.Drawing.Point(46, 13);
            this.President_tb.Name = "President_tb";
            this.President_tb.Size = new System.Drawing.Size(100, 20);
            this.President_tb.TabIndex = 2;
            this.President_tb.Text = "President";
            this.President_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(886, 550);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(89, 37);
            this.btn_Submit.TabIndex = 23;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // sid_label
            // 
            this.sid_label.AutoSize = true;
            this.sid_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sid_label.Location = new System.Drawing.Point(70, 135);
            this.sid_label.Name = "sid_label";
            this.sid_label.Size = new System.Drawing.Size(68, 16);
            this.sid_label.TabIndex = 25;
            this.sid_label.Text = "Station ID:";
            // 
            // sid_tb
            // 
            this.sid_tb.Enabled = false;
            this.sid_tb.Location = new System.Drawing.Point(183, 131);
            this.sid_tb.Name = "sid_tb";
            this.sid_tb.Size = new System.Drawing.Size(153, 20);
            this.sid_tb.TabIndex = 26;
            // 
            // frm_VDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 615);
            this.Controls.Add(this.sid_tb);
            this.Controls.Add(this.sid_label);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nic_input);
            this.Controls.Add(this.NIC_label);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frm_VDetails";
            this.Text = "Voter Details";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NIC_label;
        private System.Windows.Forms.TextBox nic_input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox Gsec_cb;
        private System.Windows.Forms.TextBox GeneralSecretary_tb;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox VPres_cb;
        private System.Windows.Forms.TextBox VicePresident_tb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox Pres_cb;
        private System.Windows.Forms.TextBox President_tb;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.TextBox Gcid_tb;
        private System.Windows.Forms.TextBox VPcid_tb;
        private System.Windows.Forms.TextBox Pcid_tb;
        private System.Windows.Forms.Label sid_label;
        private System.Windows.Forms.TextBox sid_tb;
    }
}