namespace WinFrm_ByteBarApp
{
    partial class MainFrmByte
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
            this.LblByteBar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblByteBar
            // 
            this.LblByteBar.AutoSize = true;
            this.LblByteBar.Font = new System.Drawing.Font("Magneto", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblByteBar.Location = new System.Drawing.Point(264, 9);
            this.LblByteBar.Name = "LblByteBar";
            this.LblByteBar.Size = new System.Drawing.Size(261, 58);
            this.LblByteBar.TabIndex = 0;
            this.LblByteBar.Text = "Byte Bar";
            // 
            // MainFrmByte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblByteBar);
            this.Name = "MainFrmByte";
            this.Text = "Byte Bar";
            this.Load += new System.EventHandler(this.MainFrmByte_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblByteBar;
    }
}

