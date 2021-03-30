
namespace AttendanceApplication
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.PassText = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.workStartT1 = new System.Windows.Forms.TextBox();
            this.workStartT2 = new System.Windows.Forms.TextBox();
            this.offWorkT2 = new System.Windows.Forms.TextBox();
            this.offWorkT1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.workStartTimeTest = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.settingStartWorkTime = new System.Windows.Forms.Label();
            this.settingEndWorkTime = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.IdText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(225, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "입력내용 확인";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PassText
            // 
            this.PassText.Location = new System.Drawing.Point(33, 81);
            this.PassText.Name = "PassText";
            this.PassText.Size = new System.Drawing.Size(164, 21);
            this.PassText.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(225, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "로그인하기";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.login_button_Clicked);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(225, 78);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "로그인후 근태 화면으로";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.login_after_Clicked);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(225, 107);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(144, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "로그인후 출근 누르기";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.work_button_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(225, 136);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(144, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "로그인후 퇴근 누르기";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.off_work_button_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(225, 191);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(144, 23);
            this.button6.TabIndex = 7;
            this.button6.Text = "자동 출퇴근 시작버튼";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.autoAttendance_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "아이디";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "비밀번호";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "출근시간";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "퇴근시간";
            // 
            // workStartT1
            // 
            this.workStartT1.Location = new System.Drawing.Point(33, 170);
            this.workStartT1.Name = "workStartT1";
            this.workStartT1.Size = new System.Drawing.Size(66, 21);
            this.workStartT1.TabIndex = 12;
            this.workStartT1.Text = "0947";
            // 
            // workStartT2
            // 
            this.workStartT2.Location = new System.Drawing.Point(125, 170);
            this.workStartT2.Name = "workStartT2";
            this.workStartT2.Size = new System.Drawing.Size(66, 21);
            this.workStartT2.TabIndex = 13;
            this.workStartT2.Text = "0958";
            // 
            // offWorkT2
            // 
            this.offWorkT2.Location = new System.Drawing.Point(125, 223);
            this.offWorkT2.Name = "offWorkT2";
            this.offWorkT2.Size = new System.Drawing.Size(66, 21);
            this.offWorkT2.TabIndex = 15;
            this.offWorkT2.Text = "1905";
            // 
            // offWorkT1
            // 
            this.offWorkT1.Location = new System.Drawing.Point(33, 223);
            this.offWorkT1.Name = "offWorkT1";
            this.offWorkT1.Size = new System.Drawing.Size(66, 21);
            this.offWorkT1.TabIndex = 14;
            this.offWorkT1.Text = "1900";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "~";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(105, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 12);
            this.label6.TabIndex = 17;
            this.label6.Text = "~";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 130);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(145, 12);
            this.label7.TabIndex = 18;
            this.label7.Text = "자동 설정용 24시간표기법";
            // 
            // workStartTimeTest
            // 
            this.workStartTimeTest.Location = new System.Drawing.Point(225, 162);
            this.workStartTimeTest.Name = "workStartTimeTest";
            this.workStartTimeTest.Size = new System.Drawing.Size(144, 23);
            this.workStartTimeTest.TabIndex = 19;
            this.workStartTimeTest.Text = "TestButton(안보이는 창 닫기)";
            this.workStartTimeTest.UseVisualStyleBackColor = true;
            this.workStartTimeTest.Click += new System.EventHandler(this.workStartTimeTest_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 12);
            this.label8.TabIndex = 20;
            this.label8.Text = "자동 출근 예정 시간 (시분초) : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 284);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(175, 12);
            this.label9.TabIndex = 21;
            this.label9.Text = "자동 퇴근 예정 시간 (시분초) : ";
            // 
            // settingStartWorkTime
            // 
            this.settingStartWorkTime.AutoSize = true;
            this.settingStartWorkTime.Location = new System.Drawing.Point(212, 263);
            this.settingStartWorkTime.Name = "settingStartWorkTime";
            this.settingStartWorkTime.Size = new System.Drawing.Size(17, 12);
            this.settingStartWorkTime.TabIndex = 22;
            this.settingStartWorkTime.Text = "--";
            // 
            // settingEndWorkTime
            // 
            this.settingEndWorkTime.AutoSize = true;
            this.settingEndWorkTime.Location = new System.Drawing.Point(212, 284);
            this.settingEndWorkTime.Name = "settingEndWorkTime";
            this.settingEndWorkTime.Size = new System.Drawing.Size(17, 12);
            this.settingEndWorkTime.TabIndex = 23;
            this.settingEndWorkTime.Text = "--";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(225, 220);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(144, 23);
            this.button7.TabIndex = 24;
            this.button7.Text = "자동 출퇴근 중지버튼";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // IdText
            // 
            this.IdText.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.IdText.Location = new System.Drawing.Point(33, 35);
            this.IdText.Name = "IdText";
            this.IdText.Size = new System.Drawing.Size(164, 21);
            this.IdText.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 315);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.settingEndWorkTime);
            this.Controls.Add(this.settingStartWorkTime);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.workStartTimeTest);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.offWorkT2);
            this.Controls.Add(this.offWorkT1);
            this.Controls.Add(this.workStartT2);
            this.Controls.Add(this.workStartT1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.PassText);
            this.Controls.Add(this.IdText);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "메일플러그 출퇴근";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox IdText;
        private System.Windows.Forms.TextBox PassText;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox workStartT1;
        private System.Windows.Forms.TextBox workStartT2;
        private System.Windows.Forms.TextBox offWorkT2;
        private System.Windows.Forms.TextBox offWorkT1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button workStartTimeTest;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label settingStartWorkTime;
        private System.Windows.Forms.Label settingEndWorkTime;
        private System.Windows.Forms.Button button7;
    }
}

