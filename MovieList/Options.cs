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
using System.IO;

namespace MovieList
{
    public partial class Options : Form
    {
        private OptionDetails startUpOptions;

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

        private void Options_Load(object sender, EventArgs e)
        {
            string startUpFile = "StartUpOptions.txt";

            if (File.Exists(startUpFile))
            {
                string json = System.IO.File.ReadAllText(startUpFile);

                startUpOptions = JsonConvert.DeserializeObject<OptionDetails>(json);

                if (startUpOptions.startUp == "Movies Wanted")
                {
                    rdMoviesWanted.Checked = true;
                }
                else
                {
                    rdMoviesObtained.Checked = true;
                }
            }
            else
            {

            }
        }
    }
}
