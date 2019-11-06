namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.unitText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.numUpDown = new System.Windows.Forms.NumericUpDown();
            this.numAssignment = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.marksLabel = new System.Windows.Forms.Label();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.weightUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.weightUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.weightUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.weightUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.weightUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.GPAUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.errorMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weightUpDown5)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weightUpDown4)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weightUpDown3)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weightUpDown2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weightUpDown1)).BeginInit();
            this.tabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GPAUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // unitText
            // 
            this.unitText.BackColor = System.Drawing.SystemColors.Window;
            this.unitText.Location = new System.Drawing.Point(658, 22);
            this.unitText.Name = "unitText";
            this.unitText.Size = new System.Drawing.Size(100, 20);
            this.unitText.TabIndex = 1;
            this.unitText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKey);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(567, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Unit name";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(642, 411);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 3;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.UpdateTab);
            // 
            // numUpDown
            // 
            this.numUpDown.Location = new System.Drawing.Point(658, 65);
            this.numUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDown.Name = "numUpDown";
            this.numUpDown.ReadOnly = true;
            this.numUpDown.Size = new System.Drawing.Size(75, 20);
            this.numUpDown.TabIndex = 4;
            this.numUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDown.ValueChanged += new System.EventHandler(this.ChangeTabPages);
            // 
            // numAssignment
            // 
            this.numAssignment.AutoSize = true;
            this.numAssignment.Location = new System.Drawing.Point(567, 67);
            this.numAssignment.Name = "numAssignment";
            this.numAssignment.Size = new System.Drawing.Size(81, 13);
            this.numAssignment.TabIndex = 5;
            this.numAssignment.Text = "Number of units";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(553, 412);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.marksLabel);
            this.tabPage1.Controls.Add(this.checkBox5);
            this.tabPage1.Controls.Add(this.checkBox2);
            this.tabPage1.Controls.Add(this.checkBox4);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.checkBox3);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(553, 412);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // marksLabel
            // 
            this.marksLabel.AutoSize = true;
            this.marksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marksLabel.Location = new System.Drawing.Point(210, 263);
            this.marksLabel.Name = "marksLabel";
            this.marksLabel.Size = new System.Drawing.Size(156, 25);
            this.marksLabel.TabIndex = 27;
            this.marksLabel.Text = "Marks left: 85";
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(172, 180);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(15, 14);
            this.checkBox5.TabIndex = 26;
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.Click += new System.EventHandler(this.EnableAssignment);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(297, 37);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 24;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.Click += new System.EventHandler(this.EnableAssignment);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(297, 109);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(15, 14);
            this.checkBox4.TabIndex = 25;
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.Click += new System.EventHandler(this.EnableAssignment);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(14, 37);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 23;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Click += new System.EventHandler(this.EnableAssignment);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(14, 109);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 24;
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.Click += new System.EventHandler(this.EnableAssignment);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.weightUpDown5);
            this.groupBox5.Controls.Add(this.textBox5);
            this.groupBox5.Location = new System.Drawing.Point(193, 160);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(202, 49);
            this.groupBox5.TabIndex = 22;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Assignment 5";
            // 
            // weightUpDown5
            // 
            this.weightUpDown5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.weightUpDown5.Location = new System.Drawing.Point(6, 19);
            this.weightUpDown5.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.weightUpDown5.Name = "weightUpDown5";
            this.weightUpDown5.Size = new System.Drawing.Size(95, 20);
            this.weightUpDown5.TabIndex = 32;
            this.weightUpDown5.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Window;
            this.textBox5.Location = new System.Drawing.Point(107, 19);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(85, 20);
            this.textBox5.TabIndex = 7;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.weightUpDown4);
            this.groupBox4.Controls.Add(this.textBox4);
            this.groupBox4.Location = new System.Drawing.Point(318, 86);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(227, 49);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Assignment 4";
            // 
            // weightUpDown4
            // 
            this.weightUpDown4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.weightUpDown4.Location = new System.Drawing.Point(6, 21);
            this.weightUpDown4.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.weightUpDown4.Name = "weightUpDown4";
            this.weightUpDown4.Size = new System.Drawing.Size(95, 20);
            this.weightUpDown4.TabIndex = 31;
            this.weightUpDown4.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.weightUpDown4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RemoveSound);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Window;
            this.textBox4.Location = new System.Drawing.Point(136, 20);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(85, 20);
            this.textBox4.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.weightUpDown3);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Location = new System.Drawing.Point(39, 86);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(226, 49);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Assignment 3";
            // 
            // weightUpDown3
            // 
            this.weightUpDown3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.weightUpDown3.Location = new System.Drawing.Point(10, 21);
            this.weightUpDown3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.weightUpDown3.Name = "weightUpDown3";
            this.weightUpDown3.Size = new System.Drawing.Size(95, 20);
            this.weightUpDown3.TabIndex = 30;
            this.weightUpDown3.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.weightUpDown3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RemoveSound);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Window;
            this.textBox3.Location = new System.Drawing.Point(133, 20);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(85, 20);
            this.textBox3.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.weightUpDown2);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Location = new System.Drawing.Point(318, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 49);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Assignment 2";
            // 
            // weightUpDown2
            // 
            this.weightUpDown2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.weightUpDown2.Location = new System.Drawing.Point(6, 20);
            this.weightUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.weightUpDown2.Name = "weightUpDown2";
            this.weightUpDown2.Size = new System.Drawing.Size(95, 20);
            this.weightUpDown2.TabIndex = 29;
            this.weightUpDown2.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.weightUpDown2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RemoveSound);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Window;
            this.textBox2.Location = new System.Drawing.Point(133, 20);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(85, 20);
            this.textBox2.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.weightUpDown1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(39, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 49);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Assignment 1";
            // 
            // weightUpDown1
            // 
            this.weightUpDown1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.weightUpDown1.Location = new System.Drawing.Point(10, 20);
            this.weightUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.weightUpDown1.Name = "weightUpDown1";
            this.weightUpDown1.Size = new System.Drawing.Size(95, 20);
            this.weightUpDown1.TabIndex = 28;
            this.weightUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.weightUpDown1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RemoveSound);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(133, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(85, 20);
            this.textBox1.TabIndex = 7;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(561, 438);
            this.tabControl.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(567, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Goal GPA";
            // 
            // GPAUpDown1
            // 
            this.GPAUpDown1.Location = new System.Drawing.Point(658, 106);
            this.GPAUpDown1.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.GPAUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.GPAUpDown1.Name = "GPAUpDown1";
            this.GPAUpDown1.ReadOnly = true;
            this.GPAUpDown1.Size = new System.Drawing.Size(75, 20);
            this.GPAUpDown1.TabIndex = 6;
            this.GPAUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // errorMessage
            // 
            this.errorMessage.AutoSize = true;
            this.errorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessage.ForeColor = System.Drawing.Color.Red;
            this.errorMessage.Location = new System.Drawing.Point(583, 222);
            this.errorMessage.MaximumSize = new System.Drawing.Size(200, 150);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(134, 96);
            this.errorMessage.TabIndex = 8;
            this.errorMessage.Text = "Error Message\r\nTest\r\nTest\r\nTest\r\n";
            this.errorMessage.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.errorMessage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GPAUpDown1);
            this.Controls.Add(this.numAssignment);
            this.Controls.Add(this.numUpDown);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.unitText);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Grades Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weightUpDown5)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weightUpDown4)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weightUpDown3)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weightUpDown2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weightUpDown1)).EndInit();
            this.tabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GPAUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox unitText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submitButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.NumericUpDown numUpDown;
        private System.Windows.Forms.Label numAssignment;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown GPAUpDown1;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label marksLabel;
        private System.Windows.Forms.NumericUpDown weightUpDown1;
        private System.Windows.Forms.NumericUpDown weightUpDown4;
        private System.Windows.Forms.NumericUpDown weightUpDown3;
        private System.Windows.Forms.NumericUpDown weightUpDown2;
        private System.Windows.Forms.NumericUpDown weightUpDown5;
        private System.Windows.Forms.Label errorMessage;
    }
}

