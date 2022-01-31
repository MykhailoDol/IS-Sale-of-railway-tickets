using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЛАБА2
{
    public partial class SaveForm : Form
    {
        static TimetableForm form;
        static RequestForm form1;
        static TicketViewForm form3;
        public SaveForm(TimetableForm form1)
        {
            InitializeComponent();
            form = form1;
        }
        public SaveForm(TicketViewForm form1)
        {
            InitializeComponent();
            form3 = form1;
        }
        public SaveForm(RequestForm Form1)
        {
            InitializeComponent();
            form1 = Form1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (form != null)
                form.PrintExel();
            else if (form1 != null)
                form1.PrintExel();
            else
                form3.PrintExel();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (form != null)
                form.PrintTxt();
            else if (form1 != null)
                form1.PrintTxt();
            else
                form3.PrintTxt();
            Close();
        }
    }
}
