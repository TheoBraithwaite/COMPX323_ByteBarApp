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
            this.btnDisplay = new System.Windows.Forms.Button();
            this.lblProducts = new System.Windows.Forms.Label();
            this.menuStripByteBar = new System.Windows.Forms.MenuStrip();
            this.fileByteBar = new System.Windows.Forms.ToolStripMenuItem();
            this.byteBarExit = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mongoDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewByteBar = new System.Windows.Forms.ListView();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStripByteBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblByteBar
            // 
            this.LblByteBar.AutoSize = true;
            this.LblByteBar.Font = new System.Drawing.Font("Magneto", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblByteBar.Location = new System.Drawing.Point(298, 32);
            this.LblByteBar.Name = "LblByteBar";
            this.LblByteBar.Size = new System.Drawing.Size(261, 58);
            this.LblByteBar.TabIndex = 0;
            this.LblByteBar.Text = "Byte Bar";
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(35, 342);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(110, 45);
            this.btnDisplay.TabIndex = 1;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Location = new System.Drawing.Point(95, 107);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(0, 13);
            this.lblProducts.TabIndex = 3;
            // 
            // menuStripByteBar
            // 
            this.menuStripByteBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileByteBar,
            this.connectToolStripMenuItem});
            this.menuStripByteBar.Location = new System.Drawing.Point(0, 0);
            this.menuStripByteBar.Name = "menuStripByteBar";
            this.menuStripByteBar.Size = new System.Drawing.Size(800, 24);
            this.menuStripByteBar.TabIndex = 4;
            this.menuStripByteBar.Text = "menuStripByteBar";
            // 
            // fileByteBar
            // 
            this.fileByteBar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byteBarExit});
            this.fileByteBar.Name = "fileByteBar";
            this.fileByteBar.Size = new System.Drawing.Size(37, 20);
            this.fileByteBar.Text = "File";
            // 
            // byteBarExit
            // 
            this.byteBarExit.Name = "byteBarExit";
            this.byteBarExit.Size = new System.Drawing.Size(93, 22);
            this.byteBarExit.Text = "Exit";
            this.byteBarExit.Click += new System.EventHandler(this.byteBarExit_Click);
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mongoDBToolStripMenuItem});
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.connectToolStripMenuItem.Text = "Connect";
            // 
            // mongoDBToolStripMenuItem
            // 
            this.mongoDBToolStripMenuItem.Name = "mongoDBToolStripMenuItem";
            this.mongoDBToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.mongoDBToolStripMenuItem.Text = "MongoDB";
            // 
            // listViewByteBar
            // 
            this.listViewByteBar.HideSelection = false;
            this.listViewByteBar.Location = new System.Drawing.Point(189, 93);
            this.listViewByteBar.Name = "listViewByteBar";
            this.listViewByteBar.Size = new System.Drawing.Size(529, 322);
            this.listViewByteBar.TabIndex = 5;
            this.listViewByteBar.UseCompatibleStateImageBehavior = false;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(35, 96);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(110, 109);
            this.checkedListBox1.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(45, 299);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            // 
            // MainFrmByte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.listViewByteBar);
            this.Controls.Add(this.lblProducts);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.LblByteBar);
            this.Controls.Add(this.menuStripByteBar);
            this.MainMenuStrip = this.menuStripByteBar;
            this.Name = "MainFrmByte";
            this.Text = "Byte Bar";
            this.Load += new System.EventHandler(this.MainFrmByte_Load);
            this.menuStripByteBar.ResumeLayout(false);
            this.menuStripByteBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblByteBar;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.MenuStrip menuStripByteBar;
        private System.Windows.Forms.ToolStripMenuItem fileByteBar;
        private System.Windows.Forms.ToolStripMenuItem byteBarExit;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mongoDBToolStripMenuItem;
        private System.Windows.Forms.ListView listViewByteBar;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

