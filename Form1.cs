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
           
            




            // 앞뒤 공백 제거 (스페이스바만 입력한 경우 방지)
            string message = Txtchett.Text.Trim().Replace("\r", "").Replace("\n", "");

            // 입력 방어: 비어있거나 공백만 있는지 확인
            if (string.IsNullOrEmpty(message))
            {

                Txtchett.Clear(); // 혹시 남아있을지 모를 공백 제거
                Txtchett.Focus(); // 다시 입력할 수 있게 커서 이동
                return;         
            }





            // 글자 수 제한 방어 (50자 초과 확인) 
            if (message.Length > 50)
            {
                MessageBox.Show("메시지는 최대 50자까지만 입력할 수 있습니다.", "입력 제한", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // 50자까지만 남기고 자를 수도 있습니다 (선택 사항)
                // Txtchett.Text = Txtchett.Text.Substring(0, 50);
                Txtchett.Focus();
                return; // 전송 차단
            }

            // 후처리 (스크롤, 개수 업데이트, 초기화)
            LBX.TopIndex = LBX.Items.Count - 1;
            LBcount.Text = $"총 메시지 개수: {LBX.Items.Count}개";
            Txtchett.Clear();
            Txtchett.Focus();











            // 입력창 초기화 및 다음 입력을 위한 포커스
            Txtchett.Clear();
            Txtchett.Focus();

            string currentTime = DateTime.Now.ToString("tt hh:mm:ss");

            // 시간과 메시지 결합하여 리스트박스(LBX)에 추가
            LBX.Items.Add($"{message}:[{currentTime}]");

            LBX.TopIndex = LBX.Items.Count - 1;
            LBcount.Text = $"총 메시지 개수: {(LBX.Items.Count) / 2}개";


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

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            // 예외 처리: 항목이 선택되었는지 확인 (SelectedIndex가 -1이면 선택 안 된 상태)
            if (LBX.SelectedIndex == -1)
            {

                return; // 함수 종료
            }
            // 선택된 항목 삭제
            // SelectedIndex는 현재 마우스로 클릭된 항목의 번호입니다.
            LBX.Items.RemoveAt(LBX.SelectedIndex);

            // 메시지 개수 라벨 실시간 업데이트
            // 삭제 후 남은 개수를 다시 계산해서 보여줍니다.
            LBcount.Text = $"총 메시지 개수: {LBX.Items.Count}개";
        }

        private void BtnAllDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("대화 기록을 모두 삭제하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // 2. 리스트박스(LBX)의 모든 항목 삭제
                LBX.Items.Clear();

                // 3. 메시지 개수 라벨을 0으로 업데이트
                LBcount.Text = "총 메시지 개수: 0개";

                // 4. (선택 사항) 입력창으로 포커스 이동
                Txtchett.Focus();
            }
        }
    }
}
