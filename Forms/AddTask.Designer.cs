namespace JahovaManagment.Forms
{
    partial class AddTask
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
            this.AddATask = new System.Windows.Forms.Button();
            this.cmbJobs = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.redDescribe = new System.Windows.Forms.RichTextBox();
            this.spnQuantity = new System.Windows.Forms.NumericUpDown();
            this.IsntFirstStep = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTasks = new System.Windows.Forms.ComboBox();
            this.StepNumber = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AddPicture = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.spnQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StepNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddATask
            // 
            this.AddATask.Location = new System.Drawing.Point(499, 471);
            this.AddATask.Name = "AddATask";
            this.AddATask.Size = new System.Drawing.Size(75, 23);
            this.AddATask.TabIndex = 38;
            this.AddATask.Text = "Add Task";
            this.AddATask.UseVisualStyleBackColor = true;
            this.AddATask.Click += new System.EventHandler(this.AddATask_Click);
            // 
            // cmbJobs
            // 
            this.cmbJobs.FormattingEnabled = true;
            this.cmbJobs.Location = new System.Drawing.Point(189, 17);
            this.cmbJobs.Name = "cmbJobs";
            this.cmbJobs.Size = new System.Drawing.Size(369, 21);
            this.cmbJobs.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "TotalQuantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Describe Task";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Select Job";
            // 
            // redDescribe
            // 
            this.redDescribe.Location = new System.Drawing.Point(189, 76);
            this.redDescribe.Name = "redDescribe";
            this.redDescribe.Size = new System.Drawing.Size(369, 85);
            this.redDescribe.TabIndex = 39;
            this.redDescribe.Text = "";
            // 
            // spnQuantity
            // 
            this.spnQuantity.Location = new System.Drawing.Point(189, 45);
            this.spnQuantity.Name = "spnQuantity";
            this.spnQuantity.Size = new System.Drawing.Size(369, 20);
            this.spnQuantity.TabIndex = 40;
            // 
            // IsntFirstStep
            // 
            this.IsntFirstStep.AutoSize = true;
            this.IsntFirstStep.Location = new System.Drawing.Point(189, 198);
            this.IsntFirstStep.Name = "IsntFirstStep";
            this.IsntFirstStep.Size = new System.Drawing.Size(102, 17);
            this.IsntFirstStep.TabIndex = 41;
            this.IsntFirstStep.Text = "HasPreRequisit ";
            this.IsntFirstStep.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Previous Task";
            // 
            // cmbTasks
            // 
            this.cmbTasks.FormattingEnabled = true;
            this.cmbTasks.Location = new System.Drawing.Point(189, 221);
            this.cmbTasks.Name = "cmbTasks";
            this.cmbTasks.Size = new System.Drawing.Size(369, 21);
            this.cmbTasks.TabIndex = 44;
            // 
            // StepNumber
            // 
            this.StepNumber.Location = new System.Drawing.Point(189, 258);
            this.StepNumber.Name = "StepNumber";
            this.StepNumber.Size = new System.Drawing.Size(369, 20);
            this.StepNumber.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Step Number";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(33, 309);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 156);
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // AddPicture
            // 
            this.AddPicture.Location = new System.Drawing.Point(34, 471);
            this.AddPicture.Name = "AddPicture";
            this.AddPicture.Size = new System.Drawing.Size(92, 23);
            this.AddPicture.TabIndex = 47;
            this.AddPicture.Text = "Add Picture";
            this.AddPicture.UseVisualStyleBackColor = true;
            this.AddPicture.Click += new System.EventHandler(this.AddPicture_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(260, 471);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 49;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(609, 528);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AddPicture);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.StepNumber);
            this.Controls.Add(this.cmbTasks);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.IsntFirstStep);
            this.Controls.Add(this.spnQuantity);
            this.Controls.Add(this.redDescribe);
            this.Controls.Add(this.AddATask);
            this.Controls.Add(this.cmbJobs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddTask";
            this.Text = "AddTask";
            this.Load += new System.EventHandler(this.AddTask_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spnQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StepNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddATask;
        private System.Windows.Forms.ComboBox cmbJobs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox redDescribe;
        private System.Windows.Forms.NumericUpDown spnQuantity;
        private System.Windows.Forms.CheckBox IsntFirstStep;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTasks;
        private System.Windows.Forms.NumericUpDown StepNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button AddPicture;
        private System.Windows.Forms.Button button1;
    }
}