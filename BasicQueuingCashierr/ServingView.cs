using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicQueuingCashierr
{
    public partial class ServingView : Form
    {
        Timer timer = new Timer();
        CashierClass cashier;
        public ServingView()
        {
            InitializeComponent();
            cashier = new CashierClass();

            timer.Interval = 1000;
            timer.Tick += new EventHandler(ServingView_Load);
            timer.Start();
        }

        private void ServingView_Load(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }
        public void DisplayCashierQueue(IEnumerable CashierList)
        {
            foreach (object obj in CashierList)
            {
                if (obj != null)
                {
                    lblQueue.Text = CashierClass.CashierQueue.Peek().ToString();
                }
            }
        }
    }
}
