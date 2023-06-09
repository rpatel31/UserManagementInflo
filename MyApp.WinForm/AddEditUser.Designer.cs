namespace MyApp.WinForm
{
    partial class AddEditUser
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
            components = new System.ComponentModel.Container();
            lblForename = new System.Windows.Forms.Label();
            txtBoxForename = new System.Windows.Forms.TextBox();
            txtBoxSurname = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            lblDob = new System.Windows.Forms.Label();
            dtpDOB = new System.Windows.Forms.DateTimePicker();
            label2 = new System.Windows.Forms.Label();
            btnSave = new System.Windows.Forms.Button();
            btnClose = new System.Windows.Forms.Button();
            cbActive = new System.Windows.Forms.ComboBox();
            errorProviderForename = new System.Windows.Forms.ErrorProvider(components);
            errorProviderSurname = new System.Windows.Forms.ErrorProvider(components);
            lblCreateEditTitle = new System.Windows.Forms.Label();
            errorProviderActiveDropdown = new System.Windows.Forms.ErrorProvider(components);
            errorProviderDOB = new System.Windows.Forms.ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProviderForename).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderSurname).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderActiveDropdown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderDOB).BeginInit();
            SuspendLayout();
            // 
            // lblForename
            // 
            lblForename.AutoSize = true;
            lblForename.Location = new System.Drawing.Point(37, 58);
            lblForename.Name = "lblForename";
            lblForename.Size = new System.Drawing.Size(60, 15);
            lblForename.TabIndex = 0;
            lblForename.Text = "Forename";
            // 
            // txtBoxForename
            // 
            txtBoxForename.Location = new System.Drawing.Point(153, 50);
            txtBoxForename.Name = "txtBoxForename";
            txtBoxForename.Size = new System.Drawing.Size(246, 23);
            txtBoxForename.TabIndex = 1;
            txtBoxForename.Validating += txtBoxForename_Validating;
            // 
            // txtBoxSurname
            // 
            txtBoxSurname.Location = new System.Drawing.Point(153, 103);
            txtBoxSurname.Name = "txtBoxSurname";
            txtBoxSurname.Size = new System.Drawing.Size(246, 23);
            txtBoxSurname.TabIndex = 3;
            txtBoxSurname.Validating += txtBoxSurname_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(37, 106);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(54, 15);
            label1.TabIndex = 2;
            label1.Text = "Surname";
            // 
            // lblDob
            // 
            lblDob.AutoSize = true;
            lblDob.Location = new System.Drawing.Point(37, 155);
            lblDob.Name = "lblDob";
            lblDob.Size = new System.Drawing.Size(73, 15);
            lblDob.TabIndex = 4;
            lblDob.Text = "Date of Birth";
            // 
            // dtpDOB
            // 
            dtpDOB.Location = new System.Drawing.Point(153, 155);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new System.Drawing.Size(200, 23);
            dtpDOB.TabIndex = 6;
            dtpDOB.Validating += dtpDOB_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(37, 227);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(40, 15);
            label2.TabIndex = 7;
            label2.Text = "Active";
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(37, 311);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(173, 56);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new System.Drawing.Point(308, 311);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(173, 56);
            btnClose.TabIndex = 10;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // cbActive
            // 
            cbActive.FormattingEnabled = true;
            cbActive.Items.AddRange(new object[] { "Active", "Deactivated" });
            cbActive.Location = new System.Drawing.Point(153, 219);
            cbActive.Name = "cbActive";
            cbActive.Size = new System.Drawing.Size(121, 23);
            cbActive.TabIndex = 11;
            cbActive.Validating += cbActive_Validating;
            // 
            // errorProviderForename
            // 
            errorProviderForename.ContainerControl = this;
            // 
            // errorProviderSurname
            // 
            errorProviderSurname.ContainerControl = this;
            // 
            // lblCreateEditTitle
            // 
            lblCreateEditTitle.AutoSize = true;
            lblCreateEditTitle.Location = new System.Drawing.Point(37, 9);
            lblCreateEditTitle.Name = "lblCreateEditTitle";
            lblCreateEditTitle.Size = new System.Drawing.Size(0, 15);
            lblCreateEditTitle.TabIndex = 12;
            // 
            // errorProviderActiveDropdown
            // 
            errorProviderActiveDropdown.ContainerControl = this;
            // 
            // errorProviderDOB
            // 
            errorProviderDOB.ContainerControl = this;
            // 
            // AddEditUser
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(521, 422);
            Controls.Add(lblCreateEditTitle);
            Controls.Add(cbActive);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(label2);
            Controls.Add(dtpDOB);
            Controls.Add(lblDob);
            Controls.Add(txtBoxSurname);
            Controls.Add(label1);
            Controls.Add(txtBoxForename);
            Controls.Add(lblForename);
            Name = "AddEditUser";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)errorProviderForename).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderSurname).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderActiveDropdown).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderDOB).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.TextBox txtBoxForename;
        private System.Windows.Forms.TextBox txtBoxSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cbActive;
        private System.Windows.Forms.ErrorProvider errorProviderForename;
        private System.Windows.Forms.ErrorProvider errorProviderSurname;
        private System.Windows.Forms.Label lblCreateEditTitle;
        private System.Windows.Forms.ErrorProvider errorProviderActiveDropdown;
        private System.Windows.Forms.ErrorProvider errorProviderDOB;
    }
}