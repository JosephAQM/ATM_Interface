namespace A2_BankMachine {
    partial class Screen_1 {
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
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_AccountNum = new System.Windows.Forms.Label();
            this.tb_AccountNumEntry = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_TapCard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(241, 71);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(172, 25);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Bank of Joseph lol";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_Title.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_AccountNum
            // 
            this.lbl_AccountNum.AutoSize = true;
            this.lbl_AccountNum.Location = new System.Drawing.Point(173, 155);
            this.lbl_AccountNum.Name = "lbl_AccountNum";
            this.lbl_AccountNum.Size = new System.Drawing.Size(143, 13);
            this.lbl_AccountNum.TabIndex = 1;
            this.lbl_AccountNum.Text = "Enter Your Account Number:";
            // 
            // tb_AccountNumEntry
            // 
            this.tb_AccountNumEntry.Location = new System.Drawing.Point(176, 182);
            this.tb_AccountNumEntry.Name = "tb_AccountNumEntry";
            this.tb_AccountNumEntry.Size = new System.Drawing.Size(303, 20);
            this.tb_AccountNumEntry.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(305, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "OR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_TapCard
            // 
            this.btn_TapCard.Location = new System.Drawing.Point(282, 302);
            this.btn_TapCard.Name = "btn_TapCard";
            this.btn_TapCard.Size = new System.Drawing.Size(75, 47);
            this.btn_TapCard.TabIndex = 4;
            this.btn_TapCard.Text = "Tap Card";
            this.btn_TapCard.UseVisualStyleBackColor = true;
            // 
            // Screen_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 426);
            this.Controls.Add(this.btn_TapCard);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_AccountNumEntry);
            this.Controls.Add(this.lbl_AccountNum);
            this.Controls.Add(this.lbl_Title);
            this.Name = "Screen_1";
            this.Text = "Screen 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_AccountNum;
        private System.Windows.Forms.TextBox tb_AccountNumEntry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_TapCard;
    }
}

