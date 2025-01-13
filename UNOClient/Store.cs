using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnoOnline
{
    public partial class Store : Form
    {
        public Store()
        {
            InitializeComponent();
            SetMoneyLabel();
        }
        public void SetMoneyLabel()
        {
            MoneyLabel.Text = "Money: " + GameManager.Instance.Players[0].Money.ToString();
        }
        public int Card1Value = 0;
        int Card2Value = 200;
        private void Card1_Click(object sender, EventArgs e)
        {
            if (GameManager.Instance.Players[0].Money >= Card1Value)
            {
                GameManager.Instance.Players[0].Money -= Card1Value;
                MessageBox.Show("You have bought this card.");
            }
            else
            {
                MessageBox.Show("You don't have enough money to buy this card.");
            }
        }

        private void Card2_Click(object sender, EventArgs e)
        {
            if (GameManager.Instance.Players[0].Money >= Card2Value)
            {
                GameManager.Instance.Players[0].Money -= Card2Value;
                SetMoneyLabel();
                ClientSocket.SendData(new Message(MessageType.BuyCard, new List<string> {GameManager.Instance.Players[0].Name, "-200"}));
                MessageBox.Show("You have bought this card.");
            }
            else
            {
                MessageBox.Show("You don't have enough money to buy this card.");
            }
        }
    }
}
