using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.Office.Tools.Excel;
using Microsoft.VisualStudio.Tools.Applications.Runtime;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;

namespace LaboratorioScienze
{
    public partial class Sheet1
    {
        private Excel.Worksheet currentWS;
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
            Globals.Sheet1.Copy(currentWS);
            Globals.Sheet1.Visible = Excel.XlSheetVisibility.xlSheetHidden;
            currentWS = (Excel.Worksheet)Globals.ThisWorkbook.ActiveSheet;
            currentWS.Name = getMonth(now.Month);
            for (int i = 2; i <= 32; i++)
            {
                currentWS.Cells.set_Item(i, "A", (i - 1) + " " + getMonth(now.Month));
            }
        }
        private void newMonth()
        {
            DateTime now = DateTime.Now;
            if (Globals.ThisWorkbook.Sheets.Count == 1)
            {
                setupSheet();
            }
            else
            {
            }
        }
        private void Sheet1_Startup(object sender, System.EventArgs e)
        {
            currentWS = (Excel.Worksheet)Globals.ThisWorkbook.ActiveSheet;
            newMonth();
        }

        private void Sheet1_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region VSTO Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(Sheet1_Startup);
            this.Shutdown += new System.EventHandler(Sheet1_Shutdown);
        }

        #endregion

    }
}
