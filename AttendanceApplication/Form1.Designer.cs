
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.PassText = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.AutoAttendanceStartButton = new System.Windows.Forms.Button();
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
            this.AutoAttendanceStopButton = new System.Windows.Forms.Button();
            this.IdText = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.onOffTimesetting = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.alertAlram = new System.Windows.Forms.Button();
            this.isAutoRunning = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.attendenceLabelText = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.offWorkLabelText = new System.Windows.Forms.Label();
            this.AutoShutdownCheckBox = new System.Windows.Forms.CheckBox();
            this.shutdownMin = new System.Windows.Forms.TextBox();
            this.shutdownSec = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.addStartProgramList = new System.Windows.Forms.Button();
            this.unaddStartProgramList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(225, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "입력내용 확인 및 저장";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Checkinfo_Button_Click);
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
            // AutoAttendanceStartButton
            // 
            this.AutoAttendanceStartButton.Location = new System.Drawing.Point(225, 191);
            this.AutoAttendanceStartButton.Name = "AutoAttendanceStartButton";
            this.AutoAttendanceStartButton.Size = new System.Drawing.Size(144, 23);
            this.AutoAttendanceStartButton.TabIndex = 7;
            this.AutoAttendanceStartButton.Text = "자동 출퇴근 시작버튼";
            this.AutoAttendanceStartButton.UseVisualStyleBackColor = true;
            this.AutoAttendanceStartButton.Click += new System.EventHandler(this.autoAttendance_button_Click);
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
            this.label3.Size = new System.Drawing.Size(93, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "출근시간(4글자)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "퇴근시간(4글자)";
            // 
            // workStartT1
            // 
            this.workStartT1.Location = new System.Drawing.Point(33, 170);
            this.workStartT1.Name = "workStartT1";
            this.workStartT1.Size = new System.Drawing.Size(66, 21);
            this.workStartT1.TabIndex = 12;
            // 
            // workStartT2
            // 
            this.workStartT2.Location = new System.Drawing.Point(125, 170);
            this.workStartT2.Name = "workStartT2";
            this.workStartT2.Size = new System.Drawing.Size(66, 21);
            this.workStartT2.TabIndex = 13;
            // 
            // offWorkT2
            // 
            this.offWorkT2.Location = new System.Drawing.Point(125, 223);
            this.offWorkT2.Name = "offWorkT2";
            this.offWorkT2.Size = new System.Drawing.Size(66, 21);
            this.offWorkT2.TabIndex = 15;
            // 
            // offWorkT1
            // 
            this.offWorkT1.Location = new System.Drawing.Point(33, 223);
            this.offWorkT1.Name = "offWorkT1";
            this.offWorkT1.Size = new System.Drawing.Size(66, 21);
            this.offWorkT1.TabIndex = 14;
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
            this.label7.Location = new System.Drawing.Point(12, 118);
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
            this.workStartTimeTest.Text = "Test (모든창 닫기)";
            this.workStartTimeTest.UseVisualStyleBackColor = true;
            this.workStartTimeTest.Click += new System.EventHandler(this.workStartTimeTest_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 12);
            this.label8.TabIndex = 20;
            this.label8.Text = "자동 출근 예정 시간 (시분초) : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 271);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(175, 12);
            this.label9.TabIndex = 21;
            this.label9.Text = "자동 퇴근 예정 시간 (시분초) : ";
            // 
            // settingStartWorkTime
            // 
            this.settingStartWorkTime.AutoSize = true;
            this.settingStartWorkTime.Location = new System.Drawing.Point(206, 255);
            this.settingStartWorkTime.Name = "settingStartWorkTime";
            this.settingStartWorkTime.Size = new System.Drawing.Size(17, 12);
            this.settingStartWorkTime.TabIndex = 22;
            this.settingStartWorkTime.Text = "--";
            // 
            // settingEndWorkTime
            // 
            this.settingEndWorkTime.AutoSize = true;
            this.settingEndWorkTime.Location = new System.Drawing.Point(206, 271);
            this.settingEndWorkTime.Name = "settingEndWorkTime";
            this.settingEndWorkTime.Size = new System.Drawing.Size(17, 12);
            this.settingEndWorkTime.TabIndex = 23;
            this.settingEndWorkTime.Text = "--";
            // 
            // AutoAttendanceStopButton
            // 
            this.AutoAttendanceStopButton.Location = new System.Drawing.Point(225, 220);
            this.AutoAttendanceStopButton.Name = "AutoAttendanceStopButton";
            this.AutoAttendanceStopButton.Size = new System.Drawing.Size(144, 23);
            this.AutoAttendanceStopButton.TabIndex = 24;
            this.AutoAttendanceStopButton.Text = "자동 출퇴근 중지버튼";
            this.AutoAttendanceStopButton.UseVisualStyleBackColor = true;
            this.AutoAttendanceStopButton.Click += new System.EventHandler(this.AutoAttendanceStopButton_Click);
            // 
            // IdText
            // 
            this.IdText.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.IdText.Location = new System.Drawing.Point(33, 35);
            this.IdText.Name = "IdText";
            this.IdText.Size = new System.Drawing.Size(164, 21);
            this.IdText.TabIndex = 1;
            this.IdText.Enter += new System.EventHandler(this.IdText_Enter);
            this.IdText.Leave += new System.EventHandler(this.IdText_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 382);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 12);
            this.label10.TabIndex = 25;
            this.label10.Text = "자동 설정 출퇴근시간에서";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(212, 382);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(173, 12);
            this.label11.TabIndex = 26;
            this.label11.Text = "분 경과시 출퇴근했음으로 변경";
            // 
            // onOffTimesetting
            // 
            this.onOffTimesetting.Location = new System.Drawing.Point(184, 379);
            this.onOffTimesetting.Name = "onOffTimesetting";
            this.onOffTimesetting.Size = new System.Drawing.Size(29, 21);
            this.onOffTimesetting.TabIndex = 27;
            this.onOffTimesetting.Text = "10";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 342);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(303, 24);
            this.label12.TabIndex = 28;
            this.label12.Text = "※업무시간 내에 자동 출퇴근을 실행시켰을때\r\n  (분 변경시 자동 출퇴근 시작버튼 눌러야 적용됩니다.)";
            // 
            // alertAlram
            // 
            this.alertAlram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.alertAlram.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.alertAlram.Location = new System.Drawing.Point(294, 263);
            this.alertAlram.Name = "alertAlram";
            this.alertAlram.Size = new System.Drawing.Size(75, 53);
            this.alertAlram.TabIndex = 30;
            this.alertAlram.Text = "주의사항\r\n확인하기";
            this.alertAlram.UseVisualStyleBackColor = false;
            this.alertAlram.Click += new System.EventHandler(this.alertAlram_Click);
            // 
            // isAutoRunning
            // 
            this.isAutoRunning.AutoSize = true;
            this.isAutoRunning.Location = new System.Drawing.Point(102, 136);
            this.isAutoRunning.Name = "isAutoRunning";
            this.isAutoRunning.Size = new System.Drawing.Size(17, 12);
            this.isAutoRunning.TabIndex = 31;
            this.isAutoRunning.Text = "--";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(22, 136);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 12);
            this.label14.TabIndex = 32;
            this.label14.Text = "자동출퇴근 : ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(30, 294);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 12);
            this.label13.TabIndex = 33;
            this.label13.Text = "출근상태 :";
            // 
            // attendenceLabelText
            // 
            this.attendenceLabelText.AutoSize = true;
            this.attendenceLabelText.Location = new System.Drawing.Point(97, 294);
            this.attendenceLabelText.Name = "attendenceLabelText";
            this.attendenceLabelText.Size = new System.Drawing.Size(17, 12);
            this.attendenceLabelText.TabIndex = 34;
            this.attendenceLabelText.Text = "--";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(30, 315);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 12);
            this.label16.TabIndex = 35;
            this.label16.Text = "퇴근상태 : ";
            // 
            // offWorkLabelText
            // 
            this.offWorkLabelText.AutoSize = true;
            this.offWorkLabelText.Location = new System.Drawing.Point(97, 315);
            this.offWorkLabelText.Name = "offWorkLabelText";
            this.offWorkLabelText.Size = new System.Drawing.Size(17, 12);
            this.offWorkLabelText.TabIndex = 36;
            this.offWorkLabelText.Text = "--";
            // 
            // AutoShutdownCheckBox
            // 
            this.AutoShutdownCheckBox.AutoSize = true;
            this.AutoShutdownCheckBox.Location = new System.Drawing.Point(209, 425);
            this.AutoShutdownCheckBox.Name = "AutoShutdownCheckBox";
            this.AutoShutdownCheckBox.Size = new System.Drawing.Size(116, 16);
            this.AutoShutdownCheckBox.TabIndex = 38;
            this.AutoShutdownCheckBox.Text = "퇴근시 자동 종료";
            this.AutoShutdownCheckBox.UseVisualStyleBackColor = true;
            // 
            // shutdownMin
            // 
            this.shutdownMin.Location = new System.Drawing.Point(208, 447);
            this.shutdownMin.Name = "shutdownMin";
            this.shutdownMin.Size = new System.Drawing.Size(29, 21);
            this.shutdownMin.TabIndex = 39;
            this.shutdownMin.Text = "10";
            // 
            // shutdownSec
            // 
            this.shutdownSec.Location = new System.Drawing.Point(266, 447);
            this.shutdownSec.Name = "shutdownSec";
            this.shutdownSec.Size = new System.Drawing.Size(29, 21);
            this.shutdownSec.TabIndex = 40;
            this.shutdownSec.Text = "10";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(243, 450);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(17, 12);
            this.label15.TabIndex = 41;
            this.label15.Text = "분";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(297, 450);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(81, 12);
            this.label17.TabIndex = 42;
            this.label17.Text = "초후 자동종료";
            // 
            // addStartProgramList
            // 
            this.addStartProgramList.Location = new System.Drawing.Point(24, 416);
            this.addStartProgramList.Name = "addStartProgramList";
            this.addStartProgramList.Size = new System.Drawing.Size(151, 32);
            this.addStartProgramList.TabIndex = 43;
            this.addStartProgramList.Text = "부팅시 시작 프로그램에 \r\n등록";
            this.addStartProgramList.UseVisualStyleBackColor = true;
            this.addStartProgramList.Click += new System.EventHandler(this.addStartProgramList_Click);
            // 
            // unaddStartProgramList
            // 
            this.unaddStartProgramList.Location = new System.Drawing.Point(24, 454);
            this.unaddStartProgramList.Name = "unaddStartProgramList";
            this.unaddStartProgramList.Size = new System.Drawing.Size(151, 23);
            this.unaddStartProgramList.TabIndex = 45;
            this.unaddStartProgramList.Text = "시작프로그램에서 제외";
            this.unaddStartProgramList.UseVisualStyleBackColor = true;
            this.unaddStartProgramList.Click += new System.EventHandler(this.unaddStartProgramList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(407, 496);
            this.Controls.Add(this.unaddStartProgramList);
            this.Controls.Add(this.addStartProgramList);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.shutdownSec);
            this.Controls.Add(this.shutdownMin);
            this.Controls.Add(this.AutoShutdownCheckBox);
            this.Controls.Add(this.offWorkLabelText);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.attendenceLabelText);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.isAutoRunning);
            this.Controls.Add(this.alertAlram);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.onOffTimesetting);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.AutoAttendanceStopButton);
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
            this.Controls.Add(this.AutoAttendanceStartButton);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.PassText);
            this.Controls.Add(this.IdText);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "메일플러그 출퇴근";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Button AutoAttendanceStartButton;
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
        private System.Windows.Forms.Button AutoAttendanceStopButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox onOffTimesetting;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button alertAlram;
        private System.Windows.Forms.Label isAutoRunning;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label attendenceLabelText;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label offWorkLabelText;
        private System.Windows.Forms.CheckBox AutoShutdownCheckBox;
        private System.Windows.Forms.TextBox shutdownMin;
        private System.Windows.Forms.TextBox shutdownSec;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button addStartProgramList;
        private System.Windows.Forms.Button unaddStartProgramList;
    }
}

