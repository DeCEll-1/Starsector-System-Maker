using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarsectorSystemMaker
{
    public partial class BaseForm : Form
    {


        public BaseForm()
        {
            InitializeComponent();

            Statics.AppPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

            FileInfo ficonfig = new FileInfo(Statics.AppPath + "config.txt");

            if (!ficonfig.Exists)
            {




            }


        }

        private void TSMI_Help_Click(object sender, EventArgs e)
        {
            
        }
    }
}
