using Newtonsoft.Json;
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

namespace MovieList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            Options newOptions = new Options();

            newOptions.Show();

            this.WindowState = FormWindowState.Minimized;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Look for start up options txt
            string startUpFile = "StartUpOptions.txt";

            if(File.Exists(startUpFile))
            {
                string json = System.IO.File.ReadAllText(startUpFile);

                OptionDetails startUpOptions = JsonConvert.DeserializeObject<OptionDetails>(json);

                if (startUpOptions.startUp == "Movies Wanted")
                {

                }
                else
                {

                }

            }
            else
            {

            }

        }
    }
}
