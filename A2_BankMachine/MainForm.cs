﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace A2_BankMachine {

    public partial class PrimaryForm : Form {

        private long accountNumber; // Can be string... but used for int check

        private double savingsBalance = 1000.00;
        private double chequingBalance = 500.00;

        private double WDAmount; // Withdrawal or deposit amount
        private string actionTypeSelected; // To note withdrawal or deposit selection
        private string accountTypeSelected; // To note whether savings or chequings has been seleceted

        private string transferFromAccountType;
        private string transferToAccountType;
        private double transferAmount;

        private string pin;

        string ToOrFrom;

        public PrimaryForm() {
            InitializeComponent();
            this.Size = new System.Drawing.Size(602, 328);
        }

        public void ActivateScreen(string screenSelect) {
            HideAllScreens();


            switch (screenSelect) {
                case "Start":
                    pnl_StartScreen.Location = new System.Drawing.Point(0, 0);
                    break;
                case "Pin":
                    pnl_PinScreen.Location = new System.Drawing.Point(0, 0);
                    break;
                case "Action":
                    pnl_ActionScreen.Location = new System.Drawing.Point(0, 0);
                    break;
                case "WithdrawDeposit1":
                    pnl_WithdrawDeposit1.Location = new System.Drawing.Point(0, 0);
                    break;
                case "WithdrawDeposit2":
                    pnl_WithdrawDeposit2.Location = new System.Drawing.Point(0, 0);
                    break;
                case "ConfirmWD":
                    pnl_ConfirmWD.Location = new System.Drawing.Point(0, 0);
                    break;
                case "WDReceipt":
                    pnl_WDReceipt.Location = new System.Drawing.Point(0, 0);
                    break;
                case "ContinueBankingPrompt":
                    pnl_ContinueBankingPrompt.Location = new System.Drawing.Point(0, 0);
                    break;
                case "AccountBalance1":
                    pnl_AccountBalance1.Location = new System.Drawing.Point(0, 0);
                    break;
                case "AccountBalance2":
                    pnl_AccountBalance2.Location = new System.Drawing.Point(0, 0);
                    break;
                case "Transfers1":
                    pnl_Transfers1.Location = new System.Drawing.Point(0, 0);
                    break;
                case "Transfers2":
                    pnl_Transfers2.Location = new System.Drawing.Point(0, 0);
                    break;
                case "Transfers3":
                    pnl_Transfers3.Location = new System.Drawing.Point(0, 0);
                    break;
                case "Transfers4":
                    pnl_Transfers4.Location = new System.Drawing.Point(0, 0);
                    break;
                case "Transfers5":
                    pnl_Transfers5.Location = new System.Drawing.Point(0, 0);
                    break;
                case "WDOther":
                    pnl_WDOther.Location = new System.Drawing.Point(0, 0);
                    break;
                default:
                    break;
            }
        }

        
        public void HideAllScreens() {
            pnl_StartScreen.Location = new System.Drawing.Point(999, 999);
            pnl_PinScreen.Location = new System.Drawing.Point(999, 999);
            pnl_ActionScreen.Location = new System.Drawing.Point(999, 999);
            pnl_WithdrawDeposit1.Location = new System.Drawing.Point(999, 999);
            pnl_WithdrawDeposit2.Location = new System.Drawing.Point(999, 999);
            pnl_ConfirmWD.Location = new System.Drawing.Point(999, 999);
            pnl_WDReceipt.Location = new System.Drawing.Point(999, 999);
            pnl_ContinueBankingPrompt.Location = new System.Drawing.Point(999, 999);
            pnl_AccountBalance1.Location = new System.Drawing.Point(999, 999);
            pnl_AccountBalance2.Location = new System.Drawing.Point(999, 999);
            pnl_Transfers1.Location = new System.Drawing.Point(999, 999);
            pnl_Transfers2.Location = new System.Drawing.Point(999, 999);
            pnl_Transfers3.Location = new System.Drawing.Point(999, 999);
            pnl_Transfers4.Location = new System.Drawing.Point(999, 999);
            pnl_Transfers5.Location = new System.Drawing.Point(999, 999);
            pnl_WDOther.Location = new System.Drawing.Point(999, 999);
        }

        private void beep() {
            SoundPlayer audio = new SoundPlayer(A2_BankMachine.Properties.Resources._4HC3_beep); // here WindowsFormsApplication1 is the namespace and Connect is the audio file name
            audio.Play();
        }

        private void scanBeep() {
            SoundPlayer audio = new SoundPlayer(A2_BankMachine.Properties.Resources._4HC3_scan); // here WindowsFormsApplication1 is the namespace and Connect is the audio file name
            audio.Play();
        }

        private void errorBeep() {
            SoundPlayer audio = new SoundPlayer(A2_BankMachine.Properties.Resources._4HC3_error); // here WindowsFormsApplication1 is the namespace and Connect is the audio file name
            audio.Play();
        }

        private void btn_TapCard_Click(object sender, EventArgs e) {
            scanBeep();
            ActivateScreen("Pin");
        }

        private void btn_SubmitAccNum_Click(object sender, EventArgs e) {
            if (tb_AccountNumEntry.Text == "") {
                lbl_AccountNumberError.Text = "Error: Please enter an account number.";
                lbl_AccountNumberError.Visible = true;
                errorBeep();
            }
            else if (!Int64.TryParse(tb_AccountNumEntry.Text, out accountNumber)) {
                lbl_AccountNumberError.Text = "Error: Account number can only contain numbers.";
                lbl_AccountNumberError.Visible = true;
                errorBeep();
            }
            else if (tb_AccountNumEntry.Text.Length != 10) {
                lbl_AccountNumberError.Text = "Error: Account number must be 10 digits long.";
                lbl_AccountNumberError.Visible = true;
                errorBeep();
            }
            else {
                lbl_AccountNumberError.Visible = false;
                tb_PinEntry.Text = "";

                beep();
                ActivateScreen("Pin");
            }
            
        }

        private void btn_SubmitPin_Click(object sender, EventArgs e) {
            int testIfInt = 0;

            if (tb_PinEntry.Text.Length != 4) {
                lbl_PinError.Text = "Error: PIN must contain 4 digits";
                lbl_PinError.Visible = true;
                errorBeep();
            }
            else if (!Int32.TryParse(tb_PinEntry.Text, out testIfInt)) {
                lbl_PinError.Text = "Error: PIN must contain only numbers";
                lbl_PinError.Visible = true;
                errorBeep();
            }
            else {
                lbl_PinError.Visible = false;
                beep();
                ActivateScreen("Action");
                tb_PinEntry.Text = "";
            }
            
        }

        private void btn_Withdraw_Click(object sender, EventArgs e) {
            actionTypeSelected = "Withdraw";
            lbl_ChooseWDAccount.Text = "Choose an account to withdraw from:";
            beep();
            ActivateScreen("WithdrawDeposit1");
        }

        private void btn_Deposit_Click(object sender, EventArgs e) {
            actionTypeSelected = "Deposit";
            lbl_ChooseWDAccount.Text = "Choose an account to deposit to:";
            beep();
            ActivateScreen("WithdrawDeposit1");
        }

        private void btn_WDChequing_Click(object sender, EventArgs e) {
            accountTypeSelected = "Chequing";

            ToOrFrom = "";
            if (actionTypeSelected == "Deposit") { ToOrFrom = "to"; }
            else if (actionTypeSelected == "Withdraw") { ToOrFrom = "from"; }

            lbl_WDAmount.Text = "How much would you like to " + actionTypeSelected + " " + ToOrFrom + " " + accountTypeSelected + "?";
            beep();
            ActivateScreen("WithdrawDeposit2");
        }

        private void btn_WDSavings_Click(object sender, EventArgs e) {
            accountTypeSelected = "Savings";

            ToOrFrom = "";
            if (actionTypeSelected == "Deposit") { ToOrFrom = "to"; }
            else if (actionTypeSelected == "Withdraw") { ToOrFrom = "from"; }

            lbl_WDAmount.Text = "How much would you like to " + actionTypeSelected + " " + ToOrFrom + " " + accountTypeSelected + "?";

            beep();
            ActivateScreen("WithdrawDeposit2");
        }

        private void btn_WD20_Click(object sender, EventArgs e) {
            WDAmount = 20.00;
            ContinueToWDConfirm();
        }

        private void btn_WD40_Click(object sender, EventArgs e) {
            WDAmount = 40.00;
            ContinueToWDConfirm();
        }

        private void btn_WD60_Click(object sender, EventArgs e) {
            WDAmount = 60.00;
            ContinueToWDConfirm();
        }

        private void btn_WD80_Click(object sender, EventArgs e) {
            WDAmount = 80.00;
            ContinueToWDConfirm();
        }

        private void btn_WD100_Click(object sender, EventArgs e) {
            WDAmount = 100.00;
            ContinueToWDConfirm();
        }

        private void ContinueToWDConfirm() {
            lbl_WDConfirmText.Text = actionTypeSelected + " $" + WDAmount + " " + ToOrFrom + " " + accountTypeSelected + "?";
            beep();
            ActivateScreen("ConfirmWD");
        }

        private void btn_WDConfirm_Click(object sender, EventArgs e) {
            if (actionTypeSelected == "Deposit") {
                if (accountTypeSelected == "Chequing") { chequingBalance += WDAmount; }
                else if (accountTypeSelected == "Savings") { savingsBalance += WDAmount; }
            }
            else if (actionTypeSelected == "Withdraw") { // Negative balance allowed
                if (accountTypeSelected == "Chequing") { chequingBalance -= WDAmount; }
                else if (accountTypeSelected == "Savings") { savingsBalance -= WDAmount; }
            }

            ContinueToWDReceipt();
        }

        private void ContinueToWDReceipt() {
            string ed_or_n = "";
            if (actionTypeSelected == "Deposit" ) { ed_or_n = "ed"; }
            else if (actionTypeSelected == "Withdraw") { ed_or_n = "n"; }

            lbl_WDReceipt.Text = "$" + WDAmount + " " + actionTypeSelected + ed_or_n + " " + ToOrFrom + " " + accountTypeSelected;

            if (accountTypeSelected == "Chequing") { lbl_NewBalance.Text = "New " + accountTypeSelected + " account balance: $" + chequingBalance; }
            else if (accountTypeSelected == "Savings") { lbl_NewBalance.Text = "New " + accountTypeSelected + " account balance: $" + savingsBalance; }

            beep();
            ActivateScreen("WDReceipt");
        }

        private void btn_WDReceiptOK_Click(object sender, EventArgs e) {
            beep();
            ActivateScreen("ContinueBankingPrompt");
        }

        private void btn_ContinueYes_Click(object sender, EventArgs e) {
            beep();
            ActivateScreen("Action");
        }

        private void btn_ContinueLogout_Click(object sender, EventArgs e) {
            tb_AccountNumEntry.Text = "";
            beep();
            ActivateScreen("Start");
        }

        private void btn_AccountBalance_Click(object sender, EventArgs e) {
            beep();
            ActivateScreen("AccountBalance1");

        }

        private void btn_ViewBalanceChequing_Click(object sender, EventArgs e) {
            accountTypeSelected = "Chequing";
            lbl_VBAccountType.Text = "Chequing Account Balance:";
            lbl_VBAccountBalance.Text = "$" + chequingBalance;
            beep();
            ActivateScreen("AccountBalance2");
        }

        private void btn_ViewBalanceSavings_Click(object sender, EventArgs e) {
            accountTypeSelected = "Savings";
            lbl_VBAccountType.Text = "Savings Account Balance:";
            lbl_VBAccountBalance.Text = "$" + savingsBalance;
            beep();
            ActivateScreen("AccountBalance2");
        }

        private void lbl_VBOK_Click(object sender, EventArgs e) {
            beep();
            ActivateScreen("ContinueBankingPrompt");
        }

        private void btn_Transfer1Chequing_Click(object sender, EventArgs e) {
            transferFromAccountType = "Chequing";
            btn_Transfer2Chequing.Enabled = false;
            btn_Transfer2Chequing.Visible = false;
            beep();
            ActivateScreen("Transfers2");
        }

        private void btn_Transfer1Savings_Click(object sender, EventArgs e) {
            transferFromAccountType = "Savings";
            btn_Transfer2Savings.Enabled = false;
            btn_Transfer2Savings.Visible = false;
            beep();
            ActivateScreen("Transfers2");
        }

        private void btn_Transfer2Chequing_Click(object sender, EventArgs e) {
            transferToAccountType = "Chequing";
            lbl_Transfer3.Text = "Enter the amount to transfer from " + transferFromAccountType + " to " + transferToAccountType;

            btn_Transfer2Chequing.Enabled = true;
            btn_Transfer2Chequing.Visible = true;
            beep();
            ActivateScreen("Transfers3");
        }

        private void btn_Transfer2Savings_Click(object sender, EventArgs e) {
            transferToAccountType = "Savings";
            lbl_Transfer3.Text = "Enter the amount to transfer from " + transferFromAccountType + " to " + transferToAccountType;
            btn_Transfer2Savings.Enabled = true;
            btn_Transfer2Savings.Visible = true;
            beep();
            ActivateScreen("Transfers3");
        }

        private void btn_Transfer3OK_Click(object sender, EventArgs e) {
            double fromAccountBalance = 0;

            if (transferFromAccountType == "Chequing") { fromAccountBalance = chequingBalance; }
            else if (transferFromAccountType == "Savings") { fromAccountBalance = savingsBalance; }

            if (!Double.TryParse(tb_TransferAmount.Text, out transferAmount)) {
                lbl_Transfer3Error.Text = "Error: Transfer amount must be a number";
                lbl_Transfer3Error.Visible = true;
                errorBeep();
            }
            else if (transferAmount > fromAccountBalance) {
                lbl_Transfer3Error.Text = "Error: Insufficient funds";
                lbl_Transfer3Error.Visible = true;
                errorBeep();
            }
            else { // No issues
                lbl_Transfer3Error.Visible = false;

                lbl_Transfer4.Text = "Transfer $" + transferAmount + " from " + transferFromAccountType + " to " + transferToAccountType + "?";

                beep();
                ActivateScreen("Transfers4");
            }
        }

        private void btn_Transfer4Yes_Click(object sender, EventArgs e) {
            if (transferFromAccountType == "Chequing") { chequingBalance -= transferAmount; }
            else if (transferFromAccountType == "Savings") { savingsBalance -= transferAmount; }

            if (transferToAccountType == "Chequing") { chequingBalance += transferAmount; }
            else if (transferToAccountType == "Savings") { savingsBalance += transferAmount; }

            lbl_T5NewChequingBalance.Text = "New Chequing Account Balance: $" + chequingBalance;
            lbl_T5NewSavingsBalance.Text = "New Savings Account Balance: $" + savingsBalance;

            beep();
            ActivateScreen("Transfers5");
        }

        private void btn_Transfer5OK_Click(object sender, EventArgs e) {
            beep();
            ActivateScreen("ContinueBankingPrompt");
        }

        private void btn_Transfer3Back_Click(object sender, EventArgs e) {
            beep();
            ActivateScreen("Transfers2");
        }

        private void btn_Transfer4Back_Click(object sender, EventArgs e) {
            beep();
            ActivateScreen("Transfers3");
        }

        private void btn_Transfers_Click(object sender, EventArgs e) {
            beep();
            ActivateScreen("Transfers1");
        }

        private void btn_Logout_Click(object sender, EventArgs e) {
            tb_AccountNumEntry.Text = "";
            ActivateScreen("Start");
            beep();
        }

        private void btn_Back0_Click(object sender, EventArgs e) {
            tb_AccountNumEntry.Text = "";
            beep();
            ActivateScreen("Start");
        }

        private void btn_Back1_Click(object sender, EventArgs e) {
            beep();
            ActivateScreen("Action");
        }

        private void button1_Click(object sender, EventArgs e) {
            beep();
            ActivateScreen("WithdrawDeposit1");
        }

        private void btn_Back2_Click(object sender, EventArgs e) {
            beep();
            ActivateScreen("Action");
        }

        private void btn_Back3_Click(object sender, EventArgs e) {
            beep();
            ActivateScreen("Action");
        }

        private void btn_Back4_Click(object sender, EventArgs e) {
            beep();
            ActivateScreen("Transfers1");
            btn_Transfer2Chequing.Enabled = true;
            btn_Transfer2Savings.Enabled = true;

            btn_Transfer2Chequing.Visible = true;
            btn_Transfer2Savings.Visible = true;
        }

        private void btn_test_Click(object sender, EventArgs e) {
            printReceipt("Transfer", 100, "Chequing", "Savings", 1100, 900, 0123456789);
        }

        public void printReceipt(string transactionType, double transactionAmount, string transferToAccount, string transferFromAccount, double transferToNewBalance, double transferFromNewBalance, long accountNumber) {
            ReceiptForm form_Receipt = new ReceiptForm(transactionType, transactionAmount, transferToAccount, transferFromAccount, transferToNewBalance, transferFromNewBalance, accountNumber);
            form_Receipt.ShowDialog();
        }

        private void btn_PrintReceiptDW_Click(object sender, EventArgs e) {
            double fromBalance = 0;

            if (accountTypeSelected == "Chequing") {
                fromBalance = chequingBalance;
            }
            else if (accountTypeSelected == "Savings") {
                fromBalance = savingsBalance;
            }
            printReceipt(actionTypeSelected, WDAmount, accountTypeSelected, accountTypeSelected, 0, fromBalance, accountNumber);
        }

        //actually btn_PrintReceiptTransfers... doesnt auto update, scared to change it
        private void button2_Click(object sender, EventArgs e) {
            beep();
            printReceipt("Transfer", transferAmount, transferToAccountType, transferFromAccountType, chequingBalance, savingsBalance, accountNumber);
        }

        private void btn_WDOther_Click(object sender, EventArgs e) {
            ToOrFrom = "";
            if (actionTypeSelected == "Deposit") { ToOrFrom = "to"; }
            else if (actionTypeSelected == "Withdraw") { ToOrFrom = "from"; }

            lbl_WDOtherText.Text = "Enter amount to " + actionTypeSelected + " " + ToOrFrom + " " + accountTypeSelected;
            beep();
            ActivateScreen("WDOther");
        }

        private void btn_WDOtherConfirm_Click(object sender, EventArgs e) {
            double fromAccountBalance = 0;

            if (accountTypeSelected == "Chequing") { fromAccountBalance = chequingBalance; }
            else if (accountTypeSelected == "Savings") { fromAccountBalance = savingsBalance; }

            if (!Double.TryParse(tb_WDOther.Text, out WDAmount)) {
                lbl_WDOtherError.Text = "Error: Transfer amount must be a number";
                lbl_WDOtherError.Visible = true;
                errorBeep();
            }
            else if ((WDAmount > fromAccountBalance) && (actionTypeSelected == "Withdraw")) {
                lbl_WDOtherError.Text = "Error: Insufficient funds";
                lbl_WDOtherError.Visible = true;
                errorBeep();
            }
            else if (WDAmount % 10 != 0) {
                lbl_WDOtherError.Text = "Error: This machine only dispenses/accepts\n$10, $20, and $50 bills";
                lbl_WDOtherError.Visible = true;
                errorBeep();
            }
            else { // No issues
                lbl_WDOtherError.Visible = false;

                //lbl_WDOtherText.Text = "Transfer $" + WDAmount + " from " + transferFromAccountType + " to " + transferToAccountType + "?";



                beep();
                ContinueToWDConfirm();
            }
        }

        private void btn_WDBack_Click(object sender, EventArgs e) {
            beep();
            ActivateScreen("WithdrawDeposit2");
        }

        private void btn_WDOtherBack_Click(object sender, EventArgs e) {
            beep();
            ActivateScreen("WithdrawDeposit2");
        }

        private void tb_PinEntry_TextChanged(object sender, EventArgs e) {
            pin += tb_PinEntry.Text.Replace("*", "");
            beep();
            //tb_PinEntry.Text = "hello";//new string('*', pin.Length);
        }

    }

}

