using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace MovieList
{
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string startUpOptions = "";

            if (rdMoviesObtained.Checked)
            {
                startUpOptions = "Movies Obtained";
            }

            if (rdMoviesWanted.Checked)
            {
                startUpOptions = "Movies Wanted";
            }

            OptionDetails newOptions = new OptionDetails();
            newOptions.startUp = startUpOptions;

 
            string json = JsonConvert.SerializeObject(newOptions);

            System.IO.File.WriteAllText("StartUpOptions.txt", json);

        }
    }
}
