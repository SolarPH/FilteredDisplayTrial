using FilteredDisplayTrial.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace FilteredDisplayTrial
{
    public partial class DisplayCaptureForm : Form
    {
        public DisplayCaptureForm()
        {
            InitializeComponent();
            displayEngine = new Init();
            displayEngine.toScreenBounds(this,pictureBox1);
        }
        private Init displayEngine;
        private void BackgroundTimer_Tick(object sender, EventArgs e)
        {
            displayEngine.updateDisplayImage(this,pictureBox1);
        }
    }
}
