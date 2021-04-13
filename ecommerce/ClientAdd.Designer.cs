
namespace ecommerce
{
    partial class ClientAdd
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
            this.label1 = new System.Windows.Forms.Label();
            this.clientName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.clientLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.clientEmail = new System.Windows.Forms.TextBox();
            this.clientTel = new System.Windows.Forms.TextBox();
            this.clientAdress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.clientCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Client Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // clientName
            // 
            this.clientName.Location = new System.Drawing.Point(12, 55);
            this.clientName.Multiline = true;
            this.clientName.Name = "clientName";
            this.clientName.Size = new System.Drawing.Size(1289, 36);
            this.clientName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Client Last Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // clientLastName
            // 
            this.clientLastName.Location = new System.Drawing.Point(12, 127);
            this.clientLastName.Multiline = true;
            this.clientLastName.Name = "clientLastName";
            this.clientLastName.Size = new System.Drawing.Size(1289, 36);
            this.clientLastName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email";
            // 
            // clientEmail
            // 
            this.clientEmail.Location = new System.Drawing.Point(12, 195);
            this.clientEmail.Multiline = true;
            this.clientEmail.Name = "clientEmail";
            this.clientEmail.Size = new System.Drawing.Size(1289, 34);
            this.clientEmail.TabIndex = 7;
            // 
            // clientTel
            // 
            this.clientTel.Location = new System.Drawing.Point(12, 265);
            this.clientTel.Multiline = true;
            this.clientTel.Name = "clientTel";
            this.clientTel.Size = new System.Drawing.Size(1289, 36);
            this.clientTel.TabIndex = 8;
            // 
            // clientAdress
            // 
            this.clientAdress.Location = new System.Drawing.Point(12, 337);
            this.clientAdress.Multiline = true;
            this.clientAdress.Name = "clientAdress";
            this.clientAdress.Size = new System.Drawing.Size(1289, 36);
            this.clientAdress.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tel";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 388);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Adress";
            // 
            // clientCode
            // 
            this.clientCode.Location = new System.Drawing.Point(12, 408);
            this.clientCode.Multiline = true;
            this.clientCode.Name = "clientCode";
            this.clientCode.Size = new System.Drawing.Size(1289, 36);
            this.clientCode.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Client Code";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // addClient
            // 
            this.addClient.Location = new System.Drawing.Point(12, 468);
            this.addClient.Name = "addClient";
            this.addClient.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.addClient.Size = new System.Drawing.Size(159, 39);
            this.addClient.TabIndex = 14;
            this.addClient.Text = "Add New Client";
            this.addClient.UseVisualStyleBackColor = true;
            this.addClient.Click += new System.EventHandler(this.addClient_Click);
            // 
            // ClientAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1316, 559);
            this.Controls.Add(this.addClient);
            this.Controls.Add(this.clientCode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.clientAdress);
            this.Controls.Add(this.clientTel);
            this.Controls.Add(this.clientEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clientLastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clientName);
            this.Controls.Add(this.label1);
            this.Name = "ClientAdd";
            this.Load += new System.EventHandler(this.ClientAdd_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.clientName, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.clientLastName, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.clientEmail, 0);
            this.Controls.SetChildIndex(this.clientTel, 0);
            this.Controls.SetChildIndex(this.clientAdress, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.clientCode, 0);
            this.Controls.SetChildIndex(this.addClient, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox clientName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox clientLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox clientEmail;
        private System.Windows.Forms.TextBox clientTel;
        private System.Windows.Forms.TextBox clientAdress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox clientCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addClient;
    }
}
