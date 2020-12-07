using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppleEaterUI
{
    public partial class programWindow : Form
    {
         int fed = 0;

        public programWindow()
        {
            InitializeComponent();
        }

        private void OutputTextBox_handler(object sender, EventArgs e)
        {

        }

        private void GuideGroupBox_handler(object sender, EventArgs e)
        {

        }

        private void onFeedButtonClick(object sender, EventArgs e)
        {
            if (fed < 100)
                fed = fed + 1;
            if (fed == 1)
                outputBox.Text = "Thank you! You've fed me " + fed + " apple!";
            if (fed > 1)
                outputBox.Text = "Thank you! You've fed me " + fed + " apples!";
            if (fed == 100)
                outputBox.Text = "Thank you! You've fed me " + fed + " apples and I'm full now.";
        }
    }
}
