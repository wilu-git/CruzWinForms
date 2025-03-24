namespace CruzWinForms.Examples
{
    partial class Example2
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
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.textBoxInput1 = new System.Windows.Forms.TextBox();
            this.buttonClearText = new System.Windows.Forms.Button();
            this.buttonShowText = new System.Windows.Forms.Button();
            this.labelPlaceholder = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelInputVal1 = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxInput2 = new System.Windows.Forms.TextBox();
            this.labelInput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxResult
            // 
            this.textBoxResult.Enabled = false;
            this.textBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBoxResult.Location = new System.Drawing.Point(103, 336);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(583, 32);
            this.textBoxResult.TabIndex = 15;
            // 
            // textBoxInput1
            // 
            this.textBoxInput1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBoxInput1.Location = new System.Drawing.Point(289, 104);
            this.textBoxInput1.Name = "textBoxInput1";
            this.textBoxInput1.Size = new System.Drawing.Size(397, 32);
            this.textBoxInput1.TabIndex = 14;
            this.textBoxInput1.TextChanged += new System.EventHandler(this.TextBoxInput_TextChanged);
            // 
            // buttonClearText
            // 
            this.buttonClearText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearText.Location = new System.Drawing.Point(443, 213);
            this.buttonClearText.Name = "buttonClearText";
            this.buttonClearText.Size = new System.Drawing.Size(181, 71);
            this.buttonClearText.TabIndex = 13;
            this.buttonClearText.Text = "Clear Text";
            this.buttonClearText.UseVisualStyleBackColor = true;
            this.buttonClearText.Click += new System.EventHandler(this.buttonClearText_Click);
            // 
            // buttonShowText
            // 
            this.buttonShowText.Enabled = false;
            this.buttonShowText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonShowText.Location = new System.Drawing.Point(191, 213);
            this.buttonShowText.Name = "buttonShowText";
            this.buttonShowText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonShowText.Size = new System.Drawing.Size(173, 71);
            this.buttonShowText.TabIndex = 12;
            this.buttonShowText.Text = "Show Text";
            this.buttonShowText.UseVisualStyleBackColor = true;
            this.buttonShowText.Click += new System.EventHandler(this.buttonShowText_Click);
            // 
            // labelPlaceholder
            // 
            this.labelPlaceholder.AutoSize = true;
            this.labelPlaceholder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlaceholder.Location = new System.Drawing.Point(98, 386);
            this.labelPlaceholder.Name = "labelPlaceholder";
            this.labelPlaceholder.Size = new System.Drawing.Size(124, 25);
            this.labelPlaceholder.TabIndex = 11;
            this.labelPlaceholder.Text = "placeholder";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.Location = new System.Drawing.Point(98, 298);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(79, 25);
            this.labelResult.TabIndex = 10;
            this.labelResult.Text = "Result:";
            // 
            // labelInputVal1
            // 
            this.labelInputVal1.AutoSize = true;
            this.labelInputVal1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInputVal1.Location = new System.Drawing.Point(98, 107);
            this.labelInputVal1.Name = "labelInputVal1";
            this.labelInputVal1.Size = new System.Drawing.Size(143, 30);
            this.labelInputVal1.TabIndex = 9;
            this.labelInputVal1.Text = "Input 1st Text:";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Stencil", 20F);
            this.labelTitle.Location = new System.Drawing.Point(242, 35);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(349, 32);
            this.labelTitle.TabIndex = 8;
            this.labelTitle.Text = "Example 2 Combine Text";
            this.labelTitle.TextChanged += new System.EventHandler(this.TextBoxInput_TextChanged);
            // 
            // textBoxInput2
            // 
            this.textBoxInput2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBoxInput2.Location = new System.Drawing.Point(289, 142);
            this.textBoxInput2.Name = "textBoxInput2";
            this.textBoxInput2.Size = new System.Drawing.Size(397, 32);
            this.textBoxInput2.TabIndex = 17;
            this.textBoxInput2.TextChanged += new System.EventHandler(this.TextBoxInput_TextChanged);
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInput.Location = new System.Drawing.Point(98, 145);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(151, 30);
            this.labelInput.TabIndex = 16;
            this.labelInput.Text = "Input 2nd Text:";
            // 
            // Example2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxInput2);
            this.Controls.Add(this.labelInput);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxInput1);
            this.Controls.Add(this.buttonClearText);
            this.Controls.Add(this.buttonShowText);
            this.Controls.Add(this.labelPlaceholder);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelInputVal1);
            this.Controls.Add(this.labelTitle);
            this.Name = "Example2";
            this.Text = "Example2";
            this.Load += new System.EventHandler(this.Example2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.TextBox textBoxInput1;
        private System.Windows.Forms.Button buttonClearText;
        private System.Windows.Forms.Button buttonShowText;
        private System.Windows.Forms.Label labelPlaceholder;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelInputVal1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxInput2;
        private System.Windows.Forms.Label labelInput;
    }
}