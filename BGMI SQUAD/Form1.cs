using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace BGMI_SQUAD
{
    public partial class Form1 : Form
    {
       
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();  

        
        public Form1()
        {
            InitializeComponent();
            player.SoundLocation = "bgmusic.wav";
            player.PlayLooping();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            var linkedin = "www.linkedin.com/in/avishek-bose-58239420a";
            var newlinkedin = new System.Diagnostics.ProcessStartInfo();
            newlinkedin.UseShellExecute = true;
            newlinkedin.FileName = linkedin;
            System.Diagnostics.Process.Start(newlinkedin);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var instagram = "https://www.instagram.com/artic_digital/";
            var newinstagram= new System.Diagnostics.ProcessStartInfo();
            newinstagram.UseShellExecute = true;
            newinstagram.FileName = instagram;
            System.Diagnostics.Process.Start(newinstagram);  
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var uri = "https://discord.com/channels/@me";
            var psi = new System.Diagnostics.ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = uri;
            System.Diagnostics.Process.Start(psi);
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("No New Notifications");
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock= DockStyle.Fill; 
            panelControler.Controls.Clear();
            panelControler.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
            BGMI_SQUAD.UserControls.UC_Avishek uc = new UserControls.UC_Avishek();
            addUserControl(uc);

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BGMI_SQUAD.UserControls.UC_Tushar uc = new UserControls.UC_Tushar();
            addUserControl(uc);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 =new Form1();
            f1.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            BGMI_SQUAD.UserControls.UC_Sayan uc= new UserControls.UC_Sayan(); 
            addUserControl(uc); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BGMI_SQUAD.UserControls.UC_Sandipan uc = new UserControls.UC_Sandipan();
            addUserControl(uc);
        }

        private void button10_Click(object sender, EventArgs e)
        {
           player.Stop();
        
        }
    }
}