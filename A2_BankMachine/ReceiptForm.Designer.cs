namespace A2_BankMachine {
    partial class ReceiptForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceiptForm));
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_DateTime = new System.Windows.Forms.Label();
            this.lbl_AccountNum = new System.Windows.Forms.Label();
            this.lbl_TransactionDescription = new System.Windows.Forms.Label();
            this.lbl_TransactionAmount = new System.Windows.Forms.Label();
            this.lbl_NewBalances = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transaction Receipt";
            // 
            // lbl_DateTime
            // 
            this.lbl_DateTime.AutoSize = true;
            this.lbl_DateTime.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DateTime.Location = new System.Drawing.Point(22, 171);
            this.lbl_DateTime.Name = "lbl_DateTime";
            this.lbl_DateTime.Size = new System.Drawing.Size(55, 13);
            this.lbl_DateTime.TabIndex = 1;
            this.lbl_DateTime.Text = "DateTime";
            // 
            // lbl_AccountNum
            // 
            this.lbl_AccountNum.AutoSize = true;
            this.lbl_AccountNum.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AccountNum.Location = new System.Drawing.Point(22, 203);
            this.lbl_AccountNum.Name = "lbl_AccountNum";
            this.lbl_AccountNum.Size = new System.Drawing.Size(67, 13);
            this.lbl_AccountNum.TabIndex = 2;
            this.lbl_AccountNum.Text = "AccountNum";
            // 
            // lbl_TransactionDescription
            // 
            this.lbl_TransactionDescription.AutoSize = true;
            this.lbl_TransactionDescription.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TransactionDescription.Location = new System.Drawing.Point(22, 225);
            this.lbl_TransactionDescription.Name = "lbl_TransactionDescription";
            this.lbl_TransactionDescription.Size = new System.Drawing.Size(181, 13);
            this.lbl_TransactionDescription.TabIndex = 3;
            this.lbl_TransactionDescription.Text = "TransactionType From__ To ___";
            // 
            // lbl_TransactionAmount
            // 
            this.lbl_TransactionAmount.AutoSize = true;
            this.lbl_TransactionAmount.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TransactionAmount.Location = new System.Drawing.Point(22, 264);
            this.lbl_TransactionAmount.Name = "lbl_TransactionAmount";
            this.lbl_TransactionAmount.Size = new System.Drawing.Size(109, 13);
            this.lbl_TransactionAmount.TabIndex = 4;
            this.lbl_TransactionAmount.Text = "TransactionAmount";
            // 
            // lbl_NewBalances
            // 
            this.lbl_NewBalances.AutoSize = true;
            this.lbl_NewBalances.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NewBalances.Location = new System.Drawing.Point(22, 287);
            this.lbl_NewBalances.Name = "lbl_NewBalances";
            this.lbl_NewBalances.Size = new System.Drawing.Size(43, 13);
            this.lbl_NewBalances.TabIndex = 5;
            this.lbl_NewBalances.Text = "label2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(43, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 78);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // ReceiptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(251, 396);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_NewBalances);
            this.Controls.Add(this.lbl_TransactionAmount);
            this.Controls.Add(this.lbl_TransactionDescription);
            this.Controls.Add(this.lbl_AccountNum);
            this.Controls.Add(this.lbl_DateTime);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReceiptForm";
            this.Text = "Receipt";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_DateTime;
        private System.Windows.Forms.Label lbl_AccountNum;
        private System.Windows.Forms.Label lbl_TransactionDescription;
        private System.Windows.Forms.Label lbl_TransactionAmount;
        private System.Windows.Forms.Label lbl_NewBalances;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}