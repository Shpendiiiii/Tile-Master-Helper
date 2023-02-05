using System.Runtime.CompilerServices;

namespace TileMasterHelper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)

        {
            areaCheckBox.Checked= true;
            volumeCheckBox.Click += new EventHandler(volumeCheckBox_Checked);

            areaCheckBox.Click += new EventHandler(areaCheckBox_Checked);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lengthTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        public void areaCheckBox_Checked(object sender, EventArgs e)
        {
            
                volumeCheckBox.Checked = false;
                heightTextBox.Enabled = false;
                heightLabel.Enabled = false;
            
            
        }
        
        public void volumeCheckBox_Checked(object sender, EventArgs e)
        {
            if (volumeCheckBox.Checked) {
                heightTextBox.Enabled = true;
                heightLabel.Enabled = true;
            }
        }
        private void calculateButton_Click(object sender, EventArgs e)
        {

            if (areaCheckBox.Checked) {
                string length = lengthTextBox.Text;
                string width = widthTextBox.Text;

                try
                {
                    int lengthInt = int.Parse(length);
                    int widthInt = int.Parse(width);

                    int result = lengthInt * widthInt;
                    string resultString = result.ToString();
                    resultTextBox.Text = resultString + " m\u00b2";

                    lengthTextBox.Text = string.Empty;
                    widthTextBox.Text = string.Empty;
                }
                catch
                {
                    
                    
                    MessageBox.Show("Error in input", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                
            }
            else if (volumeCheckBox.Checked)
            {
               
                int lengthInt = int.Parse(lengthTextBox.Text);
                int widthInt = int.Parse(widthTextBox.Text);
                int heightInt = int.Parse(heightTextBox.Text);

                int result = lengthInt * widthInt * heightInt;
                //string resultString = result.ToString();
                resultTextBox.Text = result.ToString() + " m\u00b3";
                heightTextBox.Text = string.Empty;
                lengthTextBox.Text = string.Empty;
                widthTextBox.Text = string.Empty;
            }
        }
    }
}