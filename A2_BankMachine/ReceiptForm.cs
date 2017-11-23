using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A2_BankMachine {
    public partial class ReceiptForm : Form {
        public ReceiptForm(string transactionType, double transactionAmount, string transferToAccount, string transferFromAccount, double transferToNewBalance, double transferFromNewBalance, long accountNumber) {
            InitializeComponent();

            lbl_DateTime.Text = "Transaction Time:\n" + DateTime.Now.ToString("yyyy-MM-ddTHH:mm:sszzz");

            if (accountNumber != 0) {
                lbl_AccountNum.Text = censorAccountNum(accountNumber);
            }
            else {
                lbl_AccountNum.Text = "";
            }
            

            switch (transactionType) {
                case "Transfer":
                    lbl_TransactionDescription.Text = "Transaction Description:\nTransfer from " + transferFromAccount + " to " + transferToAccount;
                    lbl_TransactionAmount.Text = "Transfer Amount: $" + transactionAmount.ToString();

                    lbl_NewBalances.Text = "Updated Balances:\nChequing: $" + transferToNewBalance + "\nSavings: $" + transferFromNewBalance;
                    break;
                case "Deposit":
                    lbl_TransactionDescription.Text = "Transaction Description:\nCash Deposit to " + transferToAccount;
                    lbl_TransactionAmount.Text = "Deposit Amount: $" + transactionAmount.ToString();

                    // transferFROMAccount intentionally used here for simplicity...
                    lbl_NewBalances.Text = "Updated Balances:\n" + transferFromAccount + ": $" + transferFromNewBalance;
                    break;
                case "Withdraw":
                    lbl_TransactionDescription.Text = "Transaction Description:\nCash Withdrawal from " + transferFromAccount;
                    lbl_TransactionAmount.Text = "Withdrawal Amount: $" + transactionAmount.ToString();

                    lbl_NewBalances.Text = "Updated Balances:\n" + transferFromAccount + ": $" + transferFromNewBalance;
                    break;
                default:
                    break;
            }
                    

        }

        // Assuming minimum account number length of 4 (TODO: set constraint at login screen submission)
        private string censorAccountNum(long originalAccountNum) {

            string stringAccountNum = originalAccountNum.ToString();

            string censoredNum = new String('*', stringAccountNum.Length - 3) + stringAccountNum.Substring(stringAccountNum.Length - 4, 4);

            return censoredNum;
        }
    }
}
