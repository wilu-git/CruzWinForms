namespace CruzWinForms
{
    partial class FormEntryPoint
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
            this.components = new System.ComponentModel.Container();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.labelWelcome = new System.Windows.Forms.Label();
            this.buttonExample1 = new System.Windows.Forms.Button();
            this.buttonExample2 = new System.Windows.Forms.Button();
            this.buttonExample3 = new System.Windows.Forms.Button();
            this.buttonExample4 = new System.Windows.Forms.Button();
            this.buttonExample5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelWelcome.Location = new System.Drawing.Point(274, 9);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(259, 26);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "Welcome To My Program";
            // 
            // buttonExample1
            // 
            this.buttonExample1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExample1.Location = new System.Drawing.Point(73, 68);
            this.buttonExample1.Name = "buttonExample1";
            this.buttonExample1.Size = new System.Drawing.Size(95, 63);
            this.buttonExample1.TabIndex = 1;
            this.buttonExample1.Text = "Ex1";
            this.buttonExample1.UseVisualStyleBackColor = true;
            this.buttonExample1.Click += new System.EventHandler(this.buttonExample1_Click);
            // 
            // buttonExample2
            // 
            this.buttonExample2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExample2.Location = new System.Drawing.Point(212, 68);
            this.buttonExample2.Name = "buttonExample2";
            this.buttonExample2.Size = new System.Drawing.Size(95, 63);
            this.buttonExample2.TabIndex = 2;
            this.buttonExample2.Text = "Ex2";
            this.buttonExample2.UseVisualStyleBackColor = true;
            this.buttonExample2.Click += new System.EventHandler(this.buttonExample2_Click);
            // 
            // buttonExample3
            // 
            this.buttonExample3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExample3.Location = new System.Drawing.Point(346, 68);
            this.buttonExample3.Name = "buttonExample3";
            this.buttonExample3.Size = new System.Drawing.Size(95, 63);
            this.buttonExample3.TabIndex = 3;
            this.buttonExample3.Text = "Ex3";
            this.buttonExample3.UseVisualStyleBackColor = true;
            this.buttonExample3.Click += new System.EventHandler(this.buttonExample3_Click);
            // 
            // buttonExample4
            // 
            this.buttonExample4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExample4.Location = new System.Drawing.Point(493, 68);
            this.buttonExample4.Name = "buttonExample4";
            this.buttonExample4.Size = new System.Drawing.Size(95, 63);
            this.buttonExample4.TabIndex = 4;
            this.buttonExample4.Text = "Ex4";
            this.buttonExample4.UseVisualStyleBackColor = true;
            this.buttonExample4.Click += new System.EventHandler(this.buttonExample4_Click);
            // 
            // buttonExample5
            // 
            this.buttonExample5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExample5.Location = new System.Drawing.Point(632, 68);
            this.buttonExample5.Name = "buttonExample5";
            this.buttonExample5.Size = new System.Drawing.Size(95, 63);
            this.buttonExample5.TabIndex = 5;
            this.buttonExample5.Text = "Ex5";
            this.buttonExample5.UseVisualStyleBackColor = true;
            this.buttonExample5.Click += new System.EventHandler(this.buttonExample5_Click);
            // 
            // FormEntryPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 167);
            this.Controls.Add(this.buttonExample5);
            this.Controls.Add(this.buttonExample4);
            this.Controls.Add(this.buttonExample3);
            this.Controls.Add(this.buttonExample2);
            this.Controls.Add(this.buttonExample1);
            this.Controls.Add(this.labelWelcome);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEntryPoint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cruz Window Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button buttonExample1;
        private System.Windows.Forms.Button buttonExample2;
        private System.Windows.Forms.Button buttonExample3;
        private System.Windows.Forms.Button buttonExample4;
        private System.Windows.Forms.Button buttonExample5;
    }
}

