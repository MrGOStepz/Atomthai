namespace AtomThai
{
    partial class Login
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReg = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lbPW = new System.Windows.Forms.Label();
            this.txtPW = new System.Windows.Forms.TextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnReg);
            this.groupBox1.Controls.Add(this.btnLogin);
            this.groupBox1.Controls.Add(this.lbPW);
            this.groupBox1.Controls.Add(this.txtPW);
            this.groupBox1.Controls.Add(this.lbID);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(662, 524);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(143, 88);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(83, 28);
            this.btnReg.TabIndex = 5;
            this.btnReg.Text = "Register";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(35, 88);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 28);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lbPW
            // 
            this.lbPW.AutoSize = true;
            this.lbPW.Location = new System.Drawing.Point(4, 47);
            this.lbPW.Name = "lbPW";
            this.lbPW.Size = new System.Drawing.Size(78, 20);
            this.lbPW.TabIndex = 3;
            this.lbPW.Text = "Password";
            // 
            // txtPW
            // 
            this.txtPW.Location = new System.Drawing.Point(88, 44);
            this.txtPW.Name = "txtPW";
            this.txtPW.Size = new System.Drawing.Size(138, 26);
            this.txtPW.TabIndex = 2;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(4, 15);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(26, 20);
            this.lbID.TabIndex = 1;
            this.lbID.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(88, 12);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(138, 26);
            this.txtID.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 524);
            this.Controls.Add(this.groupBox1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbPW;
        private System.Windows.Forms.TextBox txtPW;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Button button1;
    }
}

