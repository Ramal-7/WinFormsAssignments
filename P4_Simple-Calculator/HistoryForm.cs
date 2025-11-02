using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P4_Simple_Calculator
{
    public partial class HistoryForm : Form
    {
        public HistoryForm(List<string>history)
        {
            InitializeComponent();
            this.Text = "Calculation History Ramal30";
            foreach (string calculation in history)
            {
                listBoxHistory.Items.Add(calculation);
            }

        }
    }
}
