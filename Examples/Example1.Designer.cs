namespace CruzWinForms.Examples
{
    partial class Example1
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelInputVal = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelPlaceholder = new System.Windows.Forms.Label();
            this.buttonShowText = new System.Windows.Forms.Button();
            this.buttonClearText = new System.Windows.Forms.Button();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Stencil", 20F);
            this.labelTitle.Location = new System.Drawing.Point(115, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(475, 32);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Example1 Show Text / Clear Text";
            // 
            // labelInputVal
            // 
            this.labelInputVal.AutoSize = true;
            this.labelInputVal.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInputVal.Location = new System.Drawing.Point(55, 68);
            this.labelInputVal.Name = "labelInputVal";
            this.labelInputVal.Size = new System.Drawing.Size(175, 30);
            this.labelInputVal.TabIndex = 1;
            this.labelInputVal.Text = "Please Input Text:";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.Location = new System.Drawing.Point(55, 220);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(79, 25);
            this.labelResult.TabIndex = 2;
            this.labelResult.Text = "Result:";
            // 
            // labelPlaceholder
            // 
            this.labelPlaceholder.AutoSize = true;
            this.labelPlaceholder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlaceholder.Location = new System.Drawing.Point(55, 308);
            this.labelPlaceholder.Name = "labelPlaceholder";
            this.labelPlaceholder.Size = new System.Drawing.Size(124, 25);
            this.labelPlaceholder.TabIndex = 3;
            this.labelPlaceholder.Text = "placeholder";
            // 
            // buttonShowText
            // 
            this.buttonShowText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonShowText.Location = new System.Drawing.Point(138, 111);
            this.buttonShowText.Name = "buttonShowText";
            this.buttonShowText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonShowText.Size = new System.Drawing.Size(173, 71);
            this.buttonShowText.TabIndex = 4;
            this.buttonShowText.Text = "Show Text";
            this.buttonShowText.UseVisualStyleBackColor = true;
            this.buttonShowText.Click += new System.EventHandler(this.buttonShowText_Click);
            // 
            // buttonClearText
            // 
            this.buttonClearText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearText.Location = new System.Drawing.Point(390, 111);
            this.buttonClearText.Name = "buttonClearText";
            this.buttonClearText.Size = new System.Drawing.Size(181, 71);
            this.buttonClearText.TabIndex = 5;
            this.buttonClearText.Text = "Clear Text";
            this.buttonClearText.UseVisualStyleBackColor = true;
            this.buttonClearText.Click += new System.EventHandler(this.buttonClearText_Click);
            // 
            // textBoxInput
            // 
            this.textBoxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBoxInput.Location = new System.Drawing.Point(246, 65);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(397, 32);
            this.textBoxInput.TabIndex = 6;
            this.textBoxInput.TextChanged += new System.EventHandler(this.textBoxInput_TextChanged);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Enabled = false;
            this.textBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBoxResult.Location = new System.Drawing.Point(60, 258);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(583, 32);
            this.textBoxResult.TabIndex = 7;
            // 
            // Example1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 368);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.buttonClearText);
            this.Controls.Add(this.buttonShowText);
            this.Controls.Add(this.labelPlaceholder);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelInputVal);
            this.Controls.Add(this.labelTitle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Example1";
            this.Text = "Example1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelInputVal;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelPlaceholder;
        private System.Windows.Forms.Button buttonShowText;
        private System.Windows.Forms.Button buttonClearText;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.TextBox textBoxResult;
    }
}