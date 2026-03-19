using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            string typed_msg;
            typed_msg = Txtchett.Text;
            LBX.Items.Add(typed_msg);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
