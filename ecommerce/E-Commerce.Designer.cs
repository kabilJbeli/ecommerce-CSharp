
using ecommerce.ecommerceClasses;
using System;

namespace ecommerce
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
     

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientListsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createATransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productToolStripMenuItem,
            this.clientsToolStripMenuItem,
            this.transactionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1316, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProductToolStripMenuItem,
            this.productsListToolStripMenuItem,
            this.modifyProductToolStripMenuItem,
            this.deleteProductToolStripMenuItem});
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.productToolStripMenuItem.Text = "Products";
            this.productToolStripMenuItem.Click += new System.EventHandler(this.productToolStripMenuItem_Click);
            // 
            // addProductToolStripMenuItem
            // 
            this.addProductToolStripMenuItem.Name = "addProductToolStripMenuItem";
            this.addProductToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addProductToolStripMenuItem.Text = "Add  New Product";
            this.addProductToolStripMenuItem.Click += new System.EventHandler(this.addProductToolStripMenuItem_Click);
            // 
            // productsListToolStripMenuItem
            // 
            this.productsListToolStripMenuItem.Name = "productsListToolStripMenuItem";
            this.productsListToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.productsListToolStripMenuItem.Text = "Products List";
            this.productsListToolStripMenuItem.CheckedChanged += new System.EventHandler(this.gotoproductlist);
            this.productsListToolStripMenuItem.Click += new System.EventHandler(this.gotoproductlist);
            // 
            // modifyProductToolStripMenuItem
            // 
            this.modifyProductToolStripMenuItem.Name = "modifyProductToolStripMenuItem";
            this.modifyProductToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.modifyProductToolStripMenuItem.Text = "Modify Product";
            this.modifyProductToolStripMenuItem.Click += new System.EventHandler(this.modifyProductToolStripMenuItem_Click);
            // 
            // deleteProductToolStripMenuItem
            // 
            this.deleteProductToolStripMenuItem.Name = "deleteProductToolStripMenuItem";
            this.deleteProductToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.deleteProductToolStripMenuItem.Text = "Delete Product";
            this.deleteProductToolStripMenuItem.Click += new System.EventHandler(this.deleteProduct);
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addClientToolStripMenuItem,
            this.clientListsToolStripMenuItem,
            this.modifyClientToolStripMenuItem,
            this.deleteClientToolStripMenuItem});
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.clientsToolStripMenuItem.Text = "Clients";
            // 
            // addClientToolStripMenuItem
            // 
            this.addClientToolStripMenuItem.Name = "addClientToolStripMenuItem";
            this.addClientToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.addClientToolStripMenuItem.Text = "Add New Client";
            this.addClientToolStripMenuItem.Click += new System.EventHandler(this.addClientToolStripMenuItem_Click);
            // 
            // clientListsToolStripMenuItem
            // 
            this.clientListsToolStripMenuItem.Name = "clientListsToolStripMenuItem";
            this.clientListsToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.clientListsToolStripMenuItem.Text = "Client Lists";
            this.clientListsToolStripMenuItem.Click += new System.EventHandler(this.clientListsToolStripMenuItem_Click);
            // 
            // modifyClientToolStripMenuItem
            // 
            this.modifyClientToolStripMenuItem.Name = "modifyClientToolStripMenuItem";
            this.modifyClientToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.modifyClientToolStripMenuItem.Text = "Modify Client";
            this.modifyClientToolStripMenuItem.Click += new System.EventHandler(this.modifyClientToolStripMenuItem_Click);
            // 
            // deleteClientToolStripMenuItem
            // 
            this.deleteClientToolStripMenuItem.Name = "deleteClientToolStripMenuItem";
            this.deleteClientToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.deleteClientToolStripMenuItem.Text = "Delete Client";
            this.deleteClientToolStripMenuItem.Click += new System.EventHandler(this.deleteClientToolStripMenuItem_Click);
            // 
            // transactionsToolStripMenuItem
            // 
            this.transactionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createATransactionToolStripMenuItem,
            this.transactionsToolStripMenuItem1,
            this.modifyTransactionToolStripMenuItem,
            this.deleteTransactionToolStripMenuItem});
            this.transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            this.transactionsToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.transactionsToolStripMenuItem.Text = "Transactions";
            // 
            // createATransactionToolStripMenuItem
            // 
            this.createATransactionToolStripMenuItem.Name = "createATransactionToolStripMenuItem";
            this.createATransactionToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.createATransactionToolStripMenuItem.Text = "Create A Transaction";
            // 
            // transactionsToolStripMenuItem1
            // 
            this.transactionsToolStripMenuItem1.Name = "transactionsToolStripMenuItem1";
            this.transactionsToolStripMenuItem1.Size = new System.Drawing.Size(228, 26);
            this.transactionsToolStripMenuItem1.Text = "Transactions";
            // 
            // modifyTransactionToolStripMenuItem
            // 
            this.modifyTransactionToolStripMenuItem.Name = "modifyTransactionToolStripMenuItem";
            this.modifyTransactionToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.modifyTransactionToolStripMenuItem.Text = "Modify Transaction";
            // 
            // deleteTransactionToolStripMenuItem
            // 
            this.deleteTransactionToolStripMenuItem.Name = "deleteTransactionToolStripMenuItem";
            this.deleteTransactionToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.deleteTransactionToolStripMenuItem.Text = "Delete Transaction";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(1000, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 533);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip1.Size = new System.Drawing.Size(1316, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked_1);
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(50, 20);
            this.statusLabel.Text = "Home";
            this.statusLabel.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1316, 559);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "E-commerce";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.destroyForm);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientListsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createATransactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modifyTransactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteTransactionToolStripMenuItem;
        public System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel statusLabel;
    }
}

