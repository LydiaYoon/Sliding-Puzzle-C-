using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlidingPuzzle
{
    public partial class Form1 : Form
    {
        int[] data;// 데이터 배열
        PictureBox[] imgArray;// 이미지 컨트롤 배열

        int xlen, ylen; // 배열의 x길이, y길이
        int level, image; // 현재 게임의 레벨과 이미지
        bool bPlay = false; // 게임의 시작과 종료를 확인하기 위한 변수

        int nOpenCnt = 0; // 이동한 횟수를 저장하는 변수
        int nTimer = 0; // 타이머 카운터
        int bestMin = 99 , bestSec = 99; // 최고점수를 저장할 변수

        public Form1()
        {
            InitializeComponent();

            level = 1;
            image = 0;
            xlen = ylen = level + 3;

            data = new int[xlen * ylen];
            imgArray = new PictureBox[xlen * ylen];

            // 이미지컨트롤 위치 설정
            for (int i = 0; i < data.Length; i++)
            {
                imgArray[i] = new PictureBox();
                imgArray[i].Width = gamePanel.Width / xlen;
                imgArray[i].Height = gamePanel.Width / ylen;
                imgArray[i].Top = ((i / ylen) * 1 /* 공백 */  + (i / ylen) * imgArray[i].Height) /* 이미지높이 */;
                imgArray[i].Left = ((i % xlen) * 1 /* 공백 */  + (i % xlen) * imgArray[i].Width) /* 이미지넓이 */;
                imgArray[i].Click += new EventHandler(imgArray_Click); // 이벤트 처리 (델리게이트 참조)
                imgArray[i].Name = i.ToString(); // 이름을 이용해서 값을 저장한다. 이벤트시에 넘겨받을 값 필요.
                string url = "0" + (i + 1);
                url = url.Substring(url.Length - 2);
                imgArray[i].Image = (Image)global::SlidingPuzzle.Properties.Resources.ResourceManager.GetObject("img" + level + image + "_" + url);
                gamePanel.Controls.Add(imgArray[i]);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); // 어플리케이션 종료
        }

        private void btnRetry_Click(object sender, EventArgs e)
        {
            InitGame(); // 게임 초기화
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ViewCorrect();
        }

        private void ViewCorrect()
        {
            for (int i = 0; i < data.Length; i++)
            {
                string url = "0" + (i + 1);
                url = url.Substring(url.Length - 2);
                imgArray[i].Image = (Image)global::SlidingPuzzle.Properties.Resources.ResourceManager.GetObject("img" + level + image + "_" + url);
            }

            if (timeThread.Enabled == true) timeThread.Stop();
            bPlay = false;
            lblOpenCnt.Text = "Count: ";
            lblTime.Text = "00:00 ";
        }

        private void InitGame()
        {
            Random random = new Random();
            bool bCheck = false;

            nOpenCnt = 0;
            nTimer = 0;
            bPlay = true; // 게임 실행상태로 저장
            if (timeThread.Enabled == true) timeThread.Stop();

            // 중복없는 값을 만든다.
            for (int i = 0; i < data.Length; i++, bCheck = false)
            {
                int temp = random.Next(0, data.Length);

                for (int uI = 0; uI < i; uI++)
                {
                    if (data[uI] == temp)
                    {
                        i--;
                        bCheck = true;
                        break;
                    }
                }

                if (bCheck) continue;

                data[i] = temp;
                lblOpenCnt.Text = "Count: ";
                lblTime.Text = "00:00";
            }

            Shuffle();
        }

        private void imgArray_Click(object sender, EventArgs e) // 마우스로 클릭해서 이동시키는 함수
        {
            if (!bPlay) return; // 게임 종료상태라면 이동할 수 없음

            PictureBox picTemp = (PictureBox)sender;
            int nNumber = int.Parse(picTemp.Name);
            int nFlip = -1;

            //MessageBox.Show("imgArray_Click\nnNumber: " + nNumber);

            // 현재 클릭한 데이터의 주위에 마지막 데이터가 있는지 확인.
            bool bPosCheck = false;

            if ((nNumber - ylen >= 0) && data[nNumber - ylen] == (data.Length - 1))
            {
                bPosCheck = true;
                nFlip = nNumber - ylen;
            }

            if ((nNumber + ylen < data.Length) && data[nNumber + ylen] == (data.Length - 1))
            {
                bPosCheck = true;
                nFlip = nNumber + ylen;
            }

            if ((nNumber + 1 < data.Length) && data[nNumber + 1] == (data.Length - 1) && nNumber % xlen != xlen - 1)
            {
                bPosCheck = true;
                nFlip = nNumber + 1;
            }

            if ((nNumber - 1 >= 0) && data[nNumber - 1] == (data.Length - 1) && nNumber % xlen != 0)
            {
                bPosCheck = true;
                nFlip = nNumber - 1;
            }

            // 마지막 데이터가 있을 때 숫자를 교환하고 이미지를 이동시킨다.
            if (bPosCheck)
            {
                if (timeThread.Enabled == false) timeThread.Start(); // 타이머가 꺼져있다면 실행.

                //MessageBox.Show(nFlip + "");
                int tempI = data[nNumber];
                data[nNumber] = data[nFlip];
                data[nFlip] = tempI;
                nOpenCnt++;

                lblOpenCnt.Text = "Count: " + nOpenCnt;

                display();
                Check();
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) // 키보드로 입력해서 이동시키는 함수
        {
            //MessageBox.Show("ProcessCmdKey\nkeyData: " + keyData);
            if (!bPlay) return false; // 게임 종료상태라면 이동할 수 없음

            int nNumber = -1;
            int nFlip = -1;

            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == data.Length - 1)
                {
                    nNumber = i;
                    break;
                }
            }

            // 현재 누른 키의 반대편 칸이 배열 내의 값인지 확인.
            bool bPosCheck = false;

            switch (keyData)
            {
                case Keys.Down:
                    if (nNumber - ylen >= 0)
                    {
                        bPosCheck = true;
                        nFlip = nNumber - ylen;
                    }
                    break;
                case Keys.Up:
                    if (nNumber + ylen < data.Length)
                    {
                        bPosCheck = true;
                        nFlip = nNumber + ylen;
                    }

                    break;
                case Keys.Right:
                    if ((nNumber - 1 >= 0) && nNumber % xlen != 0)
                    {
                        bPosCheck = true;
                        nFlip = nNumber - 1;
                    }
                    break;
                case Keys.Left:
                    if ((nNumber + 1 < data.Length) && nNumber % xlen != xlen - 1)
                    {
                        bPosCheck = true;
                        nFlip = nNumber + 1;
                    }

                    break;
            }

            // 데이터가 있을 때 숫자를 교환하고 이미지를 이동시킨다.
            if (bPosCheck)
            {
                if (timeThread.Enabled == false) timeThread.Start(); // 타이머가 꺼져있다면 실행.

                int tempI = data[nNumber];
                data[nNumber] = data[nFlip];
                data[nFlip] = tempI;
                nOpenCnt++;

                lblOpenCnt.Text = "Count: " + nOpenCnt;

                display();
                Check();
            }

            return true;
        }

        private void Check()
        {
            for (int i = 0; i < data.Length; i++) // data 배열의 모든 값을 확인
            {
                if (data[i] != i) // 제 자리가 아니라면 반환
                {
                    return;
                }
            }

            timeThread.Stop(); // 타이머를 멈춤
            bPlay = false; // 게임 종료상태로 저장

            int secTime = (nTimer % 60); // 0초 ~ 60초
            int minTime = (nTimer % (60 * 60)) / 60; // 60초에 1분
            if (bestMin >= minTime)
            {
                bestMin = minTime;
                bestSec = secTime;
                if (bestSec >= secTime)
                {
                    bestSec = secTime;
                    lblScore.Text = string.Format("{0,2:00}:{1,2:00}", bestMin, bestSec);
                }
            }
            
            MessageBox.Show(string.Format("퍼즐이 완성되었습니다!\n{0}분 {1}초, {2}회", minTime, secTime, nOpenCnt));
        }

        private void Shuffle()
        {
            // 중복없는 값을 만든다.
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = i;
            }

            Random random = new Random();
            for (int r = 0; r < 500; r++) // 500번 무작위로 섞음
            {
                move(random.Next(0, data.Length));
            }

            display();
        }

        private void move(int nNumber)
        {
            int nFlip = -1;
            bool bPosCheck = false;
            Random random = new Random();
            int direction = random.Next(0, 4);

            //MessageBox.Show("move\nnNumber: " + nNumber + "\ndirection: " + direction);

            if ((nNumber - ylen >= 0) && data[nNumber - ylen] == (data.Length - 1))
            {
                bPosCheck = true;
                nFlip = nNumber - ylen;
            }

            if ((nNumber + ylen < data.Length) && data[nNumber + ylen] == (data.Length - 1))
            {
                bPosCheck = true;
                nFlip = nNumber + ylen;
            }

            if ((nNumber + 1 < data.Length) && data[nNumber + 1] == (data.Length - 1) && nNumber % xlen != xlen - 1)
            {
                bPosCheck = true;
                nFlip = nNumber + 1;
            }

            if ((nNumber - 1 >= 0) && data[nNumber - 1] == (data.Length - 1) && nNumber % xlen != 0)
            {
                bPosCheck = true;
                nFlip = nNumber - 1;
            }
            if (bPosCheck)
            {
                int tempI = data[nNumber];
                data[nNumber] = data[nFlip];
                data[nFlip] = tempI;
            }
        }

        private void display()
        {
            for (int i = 0; i < data.Length; i++)
            {
                string url = "0" + (data[i] + 1);
                url = url.Substring(url.Length - 2);

                if (data[i] != data.Length - 1)
                {
                    imgArray[i].Image = (Image)global::SlidingPuzzle.Properties.Resources.ResourceManager.GetObject("img" + level + image + "_" + url);
                }
                else
                {
                    imgArray[i].Image = (Image)global::SlidingPuzzle.Properties.Resources.imageBlank;
                }
            }
        }
        private void timeThread_Tick(object sender, EventArgs e)
        {
            nTimer += 1; // nTimer에 값을 1씩 누적

            int secTime = (nTimer % 60); // 0초 ~ 60초
            int minTime = (nTimer % (60 * 60)) / 60; // 60초에 1분
            lblTime.Text = string.Format("{0,2:00}:{1,2:00}", minTime, secTime);
        }

        private void btnLevel0_Click(object sender, EventArgs e)
        {
            setLevel(0);
            btnBrownLevel();
            btnRedLevel(btnLevel0);
        }

        private void btnLevel1_Click(object sender, EventArgs e)
        {
            setLevel(1);
            btnBrownLevel();
            btnRedLevel(btnLevel1);
        }

        private void btnLevel2_Click(object sender, EventArgs e)
        {
            setLevel(2);
            btnBrownLevel();
            btnRedLevel(btnLevel2);
        }

        private void btnImage0_Click(object sender, EventArgs e)
        {
            setImage(0);
            btnBrownImage();
            btnRedImage(btnImage0);
        }

        private void btnImage1_Click(object sender, EventArgs e)
        {
            setImage(1);
            btnBrownImage();
            btnRedImage(btnImage1);
        }

        private void btnImage2_Click(object sender, EventArgs e)
        {
            setImage(2);
            btnBrownImage();
            btnRedImage(btnImage2);
        }

        private void btnImage3_Click(object sender, EventArgs e)
        {
            setImage(3);
            btnBrownImage();
            btnRedImage(btnImage3);
        }

        private void btnImage4_Click(object sender, EventArgs e)
        {
            setImage(4);
            btnBrownImage();
            btnRedImage(btnImage4);
        }

        private void setLevel(int n)
        {
            level = n;
            xlen = ylen = n + 3;

            foreach (PictureBox p in imgArray)
            {
                this.Controls.Remove(p);
                p.Dispose();
            }
            
            data = new int[xlen * ylen];
            imgArray = new PictureBox[xlen * ylen];
            //MessageBox.Show("xlen:" + xlen + ", ylen:" + ylen + "\nxlen * ylen:" + xlen * ylen + "\ndata.length:" + data.Length);
            // 이미지컨트롤 위치 설정
            for (int i = 0; i < data.Length; i++)
            {
                imgArray[i] = new PictureBox();
                imgArray[i].Width = gamePanel.Width / xlen;
                imgArray[i].Height = gamePanel.Width / ylen;
                imgArray[i].Top = ((i / ylen) * 1 /* 공백 */  + (i / ylen) * imgArray[i].Height) /* 이미지높이 */;
                imgArray[i].Left = ((i % xlen) * 1 /* 공백 */  + (i % xlen) * imgArray[i].Width) /* 이미지넓이 */;
                imgArray[i].Click += new EventHandler(imgArray_Click); // 이벤트 처리 (델리게이트 참조)
                imgArray[i].Name = i.ToString(); // 이름을 이용해서 값을 저장한다. 이벤트시에 넘겨받을 값 필요.
                string url = "0" + (i + 1);
                url = url.Substring(url.Length - 2);
                imgArray[i].Image = (Image)global::SlidingPuzzle.Properties.Resources.ResourceManager.GetObject("img" + level + image + "_" + url);
                gamePanel.Controls.Add(imgArray[i]);
            }
            //nOpenCnt = 0;
            //nTimer = 0;
            InitGame();
        }

        private void setImage(int n)
        {
            image = n;

            for (int i = 0; i < data.Length; i++)
            {
                string url = "0" + (i + 1);
                url = url.Substring(url.Length - 2);
                imgArray[i].Image = (Image)global::SlidingPuzzle.Properties.Resources.ResourceManager.GetObject("img" + level + image + "_" + url);
            }
            InitGame();
        }

        private void btnBrownLevel()
        {
            btnLevel0.BackColor = Color.FromArgb(112, 95, 95);
            btnLevel0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(145, 127, 127);
            btnLevel0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(145, 127, 127);

            btnLevel1.BackColor = Color.FromArgb(112, 95, 95);
            btnLevel1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(145, 127, 127);
            btnLevel1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(145, 127, 127);

            btnLevel2.BackColor = Color.FromArgb(112, 95, 95);
            btnLevel2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(145, 127, 127);
            btnLevel2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(145, 127, 127);
        }

        private void btnBrownImage()
        {
            btnImage0.BackColor = Color.FromArgb(112, 95, 95);
            btnImage0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(145, 127, 127);
            btnImage0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(145, 127, 127);

            btnImage1.BackColor = Color.FromArgb(112, 95, 95);
            btnImage1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(145, 127, 127);
            btnImage1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(145, 127, 127);

            btnImage2.BackColor = Color.FromArgb(112, 95, 95);
            btnImage2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(145, 127, 127);
            btnImage2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(145, 127, 127);

            btnImage3.BackColor = Color.FromArgb(112, 95, 95);
            btnImage3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(145, 127, 127);
            btnImage3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(145, 127, 127);

            btnImage4.BackColor = Color.FromArgb(112, 95, 95);
            btnImage4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(145, 127, 127);
            btnImage4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(145, 127, 127);
        }

        private void btnRedLevel(Button btn)
        {
            btn.BackColor = Color.FromArgb(255, 91, 73);
            btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(255, 123, 120);
            btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(255, 123, 120);
        }

        private void btnRedImage(Button btn)
        {
            btn.BackColor = Color.FromArgb(255, 91, 73);
            btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(255, 123, 120);
            btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(255, 123, 120);
        }


    }
}
