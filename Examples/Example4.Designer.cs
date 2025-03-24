namespace CruzWinForms.Examples
{
    partial class Example4
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
            this.comboBoxCourses = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelYouSelected = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxCourses
            // 
            this.comboBoxCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCourses.FormattingEnabled = true;
            this.comboBoxCourses.Location = new System.Drawing.Point(12, 12);
            this.comboBoxCourses.Name = "comboBoxCourses";
            this.comboBoxCourses.Size = new System.Drawing.Size(100, 33);
            this.comboBoxCourses.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox1.Location = new System.Drawing.Point(17, 97);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(398, 26);
            this.textBox1.TabIndex = 1;
            // 
            // labelYouSelected
            // 
            this.labelYouSelected.AutoSize = true;
            this.labelYouSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelYouSelected.Location = new System.Drawing.Point(12, 68);
            this.labelYouSelected.Name = "labelYouSelected";
            this.labelYouSelected.Size = new System.Drawing.Size(70, 26);
            this.labelYouSelected.TabIndex = 2;
            this.labelYouSelected.Text = "label1";
            // 
            // Example4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 144);
            this.Controls.Add(this.labelYouSelected);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBoxCourses);
            this.Name = "Example4";
            this.Text = "Example4 ComboBox";
            this.Load += new System.EventHandler(this.Example4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCourses;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelYouSelected;
    }
}