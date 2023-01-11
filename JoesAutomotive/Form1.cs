using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoesAutomotive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int servicecost = 0;
        private float customcost = 0;

        private int Turnintoint(string inputstring, int biggerthen = 0)
        {
            int inputnum;
            bool passesdparse = int.TryParse(inputstring, out inputnum);
            if (passesdparse && inputnum > biggerthen) { return inputnum; }
            else { return biggerthen - 1; }
        }

        private void checkinputed(float inputint, TextBox affectedTB)
        {
            if (inputint > 0) { affectedTB.Text = inputint.ToString(); }
            else { affectedTB.Text = ""; }
        }

        private void calculatetotal()
        {
            float taxcost = (servicecost + customcost) / 20;
            float totalcost = (servicecost + customcost) + taxcost;
            checkinputed(taxcost, taxTB);
            checkinputed(totalcost, totalTB);
        }

        private void addcostCBL(int[] costs, CheckedListBox checkedCBL)
        {
            
            for (int i = 0; i < costs.Length; i++)
            {
                if (checkedCBL.GetItemChecked(i))
                {
                    servicecost += costs[i];
                }
            }
            checkinputed(servicecost, serviceTB);
            calculatetotal();
        }

        private void calculatecustom()
        {
            customcost = 0;
            int partscost = Turnintoint(partsTB.Text);
            int laborcost = Turnintoint(laborTB.Text);
            if (partscost > 0 && laborcost > 0)
            {
                customcost = partscost + (laborcost * 20);
            }
            checkinputed(customcost, partsandlaborTB);
            calculatetotal();
        }

        private void oilandlubeCBL_SelectedIndexChanged(object sender, EventArgs e)
        {
            int[] oilandlubecosts = { 26, 18 };
            int[] flushescosts = { 30, 80 };
            int[] misccosts = { 15, 100, 20 };
            servicecost = 0;
            addcostCBL(oilandlubecosts, oilandlubeCBL);
            addcostCBL(flushescosts, flushesCBL);
            addcostCBL(misccosts, miscCBL);
        }

        private void flushesCBL_SelectedIndexChanged(object sender, EventArgs e)
        {
            int[] oilandlubecosts = { 26, 18 };
            int[] flushescosts = { 30, 80 };
            int[] misccosts = { 15, 100, 20 };
            servicecost = 0;
            addcostCBL(oilandlubecosts, oilandlubeCBL);
            addcostCBL(flushescosts, flushesCBL);
            addcostCBL(misccosts, miscCBL);
        }

        private void miscCBL_SelectedIndexChanged(object sender, EventArgs e)
        {
            int[] oilandlubecosts = { 26, 18 };
            int[] flushescosts = { 30, 80 };
            int[] misccosts = { 15, 100, 20 };
            servicecost = 0;
            addcostCBL(oilandlubecosts, oilandlubeCBL);
            addcostCBL(flushescosts, flushesCBL);
            addcostCBL(misccosts, miscCBL);
        }

        private void partsTB_TextChanged(object sender, EventArgs e)
        {
            calculatecustom();
        }

        private void laborTB_TextChanged(object sender, EventArgs e)
        {
            calculatecustom();
        }

        private void clearBUT_Click(object sender, EventArgs e)
        {
            oilandlubeCBL.SetItemChecked(0, false);
            oilandlubeCBL.SetItemChecked(1, false);
            flushesCBL.SetItemChecked(0, false);
            flushesCBL.SetItemChecked(1, false);
            miscCBL.SetItemChecked(0, false);
            miscCBL.SetItemChecked(1, false);
            miscCBL.SetItemChecked(2, false);
            partsTB.Text = "";
            laborTB.Text = "";
            serviceTB.Text = "";
            partsandlaborTB.Text = "";
            taxTB.Text = "";
            totalTB.Text = "";
        }
    }
}
