namespace PDF_Resume_Creator
{
    partial class generatePage
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
            this.titleBox = new System.Windows.Forms.PictureBox();
            this.generateBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.titleBox)).BeginInit();
            this.SuspendLayout();
            // 
            // titleBox
            // 
            this.titleBox.BackColor = System.Drawing.Color.Transparent;
            this.titleBox.BackgroundImage = global::PDF_Resume_Creator.Properties.Resources.eee;
            this.titleBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.titleBox.Location = new System.Drawing.Point(61, 22);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(442, 132);
            this.titleBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.titleBox.TabIndex = 0;
            this.titleBox.TabStop = false;
            // 
            // generateBtn
            // 
            this.generateBtn.BackColor = System.Drawing.Color.Transparent;
            this.generateBtn.BackgroundImage = global::PDF_Resume_Creator.Properties.Resources.btn_only;
            this.generateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.generateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.generateBtn.Location = new System.Drawing.Point(147, 370);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(283, 129);
            this.generateBtn.TabIndex = 1;
            this.generateBtn.UseVisualStyleBackColor = false;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // generatePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PDF_Resume_Creator.Properties.Resources.bggggg;
            this.ClientSize = new System.Drawing.Size(566, 619);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.titleBox);
            this.Name = "generatePage";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.titleBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox titleBox;
        private System.Windows.Forms.Button generateBtn;
    }
}

