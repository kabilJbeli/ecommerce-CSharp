
namespace ecommerce
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.productCode = new System.Windows.Forms.TextBox();
            this.productName = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.productBrand = new System.Windows.Forms.TextBox();
            this.addproductbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // productCode
            // 
            this.productCode.Location = new System.Drawing.Point(12, 73);
            this.productCode.MinimumSize = new System.Drawing.Size(4, 40);
            this.productCode.Multiline = true;
            this.productCode.Name = "productCode";
            this.productCode.Size = new System.Drawing.Size(1292, 40);
            this.productCode.TabIndex = 2;
            this.productCode.TextChanged += new System.EventHandler(this.productCode_TextChanged);
            // 
            // productName
            // 
            this.productName.Location = new System.Drawing.Point(12, 145);
            this.productName.Multiline = true;
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(1292, 38);
            this.productName.TabIndex = 3;
            // 
            // productBrand
            // 
            this.productBrand.Location = new System.Drawing.Point(12, 218);
            this.productBrand.Multiline = true;
            this.productBrand.Name = "productBrand";
            this.productBrand.Size = new System.Drawing.Size(1292, 38);
            this.productBrand.TabIndex = 4;
            // 
            // addproductbtn
            // 
            this.addproductbtn.Location = new System.Drawing.Point(12, 285);
            this.addproductbtn.Name = "addproductbtn";
            this.addproductbtn.Size = new System.Drawing.Size(138, 46);
            this.addproductbtn.TabIndex = 5;
            this.addproductbtn.Text = "Add product";
            this.addproductbtn.UseVisualStyleBackColor = true;
            this.addproductbtn.Click += new System.EventHandler(this.addproduct);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Product Code";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Product Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Product Brand";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1316, 559);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addproductbtn);
            this.Controls.Add(this.productBrand);
            this.Controls.Add(this.productName);
            this.Controls.Add(this.productCode);
            this.Name = "Form2";
            this.Controls.SetChildIndex(this.productCode, 0);
            this.Controls.SetChildIndex(this.productName, 0);
            this.Controls.SetChildIndex(this.productBrand, 0);
            this.Controls.SetChildIndex(this.addproductbtn, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox productCode;
        private System.Windows.Forms.TextBox productName;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox productBrand;
        private System.Windows.Forms.Button addproductbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
