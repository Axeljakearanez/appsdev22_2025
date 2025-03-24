
using System.Drawing;
using System.IO;
namespace SimpleFavoriteCartoonFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBoxCharacters.Items.Add("Spongebob");
            comboBoxCharacters.Items.Add("Patrick");
            comboBoxCharacters.Items.Add("Mr. Krabs");
            comboBoxCharacters.Items.Add("Sandy");
            comboBoxCharacters.Items.Add("Plankton");
            comboBoxCharacters.Items.Add("Squidward");

        }
        


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (comboBoxCharacters.SelectedItem != null)
            {
                string selectedCharacter = comboBoxCharacters.SelectedItem.ToString();
                object imageObj = null;

               
                switch (selectedCharacter)
                {
                    case "Spongebob":
                        imageObj = Properties.Resources.Spongebob;
                        break;
                    case "Patrick":
                        imageObj = Properties.Resources.Patrick;
                        break;
                    case "Mr. Krabs":
                        imageObj = Properties.Resources.MrKrabs;
                        break;
                    case "Sandy":
                        imageObj = Properties.Resources.Sandy;
                        break;
                    case "Plankton":
                        imageObj = Properties.Resources.Plankton;
                        break;
                    case "Squidward":
                        imageObj = Properties.Resources.Squidward;
                        break;
                    default:
                        pictureBoxCharacter.Image = null;
                        return;
                }

                
                if (imageObj is byte[] imageBytes)
                {
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        pictureBoxCharacter.Image = Image.FromStream(ms);
                    }
                }
                else if (imageObj is Image img)
                {
                    pictureBoxCharacter.Image = img;
                }
                else
                {
                    pictureBoxCharacter.Image = null;
                }
            }
            else
            {
                MessageBox.Show("Please select a character first.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBoxCharacter.Image = null;
        }
    }
}
