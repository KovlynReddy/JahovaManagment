namespace JahovaManagment.UserControls
{
    partial class PlanATask
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
            this.cmbTask = new System.Windows.Forms.ComboBox();
            this.ChooseTask = new System.Windows.Forms.Label();
            this.Confirm = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cmbTask
            // 
            this.cmbTask.FormattingEnabled = true;
            this.cmbTask.Location = new System.Drawing.Point(193, 19);
            this.cmbTask.Name = "cmbTask";
            this.cmbTask.Size = new System.Drawing.Size(478, 21);
            this.cmbTask.TabIndex = 3;
            // 
            // ChooseTask
            // 
            this.ChooseTask.AutoSize = true;
            this.ChooseTask.Location = new System.Drawing.Point(27, 27);
            this.ChooseTask.Name = "ChooseTask";
            this.ChooseTask.Size = new System.Drawing.Size(70, 13);
            this.ChooseTask.TabIndex = 4;
            this.ChooseTask.Text = "Choose Task";
            // 
            // Confirm
            // 
            this.Confirm.AutoSize = true;
            this.Confirm.Location = new System.Drawing.Point(610, 46);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(61, 17);
            this.Confirm.TabIndex = 7;
            this.Confirm.Text = "Confirm";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.CheckedChanged += new System.EventHandler(this.Confirm_CheckedChanged);
            // 
            // PlanATask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.ChooseTask);
            this.Controls.Add(this.cmbTask);
            this.Name = "PlanATask";
            this.Size = new System.Drawing.Size(740, 76);
            this.Load += new System.EventHandler(this.PlanATask_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTask;
        private System.Windows.Forms.Label ChooseTask;
        private System.Windows.Forms.CheckBox Confirm;
    }
}
