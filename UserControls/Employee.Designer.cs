namespace JahovaManagment.UserControls
{
    partial class Employee
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.EmplolyeeName = new System.Windows.Forms.Label();
            this.EmployeeId = new System.Windows.Forms.Label();
            this.EmployeeStartDate = new System.Windows.Forms.Label();
            this.IsActive = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(536, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 139);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // EmplolyeeName
            // 
            this.EmplolyeeName.AutoSize = true;
            this.EmplolyeeName.Location = new System.Drawing.Point(13, 6);
            this.EmplolyeeName.Name = "EmplolyeeName";
            this.EmplolyeeName.Size = new System.Drawing.Size(35, 13);
            this.EmplolyeeName.TabIndex = 1;
            this.EmplolyeeName.Text = "Name";
            // 
            // EmployeeId
            // 
            this.EmployeeId.AutoSize = true;
            this.EmployeeId.Location = new System.Drawing.Point(13, 30);
            this.EmployeeId.Name = "EmployeeId";
            this.EmployeeId.Size = new System.Drawing.Size(35, 13);
            this.EmployeeId.TabIndex = 2;
            this.EmployeeId.Text = "label2";
            // 
            // EmployeeStartDate
            // 
            this.EmployeeStartDate.AutoSize = true;
            this.EmployeeStartDate.Location = new System.Drawing.Point(13, 54);
            this.EmployeeStartDate.Name = "EmployeeStartDate";
            this.EmployeeStartDate.Size = new System.Drawing.Size(35, 13);
            this.EmployeeStartDate.TabIndex = 3;
            this.EmployeeStartDate.Text = "label3";
            // 
            // IsActive
            // 
            this.IsActive.AutoSize = true;
            this.IsActive.Location = new System.Drawing.Point(13, 81);
            this.IsActive.Name = "IsActive";
            this.IsActive.Size = new System.Drawing.Size(35, 13);
            this.IsActive.TabIndex = 4;
            this.IsActive.Text = "label4";
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.IsActive);
            this.Controls.Add(this.EmployeeStartDate);
            this.Controls.Add(this.EmployeeId);
            this.Controls.Add(this.EmplolyeeName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Employee";
            this.Size = new System.Drawing.Size(679, 148);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label EmplolyeeName;
        private System.Windows.Forms.Label EmployeeId;
        private System.Windows.Forms.Label EmployeeStartDate;
        private System.Windows.Forms.Label IsActive;
    }
}
