using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace LaboratorioScienze
{
    public partial class AddMonth : Form
    {
        private Excel.Worksheet currentWS;
        private Excel.Worksheet lastWS;
        private string getMonth(int mn)
        {
            switch (mn)
            {
                case 1: return "Gennaio"; break;
                case 2: return "Febbraio"; break;
                case 3: return "Marzo"; break;
                case 4: return "Aprile"; break;
                case 5: return "Maggio"; break;
                case 6: return "Giugno"; break;
                case 7: return "Luglio"; break;
                case 8: return "Agosto"; break;
                case 9: return "Settembre"; break;
                case 10: return "Ottobre"; break;
                case 11: return "Novembre"; break;
                case 12: return "Dicembre"; break;
                default: return ""; break;
            }
        }

        private void setupSheet()
        {
            DateTime now = DateTime.Now;
            lastWS.Copy(currentWS);
            currentWS = (Excel.Worksheet)Globals.ThisWorkbook.ActiveSheet;
            currentWS.Name = getMonth((int)month.Value);
            int i;
            for (i = 2; i <= 32; i++)
            {
                currentWS.Cells.set_Item(i, "A", (i - 1) + " " + getMonth((int)month.Value));
            }
        }
        private void newMonth()
        {
            DateTime now = DateTime.Now;
            if (currentWS.Name != getMonth(now.Month))
            {
                setupSheet();
            }
            else
            {
            }
        }
        public AddMonth()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            lbl_Mese.Text = getMonth((int)month.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lastWS = (Excel.Worksheet)Globals.ThisWorkbook.ActiveSheet;
            currentWS = (Excel.Worksheet)Globals.ThisWorkbook.ActiveSheet;
            setupSheet();
            this.Close();
        }
    }
}
