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
            this.label6 = new System.Windows.Forms.Label();
            this.cmbProducts = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.spnMaterials = new System.Windows.Forms.NumericUpDown();
            this.cmbMaterial = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.spnMaterialsExtra = new System.Windows.Forms.NumericUpDown();
            this.cmbMaterialsExtra = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.spnQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StepNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnMaterials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnMaterialsExtra)).BeginInit();
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
            this.cmbJobs.SelectedIndexChanged += new System.EventHandler(this.cmbJobs_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "TotalQuantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 98);
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
            this.redDescribe.Location = new System.Drawing.Point(189, 98);
            this.redDescribe.Name = "redDescribe";
            this.redDescribe.Size = new System.Drawing.Size(369, 35);
            this.redDescribe.TabIndex = 39;
            this.redDescribe.Text = "";
            // 
            // spnQuantity
            // 
            this.spnQuantity.Location = new System.Drawing.Point(189, 67);
            this.spnQuantity.Name = "spnQuantity";
            this.spnQuantity.Size = new System.Drawing.Size(369, 20);
            this.spnQuantity.TabIndex = 40;
            // 
            // IsntFirstStep
            // 
            this.IsntFirstStep.AutoSize = true;
            this.IsntFirstStep.Location = new System.Drawing.Point(189, 269);
            this.IsntFirstStep.Name = "IsntFirstStep";
            this.IsntFirstStep.Size = new System.Drawing.Size(102, 17);
            this.IsntFirstStep.TabIndex = 41;
            this.IsntFirstStep.Text = "HasPreRequisit ";
            this.IsntFirstStep.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Previous Task";
            // 
            // cmbTasks
            // 
            this.cmbTasks.FormattingEnabled = true;
            this.cmbTasks.Location = new System.Drawing.Point(189, 291);
            this.cmbTasks.Name = "cmbTasks";
            this.cmbTasks.Size = new System.Drawing.Size(369, 21);
            this.cmbTasks.TabIndex = 44;
            // 
            // StepNumber
            // 
            this.StepNumber.Location = new System.Drawing.Point(189, 318);
            this.StepNumber.Name = "StepNumber";
            this.StepNumber.Size = new System.Drawing.Size(369, 20);
            this.StepNumber.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Step Number";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(33, 377);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(525, 88);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Select Product";
            // 
            // cmbProducts
            // 
            this.cmbProducts.FormattingEnabled = true;
            this.cmbProducts.Location = new System.Drawing.Point(189, 44);
            this.cmbProducts.Name = "cmbProducts";
            this.cmbProducts.Size = new System.Drawing.Size(369, 21);
            this.cmbProducts.TabIndex = 51;
            this.cmbProducts.SelectedIndexChanged += new System.EventHandler(this.cmbProducts_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 55;
            this.label7.Text = "Quantity";
            // 
            // spnMaterials
            // 
            this.spnMaterials.Location = new System.Drawing.Point(189, 166);
            this.spnMaterials.Name = "spnMaterials";
            this.spnMaterials.Size = new System.Drawing.Size(369, 20);
            this.spnMaterials.TabIndex = 54;
            // 
            // cmbMaterial
            // 
            this.cmbMaterial.FormattingEnabled = true;
            this.cmbMaterial.Location = new System.Drawing.Point(189, 139);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(369, 21);
            this.cmbMaterial.TabIndex = 53;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 52;
            this.label8.Text = "Material Required";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 221);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 59;
            this.label9.Text = "Quantity";
            // 
            // spnMaterialsExtra
            // 
            this.spnMaterialsExtra.Location = new System.Drawing.Point(189, 224);
            this.spnMaterialsExtra.Name = "spnMaterialsExtra";
            this.spnMaterialsExtra.Size = new System.Drawing.Size(369, 20);
            this.spnMaterialsExtra.TabIndex = 58;
            // 
            // cmbMaterialsExtra
            // 
            this.cmbMaterialsExtra.FormattingEnabled = true;
            this.cmbMaterialsExtra.Location = new System.Drawing.Point(189, 197);
            this.cmbMaterialsExtra.Name = "cmbMaterialsExtra";
            this.cmbMaterialsExtra.Size = new System.Drawing.Size(369, 21);
            this.cmbMaterialsExtra.TabIndex = 57;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 197);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 56;
            this.label10.Text = "Material Required";
            // 
            // AddTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(609, 568);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.spnMaterialsExtra);
            this.Controls.Add(this.cmbMaterialsExtra);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.spnMaterials);
            this.Controls.Add(this.cmbMaterial);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbProducts);
            this.Controls.Add(this.label6);
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
            ((System.ComponentModel.ISupportInitialize)(this.spnMaterials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnMaterialsExtra)).EndInit();
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbProducts;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown spnMaterials;
        private System.Windows.Forms.ComboBox cmbMaterial;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown spnMaterialsExtra;
        private System.Windows.Forms.ComboBox cmbMaterialsExtra;
        private System.Windows.Forms.Label label10;
    }
}