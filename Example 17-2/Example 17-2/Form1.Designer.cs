namespace Example_17_2
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
            this.btnShowAnimate = new System.Windows.Forms.Button();
            this.txtString = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnShowAnimate
            // 
            this.btnShowAnimate.Location = new System.Drawing.Point(170, 60);
            this.btnShowAnimate.Name = "btnShowAnimate";
            this.btnShowAnimate.Size = new System.Drawing.Size(94, 39);
            this.btnShowAnimate.TabIndex = 1;
            this.btnShowAnimate.Text = "Show Animation";
            this.btnShowAnimate.UseVisualStyleBackColor = true;
            this.btnShowAnimate.Click += new System.EventHandler(this.btnShowAnimate_Click);
            // 
            // txtString
            // 
            this.txtString.Location = new System.Drawing.Point(135, 22);
            this.txtString.Name = "txtString";
            this.txtString.Size = new System.Drawing.Size(168, 20);
            this.txtString.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter String:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 445);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtString);
            this.Controls.Add(this.btnShowAnimate);
            this.Name = "Form1";
            this.Text = "Example 17-2 (Graphics String Move)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowAnimate;
        private System.Windows.Forms.TextBox txtString;
        private System.Windows.Forms.Label label1;
    }
}

