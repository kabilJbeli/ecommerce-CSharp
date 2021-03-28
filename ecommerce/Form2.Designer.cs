
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
            this.SuspendLayout();
            // 
            // productCode
            // 
            this.productCode.Location = new System.Drawing.Point(27, 53);
            this.productCode.Name = "productCode";
            this.productCode.Size = new System.Drawing.Size(374, 22);
            this.productCode.TabIndex = 2;
            this.productCode.TextChanged += new System.EventHandler(this.productCode_TextChanged);
            // 
            // productName
            // 
            this.productName.Location = new System.Drawing.Point(27, 108);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(374, 22);
            this.productName.TabIndex = 3;
            // 
            // productBrand
            // 
            this.productBrand.Location = new System.Drawing.Point(27, 166);
            this.productBrand.Name = "productBrand";
            this.productBrand.Size = new System.Drawing.Size(374, 22);
            this.productBrand.TabIndex = 4;
            // 
            // addproductbtn
            // 
            this.addproductbtn.Location = new System.Drawing.Point(27, 219);
            this.addproductbtn.Name = "addproductbtn";
            this.addproductbtn.Size = new System.Drawing.Size(75, 23);
            this.addproductbtn.TabIndex = 5;
            this.addproductbtn.Text = "Add product";
            this.addproductbtn.UseVisualStyleBackColor = true;
            this.addproductbtn.Click += new System.EventHandler(this.addproduct);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1316, 559);
            this.Controls.Add(this.addproductbtn);
            this.Controls.Add(this.productBrand);
            this.Controls.Add(this.productName);
            this.Controls.Add(this.productCode);
            this.Name = "Form2";
            this.Controls.SetChildIndex(this.productCode, 0);
            this.Controls.SetChildIndex(this.productName, 0);
            this.Controls.SetChildIndex(this.productBrand, 0);
            this.Controls.SetChildIndex(this.addproductbtn, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox productCode;
        private System.Windows.Forms.TextBox productName;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox productBrand;
        private System.Windows.Forms.Button addproductbtn;
    }
}
