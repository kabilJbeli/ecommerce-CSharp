
namespace ecommerce
{
    partial class UpdateClientScreen
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.addClient = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clientEmail = new System.Windows.Forms.TextBox();
            this.clientAdress = new System.Windows.Forms.TextBox();
            this.clientLastName = new System.Windows.Forms.TextBox();
            this.clientTel = new System.Windows.Forms.TextBox();
            this.clientCode = new System.Windows.Forms.TextBox();
            this.clientName = new System.Windows.Forms.TextBox();
            this.message = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.addClient, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.clientEmail, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.clientAdress, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.clientLastName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.clientTel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.clientCode, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.clientName, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 75);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1292, 214);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Client Code";
            // 
            // addClient
            // 
            this.addClient.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addClient.Location = new System.Drawing.Point(124, 150);
            this.addClient.Name = "addClient";
            this.addClient.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.addClient.Size = new System.Drawing.Size(159, 39);
            this.addClient.TabIndex = 14;
            this.addClient.Text = "Update  Client";
            this.addClient.UseVisualStyleBackColor = true;
            this.addClient.Click += new System.EventHandler(this.addClient_Click_1);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(664, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Adress";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tel";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Client Last Name";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(664, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(664, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Client Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clientEmail
            // 
            this.clientEmail.Location = new System.Drawing.Point(754, 45);
            this.clientEmail.Multiline = true;
            this.clientEmail.Name = "clientEmail";
            this.clientEmail.Size = new System.Drawing.Size(534, 34);
            this.clientEmail.TabIndex = 7;
            this.clientEmail.TextChanged += new System.EventHandler(this.clientEmail_TextChanged);
            this.clientEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.clientEmail_KeyPress_1);
            // 
            // clientAdress
            // 
            this.clientAdress.Location = new System.Drawing.Point(754, 87);
            this.clientAdress.Multiline = true;
            this.clientAdress.Name = "clientAdress";
            this.clientAdress.Size = new System.Drawing.Size(534, 36);
            this.clientAdress.TabIndex = 9;
            this.clientAdress.TextChanged += new System.EventHandler(this.clientAdress_TextChanged);
            // 
            // clientLastName
            // 
            this.clientLastName.Location = new System.Drawing.Point(124, 45);
            this.clientLastName.Multiline = true;
            this.clientLastName.Name = "clientLastName";
            this.clientLastName.Size = new System.Drawing.Size(534, 36);
            this.clientLastName.TabIndex = 5;
            this.clientLastName.TextChanged += new System.EventHandler(this.clientLastName_TextChanged);
            // 
            // clientTel
            // 
            this.clientTel.Location = new System.Drawing.Point(124, 87);
            this.clientTel.Multiline = true;
            this.clientTel.Name = "clientTel";
            this.clientTel.Size = new System.Drawing.Size(534, 36);
            this.clientTel.TabIndex = 8;
            this.clientTel.TextChanged += new System.EventHandler(this.clientTel_TextChanged);
            this.clientTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.clientTel_KeyPress);
            // 
            // clientCode
            // 
            this.clientCode.Location = new System.Drawing.Point(124, 3);
            this.clientCode.Multiline = true;
            this.clientCode.Name = "clientCode";
            this.clientCode.Size = new System.Drawing.Size(534, 36);
            this.clientCode.TabIndex = 13;
            this.clientCode.TextChanged += new System.EventHandler(this.clientCode_TextChanged);
            // 
            // clientName
            // 
            this.clientName.Location = new System.Drawing.Point(754, 3);
            this.clientName.Multiline = true;
            this.clientName.Name = "clientName";
            this.clientName.Size = new System.Drawing.Size(534, 36);
            this.clientName.TabIndex = 3;
            this.clientName.TextAlignChanged += new System.EventHandler(this.clientName_TextAlignChanged);
            this.clientName.TextChanged += new System.EventHandler(this.clientName_TextChanged);
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.message.ForeColor = System.Drawing.Color.Coral;
            this.message.Location = new System.Drawing.Point(14, 313);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(0, 24);
            this.message.TabIndex = 18;
            this.message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(136, 313);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 17);
            this.errorLabel.TabIndex = 19;
            // 
            // UpdateClientScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1316, 559);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.message);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UpdateClientScreen";
            this.Load += new System.EventHandler(this.UpdateClientScreen_Load);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.message, 0);
            this.Controls.SetChildIndex(this.errorLabel, 0);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addClient;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox clientEmail;
        private System.Windows.Forms.TextBox clientAdress;
        private System.Windows.Forms.TextBox clientLastName;
        private System.Windows.Forms.TextBox clientTel;
        private System.Windows.Forms.TextBox clientCode;
        private System.Windows.Forms.TextBox clientName;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.Label errorLabel;
    }
}
