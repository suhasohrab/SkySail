
namespace FlightReservation2
{
    partial class Hotel
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("MovenPick");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Marriot");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Avari Towers");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Karachi", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Pearl Continental");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Avari Towers Lahore");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Lahore", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Ramada");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Islamabad", new System.Windows.Forms.TreeNode[] {
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Serena Hotels");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Quetta", new System.Windows.Forms.TreeNode[] {
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Shelton Rezidor");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Peshawar", new System.Windows.Forms.TreeNode[] {
            treeNode12});
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(262, -4);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1081, 752);
            this.webBrowser1.TabIndex = 1;
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.LightCyan;
            this.treeView1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.Location = new System.Drawing.Point(-6, -4);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "MovenPick";
            treeNode1.Tag = "https://www.movenpick.com/";
            treeNode1.Text = "MovenPick";
            treeNode2.Name = "Marriot";
            treeNode2.Tag = "https://www.marriott.com";
            treeNode2.Text = "Marriot";
            treeNode3.Name = "Avari Towers";
            treeNode3.Tag = "https://www.avarilahore.com/";
            treeNode3.Text = "Avari Towers";
            treeNode4.Name = "Marriot";
            treeNode4.Text = "Karachi";
            treeNode5.Name = "Pearl Continental";
            treeNode5.Tag = "https://www.pchotels.com/pckarachi";
            treeNode5.Text = "Pearl Continental";
            treeNode6.Name = "Avari Towers Lahore";
            treeNode6.Tag = "https://www.avarilahore.com/";
            treeNode6.Text = "Avari Towers Lahore";
            treeNode7.Name = "Lahore";
            treeNode7.Text = "Lahore";
            treeNode8.Name = "Ramada";
            treeNode8.Tag = "https://ramadaislamabad.com/";
            treeNode8.Text = "Ramada";
            treeNode9.Name = "Islamabad";
            treeNode9.Text = "Islamabad";
            treeNode10.Name = "Serena Hotels";
            treeNode10.Tag = "https://www.serenahotels.com/serenaquetta/en/default.html";
            treeNode10.Text = "Serena Hotels";
            treeNode11.Name = "Quetta";
            treeNode11.Text = "Quetta";
            treeNode12.Name = "Shelton Rezidor";
            treeNode12.Tag = "https://www.booking.com/hotel/pk/shelton-39-s-rezidor.html";
            treeNode12.Text = "Shelton Rezidor";
            treeNode13.Name = "Peshawar";
            treeNode13.Text = "Peshawar";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode7,
            treeNode9,
            treeNode11,
            treeNode13});
            this.treeView1.Size = new System.Drawing.Size(1349, 741);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // Hotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 736);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.treeView1);
            this.Name = "Hotel";
            this.Text = "Hotel";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TreeView treeView1;
    }
}