namespace inbox
{
    partial class CustomColor
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
            this.labelBackground = new System.Windows.Forms.Label();
            this.labelText = new System.Windows.Forms.Label();
            this.labelButton = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonBackground = new System.Windows.Forms.Button();
            this.buttonText = new System.Windows.Forms.Button();
            this.buttonButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelBackground
            // 
            this.labelBackground.AutoSize = true;
            this.labelBackground.Location = new System.Drawing.Point(13, 30);
            this.labelBackground.Name = "labelBackground";
            this.labelBackground.Size = new System.Drawing.Size(65, 13);
            this.labelBackground.TabIndex = 0;
            this.labelBackground.Text = "Background";
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Location = new System.Drawing.Point(13, 61);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(28, 13);
            this.labelText.TabIndex = 1;
            this.labelText.Text = "Text";
            // 
            // labelButton
            // 
            this.labelButton.AutoSize = true;
            this.labelButton.Location = new System.Drawing.Point(13, 91);
            this.labelButton.Name = "labelButton";
            this.labelButton.Size = new System.Drawing.Size(38, 13);
            this.labelButton.TabIndex = 2;
            this.labelButton.Text = "Button";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(55, 116);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonBackground
            // 
            this.buttonBackground.Location = new System.Drawing.Point(84, 25);
            this.buttonBackground.Name = "buttonBackground";
            this.buttonBackground.Size = new System.Drawing.Size(28, 22);
            this.buttonBackground.TabIndex = 4;
            this.buttonBackground.UseVisualStyleBackColor = true;
            this.buttonBackground.Click += new System.EventHandler(this.buttonBackground_Click);
            // 
            // buttonText
            // 
            this.buttonText.Location = new System.Drawing.Point(84, 56);
            this.buttonText.Name = "buttonText";
            this.buttonText.Size = new System.Drawing.Size(28, 22);
            this.buttonText.TabIndex = 5;
            this.buttonText.UseVisualStyleBackColor = true;
            this.buttonText.Click += new System.EventHandler(this.buttonText_Click);
            // 
            // buttonButton
            // 
            this.buttonButton.Location = new System.Drawing.Point(84, 86);
            this.buttonButton.Name = "buttonButton";
            this.buttonButton.Size = new System.Drawing.Size(28, 22);
            this.buttonButton.TabIndex = 6;
            this.buttonButton.UseVisualStyleBackColor = true;
            this.buttonButton.Click += new System.EventHandler(this.buttonButton_Click);
            // 
            // CustomColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(188, 157);
            this.Controls.Add(this.buttonButton);
            this.Controls.Add(this.buttonText);
            this.Controls.Add(this.buttonBackground);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelButton);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.labelBackground);
            this.Name = "CustomColor";
            this.Text = "Color";
            this.Load += new System.EventHandler(this.CustomColor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBackground;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Label labelButton;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonBackground;
        private System.Windows.Forms.Button buttonText;
        private System.Windows.Forms.Button buttonButton;
    }
}