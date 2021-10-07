using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Configuration;

//Selenium Library
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace AttendanceApplication
{


    public partial class Form1 : Form
    {
        const string IdPlaceholder = "계정 아이디";
        const string PwPlaceholder = "비밀번호";
        TextBox[] txtList;

        List<ChromeDriver> chromeList = new List<ChromeDriver>();

        private int startRandomTime = 0; // 출근 시간 랜덤값 집어넣을 변수
        private int endRandomTime = 0;   // 퇴근 시간 랜덤값 집어넣을 변수

        protected ChromeDriverService _driverService = null;
        protected ChromeOptions _options = null;
        protected ChromeDriver _driver = null;


        private object sender;
        private EventArgs e;

        private bool While = true;


        private bool Work = false;
        private bool offWork = false;

        public Form1()
        {
            InitializeComponent();


            Log_Info("시작");

            txtList = new TextBox[] { IdText, PassText };
            foreach (var txt in txtList)
            {
                //처음 공백 Placeholder 지정
                txt.ForeColor = Color.DarkGray;
                if (txt == IdText) txt.Text = IdPlaceholder;
                else if (txt == PassText) txt.Text = PwPlaceholder;
                //텍스트박스 커서 Focus 여부에 따라 이벤트 지정
                txt.GotFocus += RemovePlaceholder;
                txt.LostFocus += SetPlaceholder;
            }

            FormClosing += new FormClosingEventHandler(closing);


        }

        private void firstInit()
        {

            // 셀레니움 참조사이트
            // (웹 자동화 라이브러리)
            // https://luckygg.tistory.com/tag/%EC%85%80%EB%A0%88%EB%8B%88%EC%9B%80
            //MessageBox.Show("login_button_Clicked");

            _driverService = ChromeDriverService.CreateDefaultService();
            _driverService.HideCommandPromptWindow = true;

            _options = new ChromeOptions();
            _options.AddArgument("disable-gpu");
            _options.AddArguments("disable-infobars");
            _options.AddArguments("enable-automation");
            _options.AddAdditionalCapability("useAutomationExtension", false);

            //_options.AddArgument("headless");
            // 창을 숨기는 옵션.
            // 이거 창을 숨기니까 그냥 종료하면 같이 인터넷창을 종료하질 않아서 골때리는 상황발생함.

            /* 
            // 체크박스 사용해서 창 숨기는 옵션 적용시
            if (checkBoxIsShow.Checked == false) { 
                _options.AddArgument("headless"); // 창을 숨기는 옵션입니다.
            }
            */

            var _driver = new ChromeDriver(_driverService, _options);

            // 웹 사이트에 접속합니다.

            try { 
                _driver.Navigate().GoToUrl("https://mail.it-cous.com/member/login");

                _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

                chromeList.Add(_driver);
            }
            catch(Exception e)
            {
                //Console.WriteLine("웹 연결 추가중 오류 발생 | Error log : " + e.Message);
                Log_Info("웹 연결 추가중 오류 발생 | Error log : " + e.Message);
            }

            //Console.WriteLine("웹 연결 추가 리스트 크기 : " + chromeList.Count);
            Log_Info("웹 연결 추가 리스트 크기 : " + chromeList.Count);

        }

        private void closing(object sender, EventArgs e)
        {
            try { 
            Log_Info("실행종료 시작");
            closeAllChrome();
            Log_Info("실행종료 마무리");
            }
            catch (Exception error)
            {
                Log_Info("실행종료중 오류 | Error log : " + error.Message);
            }
            Application.Exit();
        }

        private void closeAllChrome()
        {
            if(chromeList.Count== 0)
            {
                //Console.WriteLine("연결된 웹 없음");
                Log_Info("연결된 웹 없음");
                return;
            }

            for (int i = chromeList.Count; i >= 0 ; i--) 
            {
                if (i <= -1)
                    break;
                try
                {
                    chromeList[i].Quit();
                    //Console.WriteLine("웹 연결 종료. 리스트 크기 : " + chromeList.Count);
                    Log_Info("웹 연결 종료, 리스트 크기 : " + chromeList.Count);
                }
                catch (Exception error)
                {
                    Log_Info("종료시 예외사항 발생 로그 : " + error.Message);
                }
            }

            chromeList.Clear();

        }

        private void Checkinfo_Button_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hello World!");

            MessageBox.Show("INPUT INFO \n ID : " + IdText.Text + " PASSWORD : " + PassText.Text
                + "\n attend start : " + workStartT1.Text+" attend end : " + workStartT2.Text
                + "\n leave start : " + offWorkT1.Text +" leave end : " + offWorkT2.Text 
                + "\n 비밀번호는 로그, 저장자료에 기록되지 않습니다."
                , "입력정보 확인"
                );
            //Console.WriteLine("INPUT INFO \n ID : {0} \n ", IdText.Text
            //    + "\n attend start : " + workStartT1.Text + " attend end : " + workStartT2.Text
            //    + "\n leave start : " + offWorkT1.Text + " leave end : " + offWorkT2.Text);

            Log_Info("INPUT INFO | ID : " + IdText.Text
                + " | attend start : " + workStartT1.Text + " | attend end : " + workStartT2.Text
                + " | leave start : " + offWorkT1.Text + " | leave end : " + offWorkT2.Text);


            Properties.Settings.Default.userIdSetValue = IdText.Text;
            Properties.Settings.Default.workStartT1SetValue = workStartT1.Text;
            Properties.Settings.Default.workStartT2SetValue = workStartT2.Text;
            Properties.Settings.Default.offWorkT1SetValue = offWorkT1.Text;
            Properties.Settings.Default.offWorkT2SetValue = offWorkT2.Text;
            Properties.Settings.Default.onOffTimesettingSetValue = onOffTimesetting.Text;

            Properties.Settings.Default.Save();

        }



        private void RemovePlaceholder(object sender, EventArgs e)
        {
            // C# placeholder 참조사이트
            //https://ella-devblog.tistory.com/70

            TextBox txt = (TextBox)sender;
            if (txt.Text == IdPlaceholder | txt.Text == PwPlaceholder)
            { //텍스트박스 내용이 사용자가 입력한 값이 아닌 Placeholder일 경우에만, 커서 포커스일때 빈칸으로 만들기
                txt.ForeColor = Color.Black; //사용자 입력 진한 글씨
                txt.Text = string.Empty;
                if (txt == PassText) PassText.PasswordChar = '●';
            }
        }

        private void SetPlaceholder(object sender, EventArgs e)
        {
            // C# placeholder 참조사이트
            //https://ella-devblog.tistory.com/70

            TextBox txt = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                //사용자 입력값이 하나도 없는 경우에 포커스 잃으면 Placeholder 적용해주기
                txt.ForeColor = Color.DarkGray; //Placeholder 흐린 글씨
                if (txt == IdText) 
                    txt.Text = IdPlaceholder;
                else if (txt == PassText) 
                { 
                    txt.Text = PwPlaceholder; 
                    PassText.PasswordChar = default; 
                }
            }
        }


        private void login_button_Clicked(object sender, EventArgs e)
        {
            if (!isInfoReady())
            {
                return;
            }

            Log_Info("로그인 시작");

            string id = IdText.Text;
            string pw = PassText.Text;

            firstInit();

            int size = chromeList.Count;

            var _driver = chromeList[size - 1];

            if ( _driver == null)
            {
                Log_Info("web List의 마지막에서 가져온 driver의 객체가 비었음.");
                return;
            }

            var inputID = _driver.FindElementByXPath("//*[@id='cid']");
            inputID.SendKeys( id );

            var InputPW = _driver.FindElementByXPath("//*[@id='cpw']");
            InputPW.SendKeys( pw );

            var LoginButton = _driver.FindElementByXPath("//*[@id='frmlogin']/button");
            LoginButton.Click();
        }

        private void login_after_Clicked(object sender, EventArgs e)
        {
            if (!isInfoReady())
            {
                return;
            }

            Log_Info("로그인후 근태탭으로 이동");
            login_button_Clicked(sender, e);

            int size = chromeList.Count;

            var _driver = chromeList[size - 1];

            if (_driver == null)
            {
                Log_Info("web List의 마지막에서 가져온 driver의 객체가 비었음.");
                return;
            }

            var goToAttend = _driver.FindElementById("link_to_worknote");

            goToAttend.Click();


            var closeAlram = _driver.FindElementByXPath("//*[@id='updateNotice']/div[1]/button");

            if(closeAlram != null)
            {
                closeAlram.Click();
            }




        }


        private void work_button_Click(object sender, EventArgs e)
        {
            if (!isInfoReady())
            {
                return;
            }


            DateTime nowDt = DateTime.Now;

            if (nowDt.DayOfWeek == DayOfWeek.Saturday)
            {
                MessageBox.Show("오늘은 토요일. 회사 안옴 스킵. 수고.");
                Log_Info("오늘은 토요일. 회사 안옴 스킵. 수고.");
                return;
            }
            else if (nowDt.DayOfWeek == DayOfWeek.Sunday)
            {
                MessageBox.Show("오늘은 일요일. 회사 안옴 스킵. 수고.");
                Log_Info("오늘은 일요일. 회사 안옴 스킵. 수고.");
                return;
            }

            Log_Info("로그인후 출근버튼 클릭하기");
            login_after_Clicked(sender, e);

            Thread.Sleep(1000);

            int size = chromeList.Count;

            var _driver = chromeList[size - 1];

            if (_driver == null)
            {
                Log_Info("web List의 마지막에서 가져온 driver의 객체가 비었음.");
                return;
            }

            try
            {
                var attendButton = _driver.FindElementByXPath("//*[@id='commute-check']/div[1]/div[1]/div[2]/div[3]/button");
            attendButton.Click();
            }
            catch (Exception error)
            {
                Log_Info("출근 버튼을 눌렀을때 오류 | Error log : " + error.Message );
                return;
            }

            /*
            try
            {
                var attendButtonClass = _driver.FindElementByCssSelector("mdi mdi-briefcase-check-outline");
                attendButtonClass.Click();
            }
            catch (Exception error)
            {
                Log_Info("출근 버튼을 눌렀을때 오류 | Error log : " + error.Message );
                return;
            }
            */

            var popupButton = _driver.FindElementByXPath("//*[@id='modalbg']");
            popupButton.Click();

            Thread.Sleep(1000);

            this.Work = true;

            closeAllChrome();

        }

        private void off_work_button_Click(object sender, EventArgs e)
        {
            if (!isInfoReady())
            {
                return;
            }


            //MessageBox.Show("button5_Click");
            DateTime nowDt = DateTime.Now;

            if (nowDt.DayOfWeek == DayOfWeek.Saturday)
            {
                MessageBox.Show("오늘은 토요일. 회사 안옴 스킵. 수고.");
                Log_Info("오늘은 토요일. 회사 안옴 스킵. 수고.");
                return;
            }
            else if (nowDt.DayOfWeek == DayOfWeek.Sunday)
            {
                MessageBox.Show("오늘은 일요일. 회사 안옴 스킵. 수고.");
                Log_Info("오늘은 일요일. 회사 안옴 스킵. 수고.");
                return;
            }


            Log_Info("로그인후 퇴근버튼 클릭하기");
            login_after_Clicked(sender, e);

            int size = chromeList.Count;

            var _driver = chromeList[size - 1];

            if (_driver == null)
            {
                Log_Info("web List의 마지막에서 가져온 driver의 객체가 비었음.");
                return;
            }

            try
            {
                var attendButton = _driver.FindElementByXPath("//*[@id='commute-check']/div[1]/div[1]/div[2]/div[3]/button");
                attendButton.Click();
            }
            catch (Exception error)
            {
                Log_Info("퇴근 버튼을 눌렀을때 생기는 오류 | Error log : " + error.Message);
                return;
            }

            var popupButton = _driver.FindElementByXPath("//*[@id='modalbg']");
            popupButton.Click();

            Thread.Sleep(1000);

            this.offWork = true;

            closeAllChrome();

        }

        private void AutoAttendanceStopButton_Click(object sender, EventArgs e)
        {
            this.AutoAttendanceStartButton.UseVisualStyleBackColor = true;
            AutoAttendanceStartButton.Text = "자동 출퇴근 시작버튼";

            settingStartWorkTime.Text = "--";
            settingEndWorkTime.Text = "--";

            attendenceLabelText.Text = "--";
            offWorkLabelText.Text = "--";

            isAutoRunning.Text = "실행중지됨";

            this.While = false;
        }

        private void autoAttendance_button_Click(object sender, EventArgs e)
        {
            if(!isInfoReady())
            {
                return;
            }


            AutoAttendanceStartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            AutoAttendanceStartButton.Text = "자동 출퇴근 실행중";

            // 시작시간 범위 갖고와서 시간객체로변환
            // 자정 또는 프로그램이 켜진 시점에서
            // 랜덤으로 출근시간, 퇴근시간을 뽑음
            // 뽑힌 출퇴근 시간과 시간객체로 변환된
            // 시간 범위내라면 해당 시간에 버튼을 클릭하게함.

            // 매 자정마다 초기화같은걸 생각해서
            // 출퇴근 시간 세팅을 메소드로 따로 빼서
            // 모듈화
            Log_Info("자동 출퇴근 버튼 클릭");

            isAutoRunning.Text = "실행중";

            this.startRandomTime = setStartWorkTime();

            this.endRandomTime = setEndWorkTime();

            this.While = true;

            // int to date 참조사이트
            //https://codewithshadman.com/csharp-number-and-datetime-tips/

            this.sender = sender;
            this.e = e;


            // 이부분 스레드로 돌리면 될듯
            //------------------------------------------------------------
            // 인자값 넘기는것 때문에 스레드로 돌리는건 따로 더 찾아봐야할듯.
            Thread thr = new Thread(new ThreadStart(tryAttendanceWhile) );
            Thread thr2 = new Thread(new ThreadStart(initTime));
            thr.Start();
            thr2.Start();
            //------------------------------------------------------------


        }

        private void tryAttendanceWhile()
        {
            while (While)
            {
                Thread.Sleep(1000);
                tryAttendance();
            }
        }

        private void tryAttendance()
        {
            //startRandomTime = setStartWorkTime();
            //endRandomTime = setEndWorkTime();

            if (startRandomTime == 0 || endRandomTime == 0)
            {
                Log_Info("날짜 지났고 아직 출퇴근 시간 세팅 안됨");
                return;
            }

            DateTime nowDt = DateTime.Now;

            if (nowDt.DayOfWeek == DayOfWeek.Saturday) 
            { 
                Log_Info("오늘은 토요일. 출근 안함. 스킵.");
                return;
            }
            else if (nowDt.DayOfWeek == DayOfWeek.Sunday)
            { 
                Log_Info("오늘은 일요일. 출근 안함. 스킵.");
                return;
            }


            string startTimestr = Convert.ToString(startRandomTime);
            string endTimeStr = Convert.ToString(endRandomTime);

            int offset = int.Parse(onOffTimesetting.Text);

            if (startTimestr.Length < 6)
            {
                startTimestr = "0" + startTimestr;
            }

            //Console.WriteLine("startTimestr : " + startTimestr);
            //Console.WriteLine("endTimeStr : " + endTimeStr);

            //-------------------

            //DateTime stRandom1 = Convert.ToDateTime(startRandomTime);


            DateTime stRandom = DateTime.ParseExact(startTimestr, "HHmmss", null);
            DateTime endRandom = DateTime.ParseExact(endTimeStr, "HHmmss", null);

            TimeSpan dateDiff;

            dateDiff = DateTime.Now - stRandom;

            int diffDay = dateDiff.Days;
            int diffHour = dateDiff.Hours;
            int diffMinute = dateDiff.Minutes;
            int diffSecond = dateDiff.Seconds;
            //시간차이 구하기
            //출처: https://holjjack.tistory.com/3 [정리하며 배우다.]

            if (DateTime.Compare(DateTime.Now, stRandom) == 0 && Work == false)
            {
                //work_button_Click(sender, e);
                login_after_Clicked(this.sender, this.e);
                Work = true;

            }
            else if (DateTime.Compare(DateTime.Now, stRandom) > 0 && Work == false && ( diffHour >= 1 || diffMinute >= offset))
            {
                // 전제는 이미 출근버튼을 눌렀음.
                // 업무시간중 프로그램을 실행시켰을 경우
                // 랜덤타임과 현재시간의 차이가 (30 분이상) 옵셋값, 1시간 이상일경우.
                Log_Info("출근시간이 " + offset +"분 지났는데 출근이 안됐넹 출근버튼 누르셨겠지? 출근했음으로 체크! | 현재시간 : " + DateTime.Now + " 출근 설정시간 : " + stRandom);
                //Console.WriteLine("출근시간이 꽤 지났는데 출근이 안됐넹 출근버튼 누르셨겠지? 출근했음으로 체크! | 현재시간 : " + DateTime.Now + " 출근 설정시간 : " + stRandom);
                Work = true;
            }
            else if (DateTime.Compare(DateTime.Now, stRandom) > 0 && Work == false)
            {
                // 시간이 지났음에도 로그인 시도를 하지 않았을경우.
                // 컴퓨터상에서 처리 시간이 지연됐을경우 해당 시간 초에 동작하지 않았을 수 있음.
                work_button_Click(sender, e);
                //login_after_Clicked(this.sender, this.e);
                Log_Info("출근시간이 지났는데 출근이 안됐었넹 | 현재시간 : " + DateTime.Now + " 출근 설정시간 : " + stRandom);
                //Console.WriteLine("출근시간이 지났는데 출근이 안됐었넹 | 현재시간 : " + DateTime.Now + " 출근 설정시간 : " + stRandom);
                Work = true;

            }
            else if (DateTime.Compare(DateTime.Now, stRandom) > 0)
            {
                string attTmp;
                if (Work == true)
                {
                    attTmp = "출근완료!";
                }
                else
                {
                    attTmp = "헐 출근안됨";
                }
                Log_Info("출근시간이 지났고 지금상태 : " + attTmp + " | now : " + DateTime.Now + " 출근 설정시간 : " + stRandom);
                //Console.WriteLine("출근시간이 지났고 지금상태 : " + attTmp + " | now : " + DateTime.Now + " 출근 설정시간 : " + stRandom);
            }
            else if (DateTime.Compare(DateTime.Now, stRandom) < 0)
            {
                string attTmp;
                if (Work == true)
                {
                    attTmp = "출근완료!";
                }
                else
                {
                    attTmp = "출근안됨";
                }
                Log_Info("현재시간 출근시간 이전이고 지금상태 : " + attTmp + " | now : " + DateTime.Now + " 출근 설정시간 : " + stRandom);
                //Console.WriteLine("현재시간 출근시간 이전이고 지금상태 : " + attTmp + " | now : " + DateTime.Now + " 출근 설정시간 : " + stRandom);
            }


            dateDiff = DateTime.Now - endRandom;

            diffDay = dateDiff.Days;
            diffHour = dateDiff.Hours;
            diffMinute = dateDiff.Minutes;
            diffSecond = dateDiff.Seconds;


            if (DateTime.Compare(DateTime.Now, endRandom) == 0 && offWork == false)
            {
                off_work_button_Click(sender, e);
                //login_after_Clicked(this.sender, this.e);
                offWork = true;
            }
            else if (DateTime.Compare(DateTime.Now, endRandom) > 0 && offWork == false && (diffHour >= 1 || diffMinute >= offset))
            {
                // 전제는 이미 퇴근버튼을 눌렀음.
                // 퇴근시간이후 프로그램을 실행시켰을 경우
                // 랜덤타임과 현재시간의 차이가 옵셋값 이상, 1시간 이상일경우.
                Log_Info("퇴근시간이 " + offset + "분 지났는데 퇴근이 안됐넹 퇴근버튼누르셨겠지? 퇴근했음으로 체크! | 현재시간 : " + DateTime.Now + " 출근 설정시간 : " + endRandom);
                //Console.WriteLine("퇴근시간이 꽤 지났는데 퇴근이 안됐넹 퇴근버튼누르셨겠지? 퇴근했음으로 체크! | 현재시간 : " + DateTime.Now + " 출근 설정시간 : " + endRandom);
                offWork = true;
            }
            else if (DateTime.Compare(DateTime.Now, endRandom) > 0 && offWork == false )
            {
                off_work_button_Click(sender, e);
                //login_after_Clicked(this.sender, this.e);
                Log_Info("퇴근시간이 지났는데 퇴근이 안됐었넹 | 현재시간 : " + DateTime.Now + " 퇴근 설정시간 : " + endRandom);
                //Console.WriteLine("퇴근시간이 지났는데 퇴근이 안됐었넹 | 현재시간 : " + DateTime.Now + " 퇴근 설정시간 : " + endRandom);
                offWork = true;
            }
            else if(DateTime.Compare(DateTime.Now, endRandom) > 0)
            {
                string attTmp;
                if (offWork == true)
                {
                    attTmp = "퇴근완료!";
                }
                else
                {
                    attTmp = "헐 퇴근안됨";
                }
                Log_Info("퇴근시간이 지났고 지금상태 : " + attTmp + " | now : " + DateTime.Now + " 퇴근 설정시간 : " + endRandom);
                //Console.WriteLine("퇴근시간이 지났고 지금상태 : " + attTmp + " | now : " + DateTime.Now + " 퇴근 설정시간 : " + endRandom);
            }
            else if (DateTime.Compare(DateTime.Now, endRandom) < 0)
            {
                string attTmp;
                if (offWork == true)
                {
                    attTmp = "퇴근완료";
                }
                else
                {
                    attTmp = "퇴근안됨";
                }
                Log_Info("현재시간 퇴근시간이 이전이고 지금상태 : " + attTmp + " | now : " + DateTime.Now + " 퇴근 설정시간 : " + endRandom);
                //Console.WriteLine("현재시간 퇴근시간이 이전이고 지금상태 : " + attTmp + " | now : " + DateTime.Now + " 퇴근 설정시간 : " + endRandom);
            }

            if (Work == true)
            {
                changeLabelText( attendenceLabelText ,  "출근완료" );
            }
            else
            {
                changeLabelText( attendenceLabelText , "출근안됨" );
            }

            if( offWork == true)
            {
                changeLabelText( offWorkLabelText , "퇴근완료" );
            }
            else
            {
                changeLabelText( offWorkLabelText , "퇴근안됨" );
            }


            if( AutoShutdownCheckBox.Enabled == true)
            {
                if ( diffMinute >= int.Parse(shutdownMin.Text) && diffSecond >= int.Parse(shutdownSec.Text))
                {
                    shutdownNow();
                }

            }
            else
            {
                //notting
            }


        }


        public void shutdownNow()
        {
            System.Diagnostics.Process.Start("shutdown.exe", "-s -f");
        }

        public void changeLabelText ( Label label , string text)
        {
            this.Invoke(
            new Action(delegate () {
                label.Text = text;
                        }
                )
            );
        }

        private void initTime()
        {
            while (While) 
            {
                if( DateTime.Now.Hour == 0 ) {
                    Log_Info("시간 됐다 초기화 한다. 현재시간 : " + DateTime.Now);
                    //Console.WriteLine("시간 됐다 초기화 한다. 현재시간 : " + DateTime.Now);
                    this.startRandomTime = 0;
                    this.endRandomTime   = 0;

                    
                    Work = false;
                    offWork = false;
                }

                DateTime nowDt = DateTime.Now;

                if (nowDt.DayOfWeek == DayOfWeek.Saturday)
                {
                    Log_Info("오늘은 토요일. 출근 안함. 출퇴근 시간설정 스킵..");
                }
                else if (nowDt.DayOfWeek == DayOfWeek.Sunday)
                {
                    Log_Info("오늘은 일요일. 출근 안함. 출퇴근 시간설정 스킵..");
                }
                else
                {
                    if (DateTime.Now.Hour == 3 && (this.startRandomTime == 0 || this.endRandomTime == 0) )
                    {
                        if (this.startRandomTime == 0)
                        {
                            Log_Info("출근시간 초기화됨 현재시간 : " + DateTime.Now);
                            this.startRandomTime = setStartWorkTime();
                            Log_Info("출근시간 으로 초기화됨 현재시간 : " + DateTime.Now + " 제대로 출근시간 설정됐나? 세팅된 출근시간 : " + this.startRandomTime);
                        }
                        if (this.endRandomTime == 0)
                        {
                            Log_Info("시간 됐다 초기화 한다. 현재시간 : " + DateTime.Now);
                            this.endRandomTime = setEndWorkTime();
                            Log_Info("퇴근시간 0으로 초기화됨 현재시간 : " + DateTime.Now + " 제대로 퇴근시간 설정됐나? 세팅된 퇴근시간 : " + this.endRandomTime);
                        }
                    }

                    
                }

                Thread.Sleep(1000);
            }
        }


        private int setStartWorkTime()
        {
            //------------- 출근시간 세팅 시작 -----------------
            string stT1 = workStartT1.Text;
            string stT2 = workStartT2.Text;

            int stT1int = Int32.Parse(stT1);
            int stT2int = Int32.Parse(stT2);

            int startRandomTime;
            
            Random random = new Random();

            startRandomTime = random.Next(stT1int , stT2int+1);

            //int removeSec = startRandomTime;

            DateTime setStart;

            // 출근시간 범위의 처음부분보다 작거나(미만) 크다면(초과) 다시 세팅


            if (stT1int * 100 < startRandomTime && startRandomTime < stT2int * 100)
            {
                try
                {
                    //Console.WriteLine("try 안쪽");
                    string str = Convert.ToString(startRandomTime);
                    if (str.Length < 6)
                    {
                        //Console.WriteLine("if 문 합격");
                        str = "0" + str;
                    }
                    //Console.WriteLine("str : " + str);
                    setStart = DateTime.ParseExact(str, "HHmmss", null);
                }
                catch (Exception e)
                {
                    //Console.WriteLine("parse to Date is Error \nstartRandomTime : " + startRandomTime + " ErrorLog : " + e.Message );
                    Log_Info("parse to Date is Error \nstartRandomTime : " + startRandomTime + " ErrorLog : " + e.Message);
                    startRandomTime = 0;
                }
            }



            while (stT1int * 100 > startRandomTime || startRandomTime > stT2int * 100 || startRandomTime == 0)
            {

                startRandomTime = random.Next(stT1int, stT2int + 1);
                startRandomTime = startRandomTime * 100;
                startRandomTime += random.Next(0, 60);

                if (stT1int * 100 < startRandomTime || startRandomTime < stT2int * 100) {
                    try 
                    {
                        //Console.WriteLine("try 안쪽");
                        string str = Convert.ToString(startRandomTime);
                        if(str.Length < 6)
                        {
                            //Console.WriteLine("if 문 합격");
                            str = "0" + str;
                        }
                        //Console.WriteLine("str : " + str);
                        setStart = DateTime.ParseExact(str , "HHmmss" , null);
                    }
                    catch (Exception e)
                    {
                        //Console.WriteLine("parse to Date is Error \nstartRandomTime : "+ startRandomTime + " Error log : " + e.Message);
                        Log_Info("parse to Date is Error \nstartRandomTime : "+ startRandomTime + " Error log : " + e.Message);
                        startRandomTime = 0;
                        continue;
                    }
                }
            }
            
            //Console.WriteLine("stT1int = {0}", stT1int);
            //Console.WriteLine("stT2int = {0}", stT2int);
            //Console.WriteLine("stRandomTime = {0}", startRandomTime);
            Log_Info("출근시간 세팅 완료 stRandomTime = " + startRandomTime);
            //------------- 출근시간 세팅 완료 -----------------

            string tmp = Convert.ToString(startRandomTime);
            this.Invoke( 
                new Action ( delegate () {
                    settingStartWorkTime.Text = tmp;
                    }
                )
            );
            return startRandomTime;
        }

        private int setEndWorkTime()
        {
            //------------- 퇴근시간 세팅 시작 -----------------
            string endT1 = offWorkT1.Text;
            string endT2 = offWorkT2.Text;

            int endT1int = Int32.Parse(endT1);
            int endT2int = Int32.Parse(endT2);
            int endRandomTime;

            Random random = new Random();

            endRandomTime = random.Next(endT1int, endT2int + 1);

            //int removeSec = endRandomTime;

            DateTime setEnd;

            // 퇴근시간 범위의 처음부분보다 작거나(미만) 크다면(초과) 다시 세팅

            if (endT1int * 100 < endRandomTime || endRandomTime < endT2int * 100)
            {
                try
                {
                    string str = Convert.ToString(endRandomTime);
                    if (str.Length < 6)
                    {
                        str = "0" + str;
                    }
                    setEnd = DateTime.ParseExact(str, "HHmmss", null);
                }
                catch (Exception e)
                {
                    //Console.WriteLine("parse to Date is Error \nendRandomTime : " + endRandomTime + " Error log : " + e.Message);
                    Log_Info("parse to Date is Error \nendRandomTime : " + endRandomTime + " Error log : " + e.Message);
                    endRandomTime = 0;
                }
            }

            while (endT1int * 100 > endRandomTime || endRandomTime > endT2int * 100 || endRandomTime == 0)
            {
                endRandomTime = random.Next(endT1int, endT2int + 1);
                endRandomTime = endRandomTime * 100;
                endRandomTime += random.Next(0, 60);

                if (endT1int * 100 < endRandomTime || endRandomTime < endT2int * 100)
                {
                    try
                    {
                        string str = Convert.ToString(endRandomTime);
                        if (str.Length < 6)
                        {
                            str = "0" + str;
                        }
                        setEnd = DateTime.ParseExact(str, "HHmmss", null);
                    }
                    catch (Exception e)
                    {
                        //Console.WriteLine("parse to Date is Error \nendRandomTime : " + endRandomTime + " Error log : " + e.Message);
                        Log_Info("parse to Date is Error \nendRandomTime : " + endRandomTime + " Error log : " + e.Message);
                        endRandomTime = 0;
                        continue;
                    }
                }
            }
            //Console.WriteLine("endT1int = {0}", endT1int);
            //Console.WriteLine("endT2int = {0}", endT2int);
            //Console.WriteLine("endRandomTime = {0}", endRandomTime);
            Log_Info("퇴근시간 세팅 완료 endRandomTime = " + endRandomTime);
            //------------- 퇴근시간 세팅 완료 -----------------
            string tmp = Convert.ToString(endRandomTime);

            this.Invoke(
                new Action(delegate () {
                    settingEndWorkTime.Text = tmp;
                    }
                )
            );

            return endRandomTime;
        }

        private void workStartTimeTest_Click(object sender, EventArgs e)
        {
            closeAllChrome();
            //int aa = setStartWorkTime();
            //MessageBox.Show("StartRandomTime Set\nSet Time : " +  aa );
        }

        public bool Log_Info(string strMsg)
        {
            try
            {
                string strCheckFolder = ""; 
                string strFileName = ""; 
                //현재 EXE 파일가 위치 하고 있는 폴더를 가져옴.
                string strLocal = Application.ExecutablePath.Substring(0, Application.ExecutablePath.LastIndexOf("\\")); 
                
                //로그 폴더가 없으면 생성
                strCheckFolder = strLocal + "\\Log"; 
                if (!System.IO.Directory.Exists(strCheckFolder)) 
                { 
                    System.IO.Directory.CreateDirectory(strCheckFolder); 
                } 
                
                strFileName = strCheckFolder + "\\" + DateTime.Now.ToString("yyyyMMdd") + ".txt"; 
                System.IO.StreamWriter FileWriter = new System.IO.StreamWriter(strFileName, true) ; 
                FileWriter.Write(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + " => " + strMsg + "\r\n"); 
                FileWriter.Flush(); 
                FileWriter.Close(); 
            } 
            catch 
            { 
                return false; 
            } 
        
            return true; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IdText.Text = Properties.Settings.Default.userIdSetValue;
            workStartT1.Text = Properties.Settings.Default.workStartT1SetValue;
            workStartT2.Text = Properties.Settings.Default.workStartT2SetValue;
            offWorkT1.Text = Properties.Settings.Default.offWorkT1SetValue;
            offWorkT2.Text = Properties.Settings.Default.offWorkT2SetValue;
            onOffTimesetting.Text = Properties.Settings.Default.onOffTimesettingSetValue;
        }


        private void alertAlram_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show(
                            "1. 로그인이 이미 되있는 인터넷 창이 있을경우\r" +
                            "   해당 창에서의 로그인이 해제될 수 있습니다.\r\r" +
                            "2. 이미 출근버튼을 눌렀을 때 다시 출근을 하게되면 \r" +
                            "   퇴근버튼을 누르게됩니다.\r" +
                            "   (반대도 동일하나 웹 자체에서 \r" +
                            "   동일한날 퇴근후 출근 불가설정되어있음)\r\r" +
                            "3. 2번의 유의사항에 따라 출근버튼을 누른후\r" +
                            "   자동 출근버튼을 눌렀을때 \r" +
                            "   현재시간이 출근시간 + 설정시간 이내라면\r" +
                            "   퇴근버튼을 클릭하게 됍니다.\r\r" +
                            "4. 주말은 출퇴근을 하지 않지만 \r" +
                            "   휴가, 공휴일은 따로 구분하지 못하므로\r" +
                            "   자동 출퇴근을 중지시켜주세요.\r\r" +
                            "5. 이 프로그램을 통해 켜진 인터넷창들은\r" +
                            "   이 프로그램이 닫힐때 전부 종료됩니다.\r\r" +
                            "6. 로그인 정보를 정확하게 입력해주세요.\r\r" +
                            "7. 본 프로그램이 실행중에서만 동작하기 때문에\r" +
                            "   컴퓨터를 종료하거나 절전모드에서는\r" +
                            "   동작하지 않습니다.\r"

                            , "주의사항" 
                );
        }

        private void IdText_Enter(object sender, EventArgs e)
        {
            if (IdText.Text  == "아이디를 입력하세요")
            {
                IdText.Text = "";
                IdText.ForeColor = Color.Black;
            }

        }

        private void IdText_Leave(object sender, EventArgs e)
        {
            if (IdText.Text.Length == 0)
            {
                IdText.Text = "아이디를 입력하세요";
                IdText.ForeColor = Color.Gray;
            }
        }

        private bool isInfoReady()
        {
            if (PassText.Text == null || PassText.Text.Equals(PwPlaceholder))
            {
                MessageBox.Show("비밀번호를 입력해주세요", "경고");
                return false;
            }

            return true;
        }


        private void addStartProgramList_Click(object sender, EventArgs e)
        {
            AddStartupProgram("Form1", Application.ExecutablePath);
        }

        private void unaddStartProgramList_Click(object sender, EventArgs e)
        {
            RemoveStartupProgram("Form1");
        }

        private static readonly string _startupRegPath = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run";

        private Microsoft.Win32.RegistryKey GetRegKey(string regPath, bool writable)
        {
            return Microsoft.Win32.Registry.CurrentUser.OpenSubKey(regPath, writable);
        }

        // 부팅시 시작 프로그램 등록
        public void AddStartupProgram(string programName, string executablePath)
        {
            MessageBox.Show("부팅시 자동 실행 프로그램에 등록합니다." , "알림");
            using (var regKey = GetRegKey(_startupRegPath, true))
            {
                try
                {
                    // 키가 이미 등록돼 있지 않을때만 등록
                    if (regKey.GetValue(programName) == null)
                        regKey.SetValue(programName, executablePath);

                    regKey.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            MessageBox.Show("부팅시 자동 실행 프로그램에 등록했습니다.", "알림");
        }

        // 등록된 프로그램 제거
        public void RemoveStartupProgram(string programName)
        {
            MessageBox.Show("부팅시 자동 실행 프로그램에서 제외합니다.", "알림");
            using (var regKey = GetRegKey(_startupRegPath, true))
            {
                try
                {
                    // 키가 이미 존재할때만 제거
                    if (regKey.GetValue(programName) != null)
                        regKey.DeleteValue(programName, false);

                    regKey.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            MessageBox.Show("부팅시 자동 실행 프로그램에에서 제외했습니다.", "알림");
        }


    }
}
