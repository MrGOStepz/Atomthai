namespace AtomThai
{
    partial class StuffRegister
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.gbDuck = new System.Windows.Forms.GroupBox();
            this.gbPrem = new System.Windows.Forms.GroupBox();
            this.rdbAdmin = new System.Windows.Forms.RadioButton();
            this.rdbManager = new System.Windows.Forms.RadioButton();
            this.rdbStuff = new System.Windows.Forms.RadioButton();
            this.gbDuck.SuspendLayout();
            this.gbPrem.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.AutoEllipsis = true;
            this.btnSubmit.Location = new System.Drawing.Point(0, 261);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(28, 22);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(51, 20);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Name";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(103, 22);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 26);
            this.txtName.TabIndex = 2;
            // 
            // gbDuck
            // 
            this.gbDuck.Controls.Add(this.gbPrem);
            this.gbDuck.Controls.Add(this.lbName);
            this.gbDuck.Controls.Add(this.btnSubmit);
            this.gbDuck.Controls.Add(this.txtName);
            this.gbDuck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDuck.Location = new System.Drawing.Point(0, 0);
            this.gbDuck.Name = "gbDuck";
            this.gbDuck.Size = new System.Drawing.Size(405, 313);
            this.gbDuck.TabIndex = 3;
            this.gbDuck.TabStop = false;
            // 
            // gbPrem
            // 
            this.gbPrem.Controls.Add(this.rdbStuff);
            this.gbPrem.Controls.Add(this.rdbManager);
            this.gbPrem.Controls.Add(this.rdbAdmin);
            this.gbPrem.Location = new System.Drawing.Point(103, 85);
            this.gbPrem.Name = "gbPrem";
            this.gbPrem.Size = new System.Drawing.Size(200, 150);
            this.gbPrem.TabIndex = 3;
            this.gbPrem.TabStop = false;
            this.gbPrem.Text = "Premission";
            // 
            // rdbAdmin
            // 
            this.rdbAdmin.AutoSize = true;
            this.rdbAdmin.Location = new System.Drawing.Point(7, 26);
            this.rdbAdmin.Name = "rdbAdmin";
            this.rdbAdmin.Size = new System.Drawing.Size(79, 24);
            this.rdbAdmin.TabIndex = 0;
            this.rdbAdmin.TabStop = true;
            this.rdbAdmin.Text = "Admin";
            this.rdbAdmin.UseVisualStyleBackColor = true;
            // 
            // rdbManager
            // 
            this.rdbManager.AutoSize = true;
            this.rdbManager.Location = new System.Drawing.Point(7, 56);
            this.rdbManager.Name = "rdbManager";
            this.rdbManager.Size = new System.Drawing.Size(97, 24);
            this.rdbManager.TabIndex = 1;
            this.rdbManager.TabStop = true;
            this.rdbManager.Text = "Manager";
            this.rdbManager.UseVisualStyleBackColor = true;
            // 
            // rdbStuff
            // 
            this.rdbStuff.AutoSize = true;
            this.rdbStuff.Location = new System.Drawing.Point(7, 86);
            this.rdbStuff.Name = "rdbStuff";
            this.rdbStuff.Size = new System.Drawing.Size(69, 24);
            this.rdbStuff.TabIndex = 2;
            this.rdbStuff.TabStop = true;
            this.rdbStuff.Text = "Stuff";
            this.rdbStuff.UseVisualStyleBackColor = true;
            // 
            // StuffRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 313);
            this.Controls.Add(this.gbDuck);
            this.Name = "StuffRegister";
            this.Text = "StuffRegister";
            this.gbDuck.ResumeLayout(false);
            this.gbDuck.PerformLayout();
            this.gbPrem.ResumeLayout(false);
            this.gbPrem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox gbDuck;
        private System.Windows.Forms.GroupBox gbPrem;
        private System.Windows.Forms.RadioButton rdbStuff;
        private System.Windows.Forms.RadioButton rdbManager;
        private System.Windows.Forms.RadioButton rdbAdmin;
    }
}