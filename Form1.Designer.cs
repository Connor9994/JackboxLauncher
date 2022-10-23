namespace JackboxLauncher
{
    partial class KaOs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KaOs));
            this.KaOsBox = new System.Windows.Forms.PictureBox();
            this.GamePicBox = new System.Windows.Forms.PictureBox();
            this.DropBox = new System.Windows.Forms.ComboBox();
            this.PlayButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.KaOsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GamePicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // KaOsBox
            // 
            this.KaOsBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KaOsBox.Image = global::JackboxLauncher.Properties.Resources.mario;
            this.KaOsBox.Location = new System.Drawing.Point(11, 1);
            this.KaOsBox.Name = "KaOsBox";
            this.KaOsBox.Size = new System.Drawing.Size(441, 75);
            this.KaOsBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.KaOsBox.TabIndex = 0;
            this.KaOsBox.TabStop = false;
            this.KaOsBox.Click += new System.EventHandler(this.KaOsBox_Click);
            // 
            // GamePicBox
            // 
            this.GamePicBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GamePicBox.Image = global::JackboxLauncher.Properties.Resources._1;
            this.GamePicBox.Location = new System.Drawing.Point(11, 82);
            this.GamePicBox.Name = "GamePicBox";
            this.GamePicBox.Size = new System.Drawing.Size(441, 210);
            this.GamePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GamePicBox.TabIndex = 1;
            this.GamePicBox.TabStop = false;
            this.GamePicBox.Click += new System.EventHandler(this.GamePicBox_Click);
            // 
            // DropBox
            // 
            this.DropBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DropBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropBox.FormattingEnabled = true;
            this.DropBox.Items.AddRange(new object[] {
            "The Jackbox Party Pack",
            "The Jackbox Party Pack 2",
            "The Jackbox Party Pack 3",
            "The Jackbox Party Pack 4",
            "The Jackbox Party Pack 5",
            "The Jackbox Party Pack 6",
            "The Jackbox Party Pack 7",
            "The Jackbox Party Pack 8",
            "The Jackbox Party Pack 9"});
            this.DropBox.Location = new System.Drawing.Point(11, 298);
            this.DropBox.Name = "DropBox";
            this.DropBox.Size = new System.Drawing.Size(359, 21);
            this.DropBox.TabIndex = 2;
            this.DropBox.SelectedIndexChanged += new System.EventHandler(this.DropBox_SelectedIndexChanged);
            // 
            // PlayButton
            // 
            this.PlayButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayButton.Location = new System.Drawing.Point(377, 298);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(75, 23);
            this.PlayButton.TabIndex = 3;
            this.PlayButton.Text = "Play!";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // KaOs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(464, 327);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.DropBox);
            this.Controls.Add(this.GamePicBox);
            this.Controls.Add(this.KaOsBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KaOs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KaOs Jackbox Party Pack Collection Launcher";
            this.Load += new System.EventHandler(this.KaOs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KaOsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GamePicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox KaOsBox;
        private System.Windows.Forms.PictureBox GamePicBox;
        private System.Windows.Forms.ComboBox DropBox;
        private System.Windows.Forms.Button PlayButton;
    }
}

