namespace WinFrm_ByteBarApp
{
    partial class MongoFrmByte
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mongoDBExit = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMongoDBOracle = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.listViewMongo = new System.Windows.Forms.ListView();
            this.LblByteBarMongo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.lblProducts = new System.Windows.Forms.Label();
            this.btnDisplayMongo = new System.Windows.Forms.Button();
            this.lblSystemMessage = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.connectToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mongoDBExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mongoDBExit
            // 
            this.mongoDBExit.Name = "mongoDBExit";
            this.mongoDBExit.Size = new System.Drawing.Size(180, 22);
            this.mongoDBExit.Text = "Exit";
            this.mongoDBExit.Click += new System.EventHandler(this.mongoDBExit_Click);
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMongoDBOracle});
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.connectToolStripMenuItem.Text = "Connect";
            // 
            // menuMongoDBOracle
            // 
            this.menuMongoDBOracle.Name = "menuMongoDBOracle";
            this.menuMongoDBOracle.Size = new System.Drawing.Size(180, 22);
            this.menuMongoDBOracle.Text = "Oracle";
            this.menuMongoDBOracle.Click += new System.EventHandler(this.menuMongoDBOracle_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // listViewMongo
            // 
            this.listViewMongo.HideSelection = false;
            this.listViewMongo.Location = new System.Drawing.Point(190, 92);
            this.listViewMongo.Name = "listViewMongo";
            this.listViewMongo.Size = new System.Drawing.Size(529, 322);
            this.listViewMongo.TabIndex = 7;
            this.listViewMongo.UseCompatibleStateImageBehavior = false;
            // 
            // LblByteBarMongo
            // 
            this.LblByteBarMongo.AutoSize = true;
            this.LblByteBarMongo.Font = new System.Drawing.Font("Magneto", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblByteBarMongo.Location = new System.Drawing.Point(186, 31);
            this.LblByteBarMongo.Name = "LblByteBarMongo";
            this.LblByteBarMongo.Size = new System.Drawing.Size(533, 58);
            this.LblByteBarMongo.TabIndex = 6;
            this.LblByteBarMongo.Text = "Byte Bar MongoDB";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(39, 310);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 12;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(35, 99);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(110, 109);
            this.checkedListBox1.TabIndex = 11;
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Location = new System.Drawing.Point(89, 118);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(0, 13);
            this.lblProducts.TabIndex = 10;
            // 
            // btnDisplayMongo
            // 
            this.btnDisplayMongo.Location = new System.Drawing.Point(29, 353);
            this.btnDisplayMongo.Name = "btnDisplayMongo";
            this.btnDisplayMongo.Size = new System.Drawing.Size(110, 45);
            this.btnDisplayMongo.TabIndex = 9;
            this.btnDisplayMongo.Text = "Display";
            this.btnDisplayMongo.UseVisualStyleBackColor = true;
            this.btnDisplayMongo.Click += new System.EventHandler(this.btnDisplayMongo_Click);
            // 
            // lblSystemMessage
            // 
            this.lblSystemMessage.Font = new System.Drawing.Font("Geometr415 Blk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystemMessage.ForeColor = System.Drawing.Color.Red;
            this.lblSystemMessage.Location = new System.Drawing.Point(25, 417);
            this.lblSystemMessage.Name = "lblSystemMessage";
            this.lblSystemMessage.Size = new System.Drawing.Size(100, 22);
            this.lblSystemMessage.TabIndex = 13;
            // 
            // MongoFrmByte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSystemMessage);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.lblProducts);
            this.Controls.Add(this.btnDisplayMongo);
            this.Controls.Add(this.listViewMongo);
            this.Controls.Add(this.LblByteBarMongo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MongoFrmByte";
            this.Text = "MongoDB ByteBar";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuMongoDBOracle;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ListView listViewMongo;
        private System.Windows.Forms.Label LblByteBarMongo;
        private System.Windows.Forms.ToolStripMenuItem mongoDBExit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.Button btnDisplayMongo;
        private System.Windows.Forms.Label lblSystemMessage;
    }
}