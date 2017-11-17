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

    public partial class PrimaryForm : Form {

        private string accountNumber;
        private float actionAmount; 

        public PrimaryForm() {
            InitializeComponent();
            this.Size = new System.Drawing.Size(700,400);
        }

        public void ActivateScreen(string screenSelect) {
            HideAllScreens();

            switch (screenSelect) {
                case "Start":
                    pnl_StartScreen.Location = new System.Drawing.Point(12, 12);
                    break;
                case "Pin":
                    pnl_PinScreen.Location = new System.Drawing.Point(12, 12);
                    break;
                case "Action":
                    pnl_ActionScreen.Location = new System.Drawing.Point(12, 12);
                    break;
                case "Withdraw1":
                    pnl_Withdraw1.Location = new System.Drawing.Point(12, 12);
                    break;
                default:
                    break;
            }
        }

        
        public void HideAllScreens() {
            pnl_StartScreen.Location = new System.Drawing.Point(999, 999);
            pnl_PinScreen.Location = new System.Drawing.Point(999, 999);
            pnl_ActionScreen.Location = new System.Drawing.Point(999, 999);
            pnl_Withdraw1.Location = new System.Drawing.Point(999, 999);
        }

        private void btn_TapCard_Click(object sender, EventArgs e) {
            ActivateScreen("Pin");
        }

        private void btn_SubmitAccNum_Click(object sender, EventArgs e) {
            ActivateScreen("Pin");
        }

        private void btn_SubmitPin_Click(object sender, EventArgs e) {
            ActivateScreen("Action");
        }

    }

}

