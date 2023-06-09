namespace MyApp.WinForm
{
    partial class Main
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
            label1 = new System.Windows.Forms.Label();
            lstUsers = new System.Windows.Forms.ListView();
            Id = new System.Windows.Forms.ColumnHeader();
            Forename = new System.Windows.Forms.ColumnHeader();
            Surname = new System.Windows.Forms.ColumnHeader();
            IsActive = new System.Windows.Forms.ColumnHeader();
            label2 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            btnAllUsers = new System.Windows.Forms.Button();
            btnNonActiveUsers = new System.Windows.Forms.Button();
            btnActiveUsers = new System.Windows.Forms.Button();
            panel2 = new System.Windows.Forms.Panel();
            btnView = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            btnEdit = new System.Windows.Forms.Button();
            btnAdd = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            DateOfBirth = new System.Windows.Forms.ColumnHeader();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(17, 16);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(88, 25);
            label1.TabIndex = 0;
            label1.Text = "User List";
            // 
            // lstUsers
            // 
            lstUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { Id, Forename, Surname, IsActive, DateOfBirth });
            lstUsers.Location = new System.Drawing.Point(22, 50);
            lstUsers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            lstUsers.Name = "lstUsers";
            lstUsers.Size = new System.Drawing.Size(706, 438);
            lstUsers.TabIndex = 2;
            lstUsers.UseCompatibleStateImageBehavior = false;
            lstUsers.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            Id.Text = "Id";
            Id.Width = 162;
            // 
            // Forename
            // 
            Forename.Text = "Forename";
            Forename.Width = 412;
            // 
            // Surname
            // 
            Surname.Text = "Surname";
            Surname.Width = 456;
            // 
            // IsActive
            // 
            IsActive.Text = "Is Active";
            IsActive.Width = 164;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(848, 16);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(64, 25);
            label2.TabIndex = 3;
            label2.Text = "Filters";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnAllUsers);
            panel1.Controls.Add(btnNonActiveUsers);
            panel1.Controls.Add(btnActiveUsers);
            panel1.Location = new System.Drawing.Point(769, 50);
            panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(245, 150);
            panel1.TabIndex = 4;
            // 
            // btnAllUsers
            // 
            btnAllUsers.Location = new System.Drawing.Point(18, 16);
            btnAllUsers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            btnAllUsers.Name = "btnAllUsers";
            btnAllUsers.Size = new System.Drawing.Size(209, 31);
            btnAllUsers.TabIndex = 2;
            btnAllUsers.Text = "All Users";
            btnAllUsers.UseVisualStyleBackColor = true;
            btnAllUsers.Click += btnAllUsers_Click;
            // 
            // btnNonActiveUsers
            // 
            btnNonActiveUsers.Location = new System.Drawing.Point(18, 106);
            btnNonActiveUsers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            btnNonActiveUsers.Name = "btnNonActiveUsers";
            btnNonActiveUsers.Size = new System.Drawing.Size(209, 31);
            btnNonActiveUsers.TabIndex = 1;
            btnNonActiveUsers.Text = "Non Active";
            btnNonActiveUsers.UseVisualStyleBackColor = true;
            btnNonActiveUsers.Click += btnNonActiveUsers_Click;
            // 
            // btnActiveUsers
            // 
            btnActiveUsers.Location = new System.Drawing.Point(18, 59);
            btnActiveUsers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            btnActiveUsers.Name = "btnActiveUsers";
            btnActiveUsers.Size = new System.Drawing.Size(209, 31);
            btnActiveUsers.TabIndex = 0;
            btnActiveUsers.Text = "Active Users";
            btnActiveUsers.UseVisualStyleBackColor = true;
            btnActiveUsers.Click += btnActiveUsers_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnView);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnEdit);
            panel2.Controls.Add(btnAdd);
            panel2.Location = new System.Drawing.Point(769, 263);
            panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(245, 224);
            panel2.TabIndex = 6;
            // 
            // btnView
            // 
            btnView.Location = new System.Drawing.Point(16, 24);
            btnView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            btnView.Name = "btnView";
            btnView.Size = new System.Drawing.Size(209, 31);
            btnView.TabIndex = 3;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(18, 169);
            btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(209, 31);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new System.Drawing.Point(16, 121);
            btnEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new System.Drawing.Size(209, 31);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(18, 73);
            btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(209, 31);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(848, 228);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(77, 25);
            label3.TabIndex = 5;
            label3.Text = "Actions";
            // 
            // DateOfBirth
            // 
            DateOfBirth.Text = "Date Of Birth";
            DateOfBirth.Width = 456;
            // 
            // Main
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1035, 508);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstUsers);
            Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            Name = "Main";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lstUsers;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Forename;
        private System.Windows.Forms.ColumnHeader Surname;
        private System.Windows.Forms.ColumnHeader IsActive;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnActiveUsers;
        private System.Windows.Forms.Button btnNonActiveUsers;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAllUsers;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.ColumnHeader DateOfBirth;
    }
}

