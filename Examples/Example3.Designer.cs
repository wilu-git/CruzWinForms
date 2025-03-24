namespace CruzWinForms.Examples
{
    partial class Example3
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
            this.textBoxInput2 = new System.Windows.Forms.TextBox();
            this.labelInput = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.textBoxInput1 = new System.Windows.Forms.TextBox();
            this.buttonClearText = new System.Windows.Forms.Button();
            this.buttonShowText = new System.Windows.Forms.Button();
            this.labelPlaceholder = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelInputVal1 = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxInput2
            // 
            this.textBoxInput2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBoxInput2.Location = new System.Drawing.Point(297, 144);
            this.textBoxInput2.Name = "textBoxInput2";
            this.textBoxInput2.Size = new System.Drawing.Size(397, 32);
            this.textBoxInput2.TabIndex = 27;
            this.textBoxInput2.TextChanged += new System.EventHandler(this.TextBoxInput_TextChanged);
            this.textBoxInput2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxInput_KeyPress);
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInput.Location = new System.Drawing.Point(106, 147);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(160, 30);
            this.labelInput.TabIndex = 26;
            this.labelInput.Text = "Input 2nd Num:";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Enabled = false;
            this.textBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBoxResult.Location = new System.Drawing.Point(111, 338);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(583, 32);
            this.textBoxResult.TabIndex = 25;
            // 
            // textBoxInput1
            // 
            this.textBoxInput1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBoxInput1.Location = new System.Drawing.Point(297, 106);
            this.textBoxInput1.Name = "textBoxInput1";
            this.textBoxInput1.Size = new System.Drawing.Size(397, 32);
            this.textBoxInput1.TabIndex = 24;
            this.textBoxInput1.TextChanged += new System.EventHandler(this.TextBoxInput_TextChanged);
            this.textBoxInput1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxInput_KeyPress);
            // 
            // buttonClearText
            // 
            this.buttonClearText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearText.Location = new System.Drawing.Point(451, 215);
            this.buttonClearText.Name = "buttonClearText";
            this.buttonClearText.Size = new System.Drawing.Size(181, 71);
            this.buttonClearText.TabIndex = 23;
            this.buttonClearText.Text = "Clear";
            this.buttonClearText.UseVisualStyleBackColor = true;
            this.buttonClearText.Click += new System.EventHandler(this.buttonClearText_Click);
            // 
            // buttonShowText
            // 
            this.buttonShowText.Enabled = false;
            this.buttonShowText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonShowText.Location = new System.Drawing.Point(199, 215);
            this.buttonShowText.Name = "buttonShowText";
            this.buttonShowText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonShowText.Size = new System.Drawing.Size(173, 71);
            this.buttonShowText.TabIndex = 22;
            this.buttonShowText.Text = "Show Sum";
            this.buttonShowText.UseVisualStyleBackColor = true;
            this.buttonShowText.Click += new System.EventHandler(this.buttonShowText_Click);
            // 
            // labelPlaceholder
            // 
            this.labelPlaceholder.AutoSize = true;
            this.labelPlaceholder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlaceholder.Location = new System.Drawing.Point(106, 388);
            this.labelPlaceholder.Name = "labelPlaceholder";
            this.labelPlaceholder.Size = new System.Drawing.Size(124, 25);
            this.labelPlaceholder.TabIndex = 21;
            this.labelPlaceholder.Text = "placeholder";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.Location = new System.Drawing.Point(106, 300);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(79, 25);
            this.labelResult.TabIndex = 20;
            this.labelResult.Text = "Result:";
            // 
            // labelInputVal1
            // 
            this.labelInputVal1.AutoSize = true;
            this.labelInputVal1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInputVal1.Location = new System.Drawing.Point(106, 109);
            this.labelInputVal1.Name = "labelInputVal1";
            this.labelInputVal1.Size = new System.Drawing.Size(152, 30);
            this.labelInputVal1.TabIndex = 19;
            this.labelInputVal1.Text = "Input 1st Num:";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Stencil", 20F);
            this.labelTitle.Location = new System.Drawing.Point(227, 40);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(370, 32);
            this.labelTitle.TabIndex = 18;
            this.labelTitle.Text = "Example 3 Sum 2 Numbers";
            // 
            // Example3
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
            this.Name = "Example3";
            this.Text = "Example3";
            this.Load += new System.EventHandler(this.Example3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInput2;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.TextBox textBoxInput1;
        private System.Windows.Forms.Button buttonClearText;
        private System.Windows.Forms.Button buttonShowText;
        private System.Windows.Forms.Label labelPlaceholder;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelInputVal1;
        private System.Windows.Forms.Label labelTitle;
    }
}