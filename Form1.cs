using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextControlExtensionMethods;
using TXTextControl;

namespace tx_applying_master_templates
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textControl1.Load("document1.tx", TXTextControl.StreamType.InternalUnicodeFormat);
        }

        private void applyMasterTemplateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textControl1.ApplyMasterTemplate("master.tx", StreamType.InternalUnicodeFormat);
        }
    }
}
