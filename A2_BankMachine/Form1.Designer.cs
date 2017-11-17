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
            this.lbl_AccountNumberError = new System.Windows.Forms.Label();
            this.btn_SubmitAccNum = new System.Windows.Forms.Button();
            this.pnl_PinScreen = new System.Windows.Forms.Panel();
            this.lbl_PinError = new System.Windows.Forms.Label();
            this.btn_SubmitPin = new System.Windows.Forms.Button();
            this.tb_PinEntry = new System.Windows.Forms.TextBox();
            this.lbl_EnterPin = new System.Windows.Forms.Label();
            this.pnl_ActionScreen = new System.Windows.Forms.Panel();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_Transfers = new System.Windows.Forms.Button();
            this.btn_AccountBalance = new System.Windows.Forms.Button();
            this.btn_Deposit = new System.Windows.Forms.Button();
            this.btn_Withdraw = new System.Windows.Forms.Button();
            this.pnl_WithdrawDeposit1 = new System.Windows.Forms.Panel();
            this.btn_WDSavings = new System.Windows.Forms.Button();
            this.btn_WDChequing = new System.Windows.Forms.Button();
            this.lbl_ChooseWDAccount = new System.Windows.Forms.Label();
            this.pnl_WithdrawDeposit2 = new System.Windows.Forms.Panel();
            this.btn_WD60 = new System.Windows.Forms.Button();
            this.btn_WD100 = new System.Windows.Forms.Button();
            this.btn_WD40 = new System.Windows.Forms.Button();
            this.btn_WD80 = new System.Windows.Forms.Button();
            this.btn_WD20 = new System.Windows.Forms.Button();
            this.lbl_WDAmount = new System.Windows.Forms.Label();
            this.pnl_ConfirmWD = new System.Windows.Forms.Panel();
            this.btn_WDBack = new System.Windows.Forms.Button();
            this.btn_WDConfirm = new System.Windows.Forms.Button();
            this.lbl_WDConfirmText = new System.Windows.Forms.Label();
            this.lbl_ConfirmWD = new System.Windows.Forms.Label();
            this.pnl_WDReceipt = new System.Windows.Forms.Panel();
            this.lbl_NewBalance = new System.Windows.Forms.Label();
            this.btn_WDReceiptOK = new System.Windows.Forms.Button();
            this.lbl_WDReceipt = new System.Windows.Forms.Label();
            this.pnl_ContinueBankingPrompt = new System.Windows.Forms.Panel();
            this.btn_ContinueLogout = new System.Windows.Forms.Button();
            this.btn_ContinueYes = new System.Windows.Forms.Button();
            this.lbl_ContinueBanking = new System.Windows.Forms.Label();
            this.pnl_StartScreen.SuspendLayout();
            this.pnl_PinScreen.SuspendLayout();
            this.pnl_ActionScreen.SuspendLayout();
            this.pnl_WithdrawDeposit1.SuspendLayout();
            this.pnl_WithdrawDeposit2.SuspendLayout();
            this.pnl_ConfirmWD.SuspendLayout();
            this.pnl_WDReceipt.SuspendLayout();
            this.pnl_ContinueBankingPrompt.SuspendLayout();
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
            this.pnl_StartScreen.Controls.Add(this.lbl_AccountNumberError);
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
            // lbl_AccountNumberError
            // 
            this.lbl_AccountNumberError.AutoSize = true;
            this.lbl_AccountNumberError.ForeColor = System.Drawing.Color.Red;
            this.lbl_AccountNumberError.Location = new System.Drawing.Point(166, 141);
            this.lbl_AccountNumberError.Name = "lbl_AccountNumberError";
            this.lbl_AccountNumberError.Size = new System.Drawing.Size(56, 13);
            this.lbl_AccountNumberError.TabIndex = 5;
            this.lbl_AccountNumberError.Text = "Error_Text";
            this.lbl_AccountNumberError.Visible = false;
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
            this.pnl_PinScreen.Controls.Add(this.lbl_PinError);
            this.pnl_PinScreen.Controls.Add(this.btn_SubmitPin);
            this.pnl_PinScreen.Controls.Add(this.tb_PinEntry);
            this.pnl_PinScreen.Controls.Add(this.lbl_EnterPin);
            this.pnl_PinScreen.Location = new System.Drawing.Point(12, 307);
            this.pnl_PinScreen.Name = "pnl_PinScreen";
            this.pnl_PinScreen.Size = new System.Drawing.Size(602, 289);
            this.pnl_PinScreen.TabIndex = 6;
            // 
            // lbl_PinError
            // 
            this.lbl_PinError.AutoSize = true;
            this.lbl_PinError.ForeColor = System.Drawing.Color.Red;
            this.lbl_PinError.Location = new System.Drawing.Point(231, 126);
            this.lbl_PinError.Name = "lbl_PinError";
            this.lbl_PinError.Size = new System.Drawing.Size(56, 13);
            this.lbl_PinError.TabIndex = 4;
            this.lbl_PinError.Text = "Error_Text";
            this.lbl_PinError.Visible = false;
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
            this.btn_Deposit.Click += new System.EventHandler(this.btn_Deposit_Click);
            // 
            // btn_Withdraw
            // 
            this.btn_Withdraw.Location = new System.Drawing.Point(236, 72);
            this.btn_Withdraw.Name = "btn_Withdraw";
            this.btn_Withdraw.Size = new System.Drawing.Size(106, 23);
            this.btn_Withdraw.TabIndex = 0;
            this.btn_Withdraw.Text = "Withdraw";
            this.btn_Withdraw.UseVisualStyleBackColor = true;
            this.btn_Withdraw.Click += new System.EventHandler(this.btn_Withdraw_Click);
            // 
            // pnl_WithdrawDeposit1
            // 
            this.pnl_WithdrawDeposit1.Controls.Add(this.btn_WDSavings);
            this.pnl_WithdrawDeposit1.Controls.Add(this.btn_WDChequing);
            this.pnl_WithdrawDeposit1.Controls.Add(this.lbl_ChooseWDAccount);
            this.pnl_WithdrawDeposit1.Location = new System.Drawing.Point(621, 307);
            this.pnl_WithdrawDeposit1.Name = "pnl_WithdrawDeposit1";
            this.pnl_WithdrawDeposit1.Size = new System.Drawing.Size(602, 289);
            this.pnl_WithdrawDeposit1.TabIndex = 8;
            // 
            // btn_WDSavings
            // 
            this.btn_WDSavings.Location = new System.Drawing.Point(236, 128);
            this.btn_WDSavings.Name = "btn_WDSavings";
            this.btn_WDSavings.Size = new System.Drawing.Size(75, 23);
            this.btn_WDSavings.TabIndex = 2;
            this.btn_WDSavings.Text = "Savings";
            this.btn_WDSavings.UseVisualStyleBackColor = true;
            this.btn_WDSavings.Click += new System.EventHandler(this.btn_WDSavings_Click);
            // 
            // btn_WDChequing
            // 
            this.btn_WDChequing.Location = new System.Drawing.Point(236, 98);
            this.btn_WDChequing.Name = "btn_WDChequing";
            this.btn_WDChequing.Size = new System.Drawing.Size(75, 23);
            this.btn_WDChequing.TabIndex = 1;
            this.btn_WDChequing.Text = "Chequing";
            this.btn_WDChequing.UseVisualStyleBackColor = true;
            this.btn_WDChequing.Click += new System.EventHandler(this.btn_WDChequing_Click);
            // 
            // lbl_ChooseWDAccount
            // 
            this.lbl_ChooseWDAccount.AutoSize = true;
            this.lbl_ChooseWDAccount.Location = new System.Drawing.Point(205, 62);
            this.lbl_ChooseWDAccount.Name = "lbl_ChooseWDAccount";
            this.lbl_ChooseWDAccount.Size = new System.Drawing.Size(190, 13);
            this.lbl_ChooseWDAccount.TabIndex = 0;
            this.lbl_ChooseWDAccount.Text = "Choose an Account to Withdraw From:";
            // 
            // pnl_WithdrawDeposit2
            // 
            this.pnl_WithdrawDeposit2.Controls.Add(this.btn_WD60);
            this.pnl_WithdrawDeposit2.Controls.Add(this.btn_WD100);
            this.pnl_WithdrawDeposit2.Controls.Add(this.btn_WD40);
            this.pnl_WithdrawDeposit2.Controls.Add(this.btn_WD80);
            this.pnl_WithdrawDeposit2.Controls.Add(this.btn_WD20);
            this.pnl_WithdrawDeposit2.Controls.Add(this.lbl_WDAmount);
            this.pnl_WithdrawDeposit2.Location = new System.Drawing.Point(12, 603);
            this.pnl_WithdrawDeposit2.Name = "pnl_WithdrawDeposit2";
            this.pnl_WithdrawDeposit2.Size = new System.Drawing.Size(602, 289);
            this.pnl_WithdrawDeposit2.TabIndex = 9;
            // 
            // btn_WD60
            // 
            this.btn_WD60.Location = new System.Drawing.Point(205, 190);
            this.btn_WD60.Name = "btn_WD60";
            this.btn_WD60.Size = new System.Drawing.Size(75, 23);
            this.btn_WD60.TabIndex = 5;
            this.btn_WD60.Text = "$60";
            this.btn_WD60.UseVisualStyleBackColor = true;
            this.btn_WD60.Click += new System.EventHandler(this.btn_WD60_Click);
            // 
            // btn_WD100
            // 
            this.btn_WD100.Location = new System.Drawing.Point(287, 161);
            this.btn_WD100.Name = "btn_WD100";
            this.btn_WD100.Size = new System.Drawing.Size(75, 23);
            this.btn_WD100.TabIndex = 4;
            this.btn_WD100.Text = "$100";
            this.btn_WD100.UseVisualStyleBackColor = true;
            this.btn_WD100.Click += new System.EventHandler(this.btn_WD100_Click);
            // 
            // btn_WD40
            // 
            this.btn_WD40.Location = new System.Drawing.Point(205, 161);
            this.btn_WD40.Name = "btn_WD40";
            this.btn_WD40.Size = new System.Drawing.Size(75, 23);
            this.btn_WD40.TabIndex = 3;
            this.btn_WD40.Text = "$40";
            this.btn_WD40.UseVisualStyleBackColor = true;
            this.btn_WD40.Click += new System.EventHandler(this.btn_WD40_Click);
            // 
            // btn_WD80
            // 
            this.btn_WD80.Location = new System.Drawing.Point(287, 131);
            this.btn_WD80.Name = "btn_WD80";
            this.btn_WD80.Size = new System.Drawing.Size(75, 23);
            this.btn_WD80.TabIndex = 2;
            this.btn_WD80.Text = "$80";
            this.btn_WD80.UseVisualStyleBackColor = true;
            this.btn_WD80.Click += new System.EventHandler(this.btn_WD80_Click);
            // 
            // btn_WD20
            // 
            this.btn_WD20.Location = new System.Drawing.Point(205, 131);
            this.btn_WD20.Name = "btn_WD20";
            this.btn_WD20.Size = new System.Drawing.Size(75, 23);
            this.btn_WD20.TabIndex = 1;
            this.btn_WD20.Text = "$20";
            this.btn_WD20.UseVisualStyleBackColor = true;
            this.btn_WD20.Click += new System.EventHandler(this.btn_WD20_Click);
            // 
            // lbl_WDAmount
            // 
            this.lbl_WDAmount.AutoSize = true;
            this.lbl_WDAmount.Location = new System.Drawing.Point(189, 58);
            this.lbl_WDAmount.Name = "lbl_WDAmount";
            this.lbl_WDAmount.Size = new System.Drawing.Size(257, 13);
            this.lbl_WDAmount.TabIndex = 0;
            this.lbl_WDAmount.Text = "How Much Would You Like to Withdraw From ____?";
            // 
            // pnl_ConfirmWD
            // 
            this.pnl_ConfirmWD.Controls.Add(this.btn_WDBack);
            this.pnl_ConfirmWD.Controls.Add(this.btn_WDConfirm);
            this.pnl_ConfirmWD.Controls.Add(this.lbl_WDConfirmText);
            this.pnl_ConfirmWD.Controls.Add(this.lbl_ConfirmWD);
            this.pnl_ConfirmWD.Location = new System.Drawing.Point(621, 603);
            this.pnl_ConfirmWD.Name = "pnl_ConfirmWD";
            this.pnl_ConfirmWD.Size = new System.Drawing.Size(602, 289);
            this.pnl_ConfirmWD.TabIndex = 11;
            // 
            // btn_WDBack
            // 
            this.btn_WDBack.Location = new System.Drawing.Point(249, 219);
            this.btn_WDBack.Name = "btn_WDBack";
            this.btn_WDBack.Size = new System.Drawing.Size(75, 23);
            this.btn_WDBack.TabIndex = 5;
            this.btn_WDBack.Text = "Back";
            this.btn_WDBack.UseVisualStyleBackColor = true;
            // 
            // btn_WDConfirm
            // 
            this.btn_WDConfirm.Location = new System.Drawing.Point(249, 190);
            this.btn_WDConfirm.Name = "btn_WDConfirm";
            this.btn_WDConfirm.Size = new System.Drawing.Size(75, 23);
            this.btn_WDConfirm.TabIndex = 4;
            this.btn_WDConfirm.Text = "Confirm";
            this.btn_WDConfirm.UseVisualStyleBackColor = true;
            this.btn_WDConfirm.Click += new System.EventHandler(this.btn_WDConfirm_Click);
            // 
            // lbl_WDConfirmText
            // 
            this.lbl_WDConfirmText.AutoSize = true;
            this.lbl_WDConfirmText.Location = new System.Drawing.Point(214, 131);
            this.lbl_WDConfirmText.Name = "lbl_WDConfirmText";
            this.lbl_WDConfirmText.Size = new System.Drawing.Size(31, 13);
            this.lbl_WDConfirmText.TabIndex = 1;
            this.lbl_WDConfirmText.Text = "$___";
            // 
            // lbl_ConfirmWD
            // 
            this.lbl_ConfirmWD.AutoSize = true;
            this.lbl_ConfirmWD.Location = new System.Drawing.Point(246, 49);
            this.lbl_ConfirmWD.Name = "lbl_ConfirmWD";
            this.lbl_ConfirmWD.Size = new System.Drawing.Size(65, 13);
            this.lbl_ConfirmWD.TabIndex = 0;
            this.lbl_ConfirmWD.Text = "Confirmation";
            // 
            // pnl_WDReceipt
            // 
            this.pnl_WDReceipt.Controls.Add(this.lbl_NewBalance);
            this.pnl_WDReceipt.Controls.Add(this.btn_WDReceiptOK);
            this.pnl_WDReceipt.Controls.Add(this.lbl_WDReceipt);
            this.pnl_WDReceipt.Location = new System.Drawing.Point(12, 898);
            this.pnl_WDReceipt.Name = "pnl_WDReceipt";
            this.pnl_WDReceipt.Size = new System.Drawing.Size(602, 289);
            this.pnl_WDReceipt.TabIndex = 12;
            // 
            // lbl_NewBalance
            // 
            this.lbl_NewBalance.AutoSize = true;
            this.lbl_NewBalance.Location = new System.Drawing.Point(189, 85);
            this.lbl_NewBalance.Name = "lbl_NewBalance";
            this.lbl_NewBalance.Size = new System.Drawing.Size(191, 13);
            this.lbl_NewBalance.TabIndex = 2;
            this.lbl_NewBalance.Text = "New Chequings/Savings Balance: $__";
            // 
            // btn_WDReceiptOK
            // 
            this.btn_WDReceiptOK.Location = new System.Drawing.Point(256, 129);
            this.btn_WDReceiptOK.Name = "btn_WDReceiptOK";
            this.btn_WDReceiptOK.Size = new System.Drawing.Size(75, 23);
            this.btn_WDReceiptOK.TabIndex = 1;
            this.btn_WDReceiptOK.Text = "OK";
            this.btn_WDReceiptOK.UseVisualStyleBackColor = true;
            this.btn_WDReceiptOK.Click += new System.EventHandler(this.btn_WDReceiptOK_Click);
            // 
            // lbl_WDReceipt
            // 
            this.lbl_WDReceipt.AutoSize = true;
            this.lbl_WDReceipt.Location = new System.Drawing.Point(189, 63);
            this.lbl_WDReceipt.Name = "lbl_WDReceipt";
            this.lbl_WDReceipt.Size = new System.Drawing.Size(238, 13);
            this.lbl_WDReceipt.TabIndex = 0;
            this.lbl_WDReceipt.Text = "$__ has been withdrawn/deposited from/to ____";
            // 
            // pnl_ContinueBankingPrompt
            // 
            this.pnl_ContinueBankingPrompt.Controls.Add(this.btn_ContinueLogout);
            this.pnl_ContinueBankingPrompt.Controls.Add(this.btn_ContinueYes);
            this.pnl_ContinueBankingPrompt.Controls.Add(this.lbl_ContinueBanking);
            this.pnl_ContinueBankingPrompt.Location = new System.Drawing.Point(621, 898);
            this.pnl_ContinueBankingPrompt.Name = "pnl_ContinueBankingPrompt";
            this.pnl_ContinueBankingPrompt.Size = new System.Drawing.Size(602, 289);
            this.pnl_ContinueBankingPrompt.TabIndex = 13;
            // 
            // btn_ContinueLogout
            // 
            this.btn_ContinueLogout.Location = new System.Drawing.Point(249, 129);
            this.btn_ContinueLogout.Name = "btn_ContinueLogout";
            this.btn_ContinueLogout.Size = new System.Drawing.Size(75, 23);
            this.btn_ContinueLogout.TabIndex = 2;
            this.btn_ContinueLogout.Text = "Logout";
            this.btn_ContinueLogout.UseVisualStyleBackColor = true;
            this.btn_ContinueLogout.Click += new System.EventHandler(this.btn_ContinueLogout_Click);
            // 
            // btn_ContinueYes
            // 
            this.btn_ContinueYes.Location = new System.Drawing.Point(249, 100);
            this.btn_ContinueYes.Name = "btn_ContinueYes";
            this.btn_ContinueYes.Size = new System.Drawing.Size(75, 23);
            this.btn_ContinueYes.TabIndex = 1;
            this.btn_ContinueYes.Text = "Yes";
            this.btn_ContinueYes.UseVisualStyleBackColor = true;
            this.btn_ContinueYes.Click += new System.EventHandler(this.btn_ContinueYes_Click);
            // 
            // lbl_ContinueBanking
            // 
            this.lbl_ContinueBanking.AutoSize = true;
            this.lbl_ContinueBanking.Location = new System.Drawing.Point(205, 63);
            this.lbl_ContinueBanking.Name = "lbl_ContinueBanking";
            this.lbl_ContinueBanking.Size = new System.Drawing.Size(180, 13);
            this.lbl_ContinueBanking.TabIndex = 0;
            this.lbl_ContinueBanking.Text = "Would you like to continue banking?";
            // 
            // PrimaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 1700);
            this.Controls.Add(this.pnl_ContinueBankingPrompt);
            this.Controls.Add(this.pnl_WDReceipt);
            this.Controls.Add(this.pnl_ConfirmWD);
            this.Controls.Add(this.pnl_WithdrawDeposit2);
            this.Controls.Add(this.pnl_WithdrawDeposit1);
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
            this.pnl_WithdrawDeposit1.ResumeLayout(false);
            this.pnl_WithdrawDeposit1.PerformLayout();
            this.pnl_WithdrawDeposit2.ResumeLayout(false);
            this.pnl_WithdrawDeposit2.PerformLayout();
            this.pnl_ConfirmWD.ResumeLayout(false);
            this.pnl_ConfirmWD.PerformLayout();
            this.pnl_WDReceipt.ResumeLayout(false);
            this.pnl_WDReceipt.PerformLayout();
            this.pnl_ContinueBankingPrompt.ResumeLayout(false);
            this.pnl_ContinueBankingPrompt.PerformLayout();
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
        private System.Windows.Forms.Panel pnl_WithdrawDeposit1;
        private System.Windows.Forms.Label lbl_ChooseWDAccount;
        private System.Windows.Forms.Button btn_WDSavings;
        private System.Windows.Forms.Button btn_WDChequing;
        private System.Windows.Forms.Panel pnl_WithdrawDeposit2;
        private System.Windows.Forms.Label lbl_WDAmount;
        private System.Windows.Forms.Button btn_WD60;
        private System.Windows.Forms.Button btn_WD100;
        private System.Windows.Forms.Button btn_WD40;
        private System.Windows.Forms.Button btn_WD80;
        private System.Windows.Forms.Button btn_WD20;
        private System.Windows.Forms.Panel pnl_ConfirmWD;
        private System.Windows.Forms.Label lbl_ConfirmWD;
        private System.Windows.Forms.Button btn_WDBack;
        private System.Windows.Forms.Button btn_WDConfirm;
        private System.Windows.Forms.Label lbl_WDConfirmText;
        private System.Windows.Forms.Panel pnl_WDReceipt;
        private System.Windows.Forms.Button btn_WDReceiptOK;
        private System.Windows.Forms.Label lbl_WDReceipt;
        private System.Windows.Forms.Panel pnl_ContinueBankingPrompt;
        private System.Windows.Forms.Button btn_ContinueLogout;
        private System.Windows.Forms.Button btn_ContinueYes;
        private System.Windows.Forms.Label lbl_ContinueBanking;
        private System.Windows.Forms.Label lbl_AccountNumberError;
        private System.Windows.Forms.Label lbl_PinError;
        private System.Windows.Forms.Label lbl_NewBalance;
    }
}

