using System.Reflection.Emit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

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
         

            // 1. 앞뒤 공백 제거 (스페이스바만 입력한 경우 방지)
            string message = Txtchett.Text.Trim().Replace("\r", "").Replace("\n", "");

            // 2. 입력 방어: 비어있거나 공백만 있는지 확인
            if (string.IsNullOrEmpty(message))
            {
               
                Txtchett.Clear(); // 혹시 남아있을지 모를 공백 제거
                Txtchett.Focus(); // 다시 입력할 수 있게 커서 이동
                return;           // ★매우 중요: 여기서 함수를 끝내야 아래 추가 코드가 실행 안 됨
            }

            // 3. 리스트박스(LBX)에 추가
            LBX.Items.Add(message);

            // 4. 입력창 초기화 및 다음 입력을 위한 포커스
            Txtchett.Clear();
            Txtchett.Focus();

            string currentTime = DateTime.Now.ToString("tt hh:mm:ss");

            // 시간과 메시지 결합하여 리스트박스(LBX)에 추가
            LBX.Items.Add($"[{currentTime}] ");

            LBX.TopIndex = LBX.Items.Count - 1;
            LBcount.Text = $"총 메시지 개수: {(LBX.Items.Count)/2}개";


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Txtchett_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txtchett_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                BtnEnter.PerformClick();

          
            }
        }
    }
}
