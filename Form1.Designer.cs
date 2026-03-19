namespace EchoMessenger
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnEnter = new Button();
            lbltitle = new Label();
            Txtchett = new TextBox();
            LBX = new ListBox();
            SuspendLayout();
            // 
            // BtnEnter
            // 
            BtnEnter.BackColor = Color.FromArgb(128, 255, 128);
            BtnEnter.Font = new Font("바탕체", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            BtnEnter.Location = new Point(634, 338);
            BtnEnter.Name = "BtnEnter";
            BtnEnter.Size = new Size(114, 74);
            BtnEnter.TabIndex = 0;
            BtnEnter.Text = "전송";
            BtnEnter.UseVisualStyleBackColor = false;
            BtnEnter.Click += BtnEnter_Click;
            // 
            // lbltitle
            // 
            lbltitle.AutoSize = true;
            lbltitle.Font = new Font("맑은 고딕", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lbltitle.ForeColor = Color.FromArgb(128, 128, 255);
            lbltitle.Location = new Point(40, 9);
            lbltitle.Name = "lbltitle";
            lbltitle.Size = new Size(286, 46);
            lbltitle.TabIndex = 1;
            lbltitle.Text = "Echo Messenger";
            lbltitle.Click += label1_Click;
            // 
            // Txtchett
            // 
            Txtchett.Location = new Point(40, 365);
            Txtchett.Name = "Txtchett";
            Txtchett.Size = new Size(575, 27);
            Txtchett.TabIndex = 2;
            Txtchett.TextChanged += Txtchett_TextChanged;
            Txtchett.KeyDown += Txtchett_KeyDown;
            // 
            // LBX
            // 
            LBX.FormattingEnabled = true;
            LBX.Location = new Point(40, 68);
            LBX.Name = "LBX";
            LBX.Size = new Size(737, 264);
            LBX.TabIndex = 3;
            LBX.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(LBX);
            Controls.Add(Txtchett);
            Controls.Add(lbltitle);
            Controls.Add(BtnEnter);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnEnter;
        private Label lbltitle;
        private TextBox Txtchett;
        private ListBox LBX;
    }
}
