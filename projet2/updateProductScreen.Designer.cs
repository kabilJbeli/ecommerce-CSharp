
namespace ecommerce
{
    partial class updateProductScreen
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
            this.message = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.productName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.productCode = new System.Windows.Forms.TextBox();
            this.productBrand = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addproductbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.price = new System.Windows.Forms.TextBox();
            this.Tva = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tvalabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.message.ForeColor = System.Drawing.Color.Coral;
            this.message.Location = new System.Drawing.Point(25, 263);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(0, 24);
            this.message.TabIndex = 19;
            this.message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(131, 269);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 17);
            this.errorLabel.TabIndex = 20;
            // 
            // productName
            // 
            this.productName.Location = new System.Drawing.Point(747, 5);
            this.productName.Multiline = true;
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(529, 38);
            this.productName.TabIndex = 3;
            this.productName.TextChanged += new System.EventHandler(this.productName_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(643, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Product Name";
            // 
            // productCode
            // 
            this.productCode.Location = new System.Drawing.Point(108, 5);
            this.productCode.MinimumSize = new System.Drawing.Size(4, 40);
            this.productCode.Multiline = true;
            this.productCode.Name = "productCode";
            this.productCode.Size = new System.Drawing.Size(529, 40);
            this.productCode.TabIndex = 2;
            this.productCode.TextChanged += new System.EventHandler(this.productCode_TextChanged);
            // 
            // productBrand
            // 
            this.productBrand.Location = new System.Drawing.Point(108, 51);
            this.productBrand.Multiline = true;
            this.productBrand.Name = "productBrand";
            this.productBrand.Size = new System.Drawing.Size(529, 38);
            this.productBrand.TabIndex = 4;
            this.productBrand.TextChanged += new System.EventHandler(this.productBrand_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Product Brand";
            // 
            // addproductbtn
            // 
            this.addproductbtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addproductbtn.Location = new System.Drawing.Point(747, 97);
            this.addproductbtn.Name = "addproductbtn";
            this.addproductbtn.Size = new System.Drawing.Size(139, 36);
            this.addproductbtn.TabIndex = 5;
            this.addproductbtn.Text = "Update product";
            this.addproductbtn.UseVisualStyleBackColor = true;
            this.addproductbtn.Click += new System.EventHandler(this.addproductbtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Product Code";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tvalabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.Tva, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.price, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.productBrand, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.productCode, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.productName, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.addproductbtn, 3, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(23, 56);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 2, 2, 5);
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1281, 143);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(747, 51);
            this.price.Multiline = true;
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(529, 38);
            this.price.TabIndex = 21;
            this.price.TextChanged += new System.EventHandler(this.price_TextChanged);
            // 
            // Tva
            // 
            this.Tva.Location = new System.Drawing.Point(108, 95);
            this.Tva.Multiline = true;
            this.Tva.Name = "Tva";
            this.Tva.Size = new System.Drawing.Size(529, 38);
            this.Tva.TabIndex = 21;
            this.Tva.TextChanged += new System.EventHandler(this.Tva_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(643, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Price";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tvalabel
            // 
            this.tvalabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tvalabel.AutoSize = true;
            this.tvalabel.Location = new System.Drawing.Point(3, 106);
            this.tvalabel.Name = "tvalabel";
            this.tvalabel.Size = new System.Drawing.Size(32, 17);
            this.tvalabel.TabIndex = 21;
            this.tvalabel.Text = "Tva";
            // 
            // updateProductScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1316, 559);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.message);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "updateProductScreen";
            this.Load += new System.EventHandler(this.updateProductScreen_Load);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.message, 0);
            this.Controls.SetChildIndex(this.errorLabel, 0);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.TextBox productName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox productCode;
        private System.Windows.Forms.TextBox productBrand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addproductbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox Tva;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label tvalabel;
    }
}
