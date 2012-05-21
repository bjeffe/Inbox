using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace inbox
{
    public partial class CustomColor : Form
    {
        public CustomColor()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.CustomBackGround = buttonBackground.BackColor;
            Properties.Settings.Default.CustomButton = buttonButton.BackColor;
            Properties.Settings.Default.CustomText = buttonText.BackColor;

            Properties.Settings.Default.Save();

            this.Close();
        }

        private void CustomColor_Load(object sender, EventArgs e)
        {
            this.BackColor = Properties.Settings.Default.UsingBackground;

            labelBackground.ForeColor = Properties.Settings.Default.UsingText;
            labelButton.ForeColor = Properties.Settings.Default.UsingText;
            labelText.ForeColor = Properties.Settings.Default.UsingText;

            buttonBackground.BackColor = Properties.Settings.Default.CustomBackGround;
            buttonBackground.ForeColor = Properties.Settings.Default.UsingText;

            buttonButton.BackColor = Properties.Settings.Default.CustomButton;
            buttonButton.ForeColor = Properties.Settings.Default.UsingText;

            buttonText.BackColor = Properties.Settings.Default.CustomText;
            buttonText.ForeColor = Properties.Settings.Default.UsingText;

            buttonSave.BackColor = Properties.Settings.Default.UsingButton;
            buttonSave.ForeColor = Properties.Settings.Default.UsingText;


            
        }

        private void buttonBackground_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();

            color.AllowFullOpen = false;
            color.AnyColor = true;
            color.SolidColorOnly = false;
            color.Color = Color.Gray;
            if (color.ShowDialog() == DialogResult.OK)
            { 
                buttonBackground.BackColor = color.Color;
            }

        }

        private void buttonText_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();

            color.AllowFullOpen = false;
            color.AnyColor = true;
            color.SolidColorOnly = false;
            color.Color = Color.Gray;
            if (color.ShowDialog() == DialogResult.OK)
            {
                buttonText.BackColor = color.Color;
            }
        }

        private void buttonButton_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();

            color.AllowFullOpen = false;
            color.AnyColor = true;
            color.SolidColorOnly = false;
            color.Color = Color.Gray;
            if (color.ShowDialog() == DialogResult.OK)
            {
                buttonButton.BackColor = color.Color;
            }
        }
    }
}
