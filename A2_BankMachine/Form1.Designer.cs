namespace A2_BankMachine {
    partial class PrimaryForm {
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
            this.pnl_StartScreen = new System.Windows.Forms.Panel();
            this.btn_SubmitAccNum = new System.Windows.Forms.Button();
            this.pnl_PinScreen = new System.Windows.Forms.Panel();
            this.btn_SubmitPin = new System.Windows.Forms.Button();
            this.tb_PinEntry = new System.Windows.Forms.TextBox();
            this.lbl_EnterPin = new System.Windows.Forms.Label();
            this.pnl_ActionScreen = new System.Windows.Forms.Panel();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_Transfers = new System.Windows.Forms.Button();
            this.btn_AccountBalance = new System.Windows.Forms.Button();
            this.btn_Deposit = new System.Windows.Forms.Button();
            this.btn_Withdraw = new System.Windows.Forms.Button();
            this.pnl_Withdraw1 = new System.Windows.Forms.Panel();
            this.btn_WithdrawSavings = new System.Windows.Forms.Button();
            this.btn_WithdrawChequing = new System.Windows.Forms.Button();
            this.lbl_ChooseWithdrawAccount = new System.Windows.Forms.Label();
            this.pnl_Withdraw2 = new System.Windows.Forms.Panel();
            this.btn_Withdraw60 = new System.Windows.Forms.Button();
            this.btn_Withdraw100 = new System.Windows.Forms.Button();
            this.btn_Withdraw40 = new System.Windows.Forms.Button();
            this.btn_Withdraw80 = new System.Windows.Forms.Button();
            this.btn_Withdraw20 = new System.Windows.Forms.Button();
            this.lbl_WithdrawlAmount = new System.Windows.Forms.Label();
            this.pbl_ConfirmWithdrawal = new System.Windows.Forms.Panel();
            this.lbl_ConfirmWithdraw = new System.Windows.Forms.Label();
            this.lbl_WithdrawAmount = new System.Windows.Forms.Label();
            this.lbl_From = new System.Windows.Forms.Label();
            this.lbl_WithdrawAccountConfirm = new System.Windows.Forms.Label();
            this.btn_WithdrawConfirm = new System.Windows.Forms.Button();
            this.btn_WithdrawBack = new System.Windows.Forms.Button();
            this.pnl_WithdrawReceipt = new System.Windows.Forms.Panel();
            this.lbl_WithdrawReceipt = new System.Windows.Forms.Label();
            this.btn_WithdrawReceiptOK = new System.Windows.Forms.Button();
            this.pnl_StartScreen.SuspendLayout();
            this.pnl_PinScreen.SuspendLayout();
            this.pnl_ActionScreen.SuspendLayout();
            this.pnl_Withdraw1.SuspendLayout();
            this.pnl_Withdraw2.SuspendLayout();
            this.pbl_ConfirmWithdrawal.SuspendLayout();
            this.pnl_WithdrawReceipt.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(226, 31);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(172, 25);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Bank of Joseph lol";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_AccountNum
            // 
            this.lbl_AccountNum.AutoSize = true;
            this.lbl_AccountNum.Location = new System.Drawing.Point(163, 82);
            this.lbl_AccountNum.Name = "lbl_AccountNum";
            this.lbl_AccountNum.Size = new System.Drawing.Size(143, 13);
            this.lbl_AccountNum.TabIndex = 1;
            this.lbl_AccountNum.Text = "Enter Your Account Number:";
            // 
            // tb_AccountNumEntry
            // 
            this.tb_AccountNumEntry.Location = new System.Drawing.Point(166, 109);
            this.tb_AccountNumEntry.Name = "tb_AccountNumEntry";
            this.tb_AccountNumEntry.Size = new System.Drawing.Size(303, 20);
            this.tb_AccountNumEntry.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "OR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_TapCard
            // 
            this.btn_TapCard.Location = new System.Drawing.Point(272, 229);
            this.btn_TapCard.Name = "btn_TapCard";
            this.btn_TapCard.Size = new System.Drawing.Size(75, 47);
            this.btn_TapCard.TabIndex = 4;
            this.btn_TapCard.Text = "Tap Card";
            this.btn_TapCard.UseVisualStyleBackColor = true;
            this.btn_TapCard.Click += new System.EventHandler(this.btn_TapCard_Click);
            // 
            // pnl_StartScreen
            // 
            this.pnl_StartScreen.Controls.Add(this.btn_SubmitAccNum);
            this.pnl_StartScreen.Controls.Add(this.btn_TapCard);
            this.pnl_StartScreen.Controls.Add(this.lbl_Title);
            this.pnl_StartScreen.Controls.Add(this.label1);
            this.pnl_StartScreen.Controls.Add(this.tb_AccountNumEntry);
            this.pnl_StartScreen.Controls.Add(this.lbl_AccountNum);
            this.pnl_StartScreen.Location = new System.Drawing.Point(12, 12);
            this.pnl_StartScreen.Name = "pnl_StartScreen";
            this.pnl_StartScreen.Size = new System.Drawing.Size(602, 289);
            this.pnl_StartScreen.TabIndex = 5;
            // 
            // btn_SubmitAccNum
            // 
            this.btn_SubmitAccNum.Location = new System.Drawing.Point(475, 109);
            this.btn_SubmitAccNum.Name = "btn_SubmitAccNum";
            this.btn_SubmitAccNum.Size = new System.Drawing.Size(75, 23);
            this.btn_SubmitAccNum.TabIndex = 0;
            this.btn_SubmitAccNum.Text = "Submit";
            this.btn_SubmitAccNum.Click += new System.EventHandler(this.btn_SubmitAccNum_Click);
            // 
            // pnl_PinScreen
            // 
            this.pnl_PinScreen.Controls.Add(this.btn_SubmitPin);
            this.pnl_PinScreen.Controls.Add(this.tb_PinEntry);
            this.pnl_PinScreen.Controls.Add(this.lbl_EnterPin);
            this.pnl_PinScreen.Location = new System.Drawing.Point(12, 307);
            this.pnl_PinScreen.Name = "pnl_PinScreen";
            this.pnl_PinScreen.Size = new System.Drawing.Size(602, 289);
            this.pnl_PinScreen.TabIndex = 6;
            // 
            // btn_SubmitPin
            // 
            this.btn_SubmitPin.Location = new System.Drawing.Point(338, 99);
            this.btn_SubmitPin.Name = "btn_SubmitPin";
            this.btn_SubmitPin.Size = new System.Drawing.Size(75, 23);
            this.btn_SubmitPin.TabIndex = 2;
            this.btn_SubmitPin.Text = "Submit";
            this.btn_SubmitPin.UseVisualStyleBackColor = true;
            this.btn_SubmitPin.Click += new System.EventHandler(this.btn_SubmitPin_Click);
            // 
            // tb_PinEntry
            // 
            this.tb_PinEntry.Location = new System.Drawing.Point(231, 99);
            this.tb_PinEntry.Name = "tb_PinEntry";
            this.tb_PinEntry.Size = new System.Drawing.Size(100, 20);
            this.tb_PinEntry.TabIndex = 1;
            // 
            // lbl_EnterPin
            // 
            this.lbl_EnterPin.Location = new System.Drawing.Point(231, 73);
            this.lbl_EnterPin.Name = "lbl_EnterPin";
            this.lbl_EnterPin.Size = new System.Drawing.Size(100, 23);
            this.lbl_EnterPin.TabIndex = 3;
            this.lbl_EnterPin.Text = "Enter Your 4 Digit Pin:";
            // 
            // pnl_ActionScreen
            // 
            this.pnl_ActionScreen.Controls.Add(this.btn_Logout);
            this.pnl_ActionScreen.Controls.Add(this.btn_Transfers);
            this.pnl_ActionScreen.Controls.Add(this.btn_AccountBalance);
            this.pnl_ActionScreen.Controls.Add(this.btn_Deposit);
            this.pnl_ActionScreen.Controls.Add(this.btn_Withdraw);
            this.pnl_ActionScreen.Location = new System.Drawing.Point(621, 12);
            this.pnl_ActionScreen.Name = "pnl_ActionScreen";
            this.pnl_ActionScreen.Size = new System.Drawing.Size(602, 289);
            this.pnl_ActionScreen.TabIndex = 7;
            // 
            // btn_Logout
            // 
            this.btn_Logout.Location = new System.Drawing.Point(236, 192);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(106, 23);
            this.btn_Logout.TabIndex = 4;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = true;
            // 
            // btn_Transfers
            // 
            this.btn_Transfers.Location = new System.Drawing.Point(236, 162);
            this.btn_Transfers.Name = "btn_Transfers";
            this.btn_Transfers.Size = new System.Drawing.Size(106, 23);
            this.btn_Transfers.TabIndex = 3;
            this.btn_Transfers.Text = "Tranfers";
            this.btn_Transfers.UseVisualStyleBackColor = true;
            // 
            // btn_AccountBalance
            // 
            this.btn_AccountBalance.Location = new System.Drawing.Point(236, 132);
            this.btn_AccountBalance.Name = "btn_AccountBalance";
            this.btn_AccountBalance.Size = new System.Drawing.Size(106, 23);
            this.btn_AccountBalance.TabIndex = 2;
            this.btn_AccountBalance.Text = "Account Balance";
            this.btn_AccountBalance.UseVisualStyleBackColor = true;
            // 
            // btn_Deposit
            // 
            this.btn_Deposit.Location = new System.Drawing.Point(236, 102);
            this.btn_Deposit.Name = "btn_Deposit";
            this.btn_Deposit.Size = new System.Drawing.Size(106, 23);
            this.btn_Deposit.TabIndex = 1;
            this.btn_Deposit.Text = "Deposit";
            this.btn_Deposit.UseVisualStyleBackColor = true;
            // 
            // btn_Withdraw
            // 
            this.btn_Withdraw.Location = new System.Drawing.Point(236, 72);
            this.btn_Withdraw.Name = "btn_Withdraw";
            this.btn_Withdraw.Size = new System.Drawing.Size(106, 23);
            this.btn_Withdraw.TabIndex = 0;
            this.btn_Withdraw.Text = "Withdraw";
            this.btn_Withdraw.UseVisualStyleBackColor = true;
            // 
            // pnl_Withdraw1
            // 
            this.pnl_Withdraw1.Controls.Add(this.btn_WithdrawSavings);
            this.pnl_Withdraw1.Controls.Add(this.btn_WithdrawChequing);
            this.pnl_Withdraw1.Controls.Add(this.lbl_ChooseWithdrawAccount);
            this.pnl_Withdraw1.Location = new System.Drawing.Point(621, 307);
            this.pnl_Withdraw1.Name = "pnl_Withdraw1";
            this.pnl_Withdraw1.Size = new System.Drawing.Size(602, 289);
            this.pnl_Withdraw1.TabIndex = 8;
            // 
            // btn_WithdrawSavings
            // 
            this.btn_WithdrawSavings.Location = new System.Drawing.Point(236, 128);
            this.btn_WithdrawSavings.Name = "btn_WithdrawSavings";
            this.btn_WithdrawSavings.Size = new System.Drawing.Size(75, 23);
            this.btn_WithdrawSavings.TabIndex = 2;
            this.btn_WithdrawSavings.Text = "Savings";
            this.btn_WithdrawSavings.UseVisualStyleBackColor = true;
            // 
            // btn_WithdrawChequing
            // 
            this.btn_WithdrawChequing.Location = new System.Drawing.Point(236, 98);
            this.btn_WithdrawChequing.Name = "btn_WithdrawChequing";
            this.btn_WithdrawChequing.Size = new System.Drawing.Size(75, 23);
            this.btn_WithdrawChequing.TabIndex = 1;
            this.btn_WithdrawChequing.Text = "Chequing";
            this.btn_WithdrawChequing.UseVisualStyleBackColor = true;
            // 
            // lbl_ChooseWithdrawAccount
            // 
            this.lbl_ChooseWithdrawAccount.AutoSize = true;
            this.lbl_ChooseWithdrawAccount.Location = new System.Drawing.Point(205, 62);
            this.lbl_ChooseWithdrawAccount.Name = "lbl_ChooseWithdrawAccount";
            this.lbl_ChooseWithdrawAccount.Size = new System.Drawing.Size(190, 13);
            this.lbl_ChooseWithdrawAccount.TabIndex = 0;
            this.lbl_ChooseWithdrawAccount.Text = "Choose an Account to Withdraw From:";
            // 
            // pnl_Withdraw2
            // 
            this.pnl_Withdraw2.Controls.Add(this.btn_Withdraw60);
            this.pnl_Withdraw2.Controls.Add(this.btn_Withdraw100);
            this.pnl_Withdraw2.Controls.Add(this.btn_Withdraw40);
            this.pnl_Withdraw2.Controls.Add(this.btn_Withdraw80);
            this.pnl_Withdraw2.Controls.Add(this.btn_Withdraw20);
            this.pnl_Withdraw2.Controls.Add(this.lbl_WithdrawlAmount);
            this.pnl_Withdraw2.Location = new System.Drawing.Point(12, 603);
            this.pnl_Withdraw2.Name = "pnl_Withdraw2";
            this.pnl_Withdraw2.Size = new System.Drawing.Size(602, 289);
            this.pnl_Withdraw2.TabIndex = 9;
            // 
            // btn_Withdraw60
            // 
            this.btn_Withdraw60.Location = new System.Drawing.Point(205, 190);
            this.btn_Withdraw60.Name = "btn_Withdraw60";
            this.btn_Withdraw60.Size = new System.Drawing.Size(75, 23);
            this.btn_Withdraw60.TabIndex = 5;
            this.btn_Withdraw60.Text = "$60";
            this.btn_Withdraw60.UseVisualStyleBackColor = true;
            // 
            // btn_Withdraw100
            // 
            this.btn_Withdraw100.Location = new System.Drawing.Point(287, 161);
            this.btn_Withdraw100.Name = "btn_Withdraw100";
            this.btn_Withdraw100.Size = new System.Drawing.Size(75, 23);
            this.btn_Withdraw100.TabIndex = 4;
            this.btn_Withdraw100.Text = "$100";
            this.btn_Withdraw100.UseVisualStyleBackColor = true;
            // 
            // btn_Withdraw40
            // 
            this.btn_Withdraw40.Location = new System.Drawing.Point(205, 161);
            this.btn_Withdraw40.Name = "btn_Withdraw40";
            this.btn_Withdraw40.Size = new System.Drawing.Size(75, 23);
            this.btn_Withdraw40.TabIndex = 3;
            this.btn_Withdraw40.Text = "$40";
            this.btn_Withdraw40.UseVisualStyleBackColor = true;
            // 
            // btn_Withdraw80
            // 
            this.btn_Withdraw80.Location = new System.Drawing.Point(287, 131);
            this.btn_Withdraw80.Name = "btn_Withdraw80";
            this.btn_Withdraw80.Size = new System.Drawing.Size(75, 23);
            this.btn_Withdraw80.TabIndex = 2;
            this.btn_Withdraw80.Text = "$80";
            this.btn_Withdraw80.UseVisualStyleBackColor = true;
            // 
            // btn_Withdraw20
            // 
            this.btn_Withdraw20.Location = new System.Drawing.Point(205, 131);
            this.btn_Withdraw20.Name = "btn_Withdraw20";
            this.btn_Withdraw20.Size = new System.Drawing.Size(75, 23);
            this.btn_Withdraw20.TabIndex = 1;
            this.btn_Withdraw20.Text = "$20";
            this.btn_Withdraw20.UseVisualStyleBackColor = true;
            // 
            // lbl_WithdrawlAmount
            // 
            this.lbl_WithdrawlAmount.AutoSize = true;
            this.lbl_WithdrawlAmount.Location = new System.Drawing.Point(189, 58);
            this.lbl_WithdrawlAmount.Name = "lbl_WithdrawlAmount";
            this.lbl_WithdrawlAmount.Size = new System.Drawing.Size(257, 13);
            this.lbl_WithdrawlAmount.TabIndex = 0;
            this.lbl_WithdrawlAmount.Text = "How Much Would You Like to Withdraw From ____?";
            // 
            // pbl_ConfirmWithdrawal
            // 
            this.pbl_ConfirmWithdrawal.Controls.Add(this.btn_WithdrawBack);
            this.pbl_ConfirmWithdrawal.Controls.Add(this.btn_WithdrawConfirm);
            this.pbl_ConfirmWithdrawal.Controls.Add(this.lbl_WithdrawAccountConfirm);
            this.pbl_ConfirmWithdrawal.Controls.Add(this.lbl_From);
            this.pbl_ConfirmWithdrawal.Controls.Add(this.lbl_WithdrawAmount);
            this.pbl_ConfirmWithdrawal.Controls.Add(this.lbl_ConfirmWithdraw);
            this.pbl_ConfirmWithdrawal.Location = new System.Drawing.Point(621, 603);
            this.pbl_ConfirmWithdrawal.Name = "pbl_ConfirmWithdrawal";
            this.pbl_ConfirmWithdrawal.Size = new System.Drawing.Size(602, 289);
            this.pbl_ConfirmWithdrawal.TabIndex = 11;
            // 
            // lbl_ConfirmWithdraw
            // 
            this.lbl_ConfirmWithdraw.AutoSize = true;
            this.lbl_ConfirmWithdraw.Location = new System.Drawing.Point(246, 49);
            this.lbl_ConfirmWithdraw.Name = "lbl_ConfirmWithdraw";
            this.lbl_ConfirmWithdraw.Size = new System.Drawing.Size(65, 13);
            this.lbl_ConfirmWithdraw.TabIndex = 0;
            this.lbl_ConfirmWithdraw.Text = "Confirmation";
            // 
            // lbl_WithdrawAmount
            // 
            this.lbl_WithdrawAmount.AutoSize = true;
            this.lbl_WithdrawAmount.Location = new System.Drawing.Point(214, 131);
            this.lbl_WithdrawAmount.Name = "lbl_WithdrawAmount";
            this.lbl_WithdrawAmount.Size = new System.Drawing.Size(31, 13);
            this.lbl_WithdrawAmount.TabIndex = 1;
            this.lbl_WithdrawAmount.Text = "$___";
            // 
            // lbl_From
            // 
            this.lbl_From.AutoSize = true;
            this.lbl_From.Location = new System.Drawing.Point(265, 131);
            this.lbl_From.Name = "lbl_From";
            this.lbl_From.Size = new System.Drawing.Size(27, 13);
            this.lbl_From.TabIndex = 2;
            this.lbl_From.Text = "from";
            // 
            // lbl_WithdrawAccountConfirm
            // 
            this.lbl_WithdrawAccountConfirm.AutoSize = true;
            this.lbl_WithdrawAccountConfirm.Location = new System.Drawing.Point(298, 131);
            this.lbl_WithdrawAccountConfirm.Name = "lbl_WithdrawAccountConfirm";
            this.lbl_WithdrawAccountConfirm.Size = new System.Drawing.Size(44, 13);
            this.lbl_WithdrawAccountConfirm.TabIndex = 3;
            this.lbl_WithdrawAccountConfirm.Text = "Ch/Sav";
            // 
            // btn_WithdrawConfirm
            // 
            this.btn_WithdrawConfirm.Location = new System.Drawing.Point(249, 190);
            this.btn_WithdrawConfirm.Name = "btn_WithdrawConfirm";
            this.btn_WithdrawConfirm.Size = new System.Drawing.Size(75, 23);
            this.btn_WithdrawConfirm.TabIndex = 4;
            this.btn_WithdrawConfirm.Text = "Confirm";
            this.btn_WithdrawConfirm.UseVisualStyleBackColor = true;
            // 
            // btn_WithdrawBack
            // 
            this.btn_WithdrawBack.Location = new System.Drawing.Point(249, 219);
            this.btn_WithdrawBack.Name = "btn_WithdrawBack";
            this.btn_WithdrawBack.Size = new System.Drawing.Size(75, 23);
            this.btn_WithdrawBack.TabIndex = 5;
            this.btn_WithdrawBack.Text = "Back";
            this.btn_WithdrawBack.UseVisualStyleBackColor = true;
            // 
            // pnl_WithdrawReceipt
            // 
            this.pnl_WithdrawReceipt.Controls.Add(this.btn_WithdrawReceiptOK);
            this.pnl_WithdrawReceipt.Controls.Add(this.lbl_WithdrawReceipt);
            this.pnl_WithdrawReceipt.Location = new System.Drawing.Point(12, 898);
            this.pnl_WithdrawReceipt.Name = "pnl_WithdrawReceipt";
            this.pnl_WithdrawReceipt.Size = new System.Drawing.Size(602, 289);
            this.pnl_WithdrawReceipt.TabIndex = 12;
            // 
            // lbl_WithdrawReceipt
            // 
            this.lbl_WithdrawReceipt.AutoSize = true;
            this.lbl_WithdrawReceipt.Location = new System.Drawing.Point(213, 78);
            this.lbl_WithdrawReceipt.Name = "lbl_WithdrawReceipt";
            this.lbl_WithdrawReceipt.Size = new System.Drawing.Size(173, 13);
            this.lbl_WithdrawReceipt.TabIndex = 0;
            this.lbl_WithdrawReceipt.Text = "$__ has been withdrawn from ____";
            // 
            // btn_WithdrawReceiptOK
            // 
            this.btn_WithdrawReceiptOK.Location = new System.Drawing.Point(244, 130);
            this.btn_WithdrawReceiptOK.Name = "btn_WithdrawReceiptOK";
            this.btn_WithdrawReceiptOK.Size = new System.Drawing.Size(75, 23);
            this.btn_WithdrawReceiptOK.TabIndex = 1;
            this.btn_WithdrawReceiptOK.Text = "OK";
            this.btn_WithdrawReceiptOK.UseVisualStyleBackColor = true;
            // 
            // PrimaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 1366);
            this.Controls.Add(this.pnl_WithdrawReceipt);
            this.Controls.Add(this.pbl_ConfirmWithdrawal);
            this.Controls.Add(this.pnl_Withdraw2);
            this.Controls.Add(this.pnl_Withdraw1);
            this.Controls.Add(this.pnl_ActionScreen);
            this.Controls.Add(this.pnl_StartScreen);
            this.Controls.Add(this.pnl_PinScreen);
            this.Name = "PrimaryForm";
            this.Text = "Screen 1";
            this.pnl_StartScreen.ResumeLayout(false);
            this.pnl_StartScreen.PerformLayout();
            this.pnl_PinScreen.ResumeLayout(false);
            this.pnl_PinScreen.PerformLayout();
            this.pnl_ActionScreen.ResumeLayout(false);
            this.pnl_Withdraw1.ResumeLayout(false);
            this.pnl_Withdraw1.PerformLayout();
            this.pnl_Withdraw2.ResumeLayout(false);
            this.pnl_Withdraw2.PerformLayout();
            this.pbl_ConfirmWithdrawal.ResumeLayout(false);
            this.pbl_ConfirmWithdrawal.PerformLayout();
            this.pnl_WithdrawReceipt.ResumeLayout(false);
            this.pnl_WithdrawReceipt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_AccountNum;
        private System.Windows.Forms.TextBox tb_AccountNumEntry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_TapCard;
        private System.Windows.Forms.Panel pnl_StartScreen;
        private System.Windows.Forms.Button btn_SubmitAccNum;
        private System.Windows.Forms.Panel pnl_PinScreen;
        private System.Windows.Forms.Label lbl_EnterPin;
        private System.Windows.Forms.Button btn_SubmitPin;
        private System.Windows.Forms.TextBox tb_PinEntry;
        private System.Windows.Forms.Panel pnl_ActionScreen;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_Transfers;
        private System.Windows.Forms.Button btn_AccountBalance;
        private System.Windows.Forms.Button btn_Deposit;
        private System.Windows.Forms.Button btn_Withdraw;
        private System.Windows.Forms.Panel pnl_Withdraw1;
        private System.Windows.Forms.Label lbl_ChooseWithdrawAccount;
        private System.Windows.Forms.Button btn_WithdrawSavings;
        private System.Windows.Forms.Button btn_WithdrawChequing;
        private System.Windows.Forms.Panel pnl_Withdraw2;
        private System.Windows.Forms.Label lbl_WithdrawlAmount;
        private System.Windows.Forms.Button btn_Withdraw60;
        private System.Windows.Forms.Button btn_Withdraw100;
        private System.Windows.Forms.Button btn_Withdraw40;
        private System.Windows.Forms.Button btn_Withdraw80;
        private System.Windows.Forms.Button btn_Withdraw20;
        private System.Windows.Forms.Panel pbl_ConfirmWithdrawal;
        private System.Windows.Forms.Label lbl_ConfirmWithdraw;
        private System.Windows.Forms.Button btn_WithdrawBack;
        private System.Windows.Forms.Button btn_WithdrawConfirm;
        private System.Windows.Forms.Label lbl_WithdrawAccountConfirm;
        private System.Windows.Forms.Label lbl_From;
        private System.Windows.Forms.Label lbl_WithdrawAmount;
        private System.Windows.Forms.Panel pnl_WithdrawReceipt;
        private System.Windows.Forms.Button btn_WithdrawReceiptOK;
        private System.Windows.Forms.Label lbl_WithdrawReceipt;
    }
}

