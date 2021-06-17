using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestFormApp
{
    public partial class Form1 : Form
    {
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        public List<Buttons> buttons = new List<Buttons>();
        public List<ButtonSequence> sequence = new List<ButtonSequence>();
        public int Level = 1;
        public int levelcount = 4;
        public int ClickPosition = 1;
        public Form1()
        {
            InitializeComponent();
            buttons.Add(new Buttons { ButtonId = 1, ButtonColor = "Green" });
            buttons.Add(new Buttons { ButtonId = 2, ButtonColor = "Blue" });
            buttons.Add(new Buttons { ButtonId = 3, ButtonColor = "Red" });
            buttons.Add(new Buttons { ButtonId = 4, ButtonColor = "Yellow" });
            lblLevel.Text = Level.ToString();
            lblSequence.Text = levelcount.ToString();
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            ClickPosition = 1;
            sequence.Clear();
            lblStatus.Visible = false;

            int i = 1;
            int cd = 3;
           
            while (cd >= 1)
            {
                await CountDown(cd);
                cd--;
            }
            lblCountDown.Visible = false;
            while (i <= levelcount)
            {                
                await Start(i);
               i++;
            }
            lblCountDown.Text = "GO!";
            lblCountDown.Visible = true;
        }
        public async Task CountDown(int number)
        {
            lblCountDown.Visible = true;
            lblCountDown.Text = number.ToString();
            await Task.Delay(1000);
            lblCountDown.Visible = false;
        }
        public async Task Start(int position)
        {
            Random rd = new Random();
            await Task.Delay(500);

            int rand_num = rd.Next(1, 5);
            if (rand_num == 1)
            {
                btnGreen.BackColor = Color.Green;
            }
            else if (rand_num == 2)
            {

            btnBlue.BackColor = Color.Blue;
            }
            else if (rand_num == 3)
            {
                btnRed.BackColor = Color.Red;
            }
            else if (rand_num == 4)
            {
                btnYellow.BackColor = Color.Yellow;
            }
            var btnChose = buttons.Where(r => r.ButtonId == rand_num).FirstOrDefault();
            sequence.Add(new ButtonSequence { ButtonId = btnChose.ButtonId, ButtonColor = btnChose.ButtonColor, Position = position });
            await Task.Delay(500);
            btnBlue.BackColor = Color.Transparent;
            btnGreen.BackColor = Color.Transparent;
            btnRed.BackColor = Color.Transparent;
            btnYellow.BackColor = Color.Transparent;
        }
        public void Fail()
        {
            //lblStatus.Text = "FAIL";
            lblCountDown.Text = "FAIL";
           // lblStatus.Visible = true;
            ClickPosition = 1;
            Level = 1;
            levelcount = 4;
            lblLevel.Text = Level.ToString();
            lblSequence.Text = levelcount.ToString();
            sequence.Clear();
            btnBlue.BackColor = Color.Transparent;
            btnGreen.BackColor = Color.Transparent;
            btnRed.BackColor = Color.Transparent;
            btnYellow.BackColor = Color.Transparent;
        }
        public void Success()
        {
            var sequenceCount = sequence.Count();
            if (ClickPosition == sequenceCount)
            {
               // lblStatus.Text = "SUCCESS";
                lblCountDown.Text = "SUCCESS";
              //  lblStatus.Visible = true;
                ClickPosition = 1;
                Level = Level + 1;
                levelcount = levelcount + 1;
                lblLevel.Text = Level.ToString();
                lblSequence.Text = levelcount.ToString();
                sequence.Clear();
                btnBlue.BackColor = Color.Transparent;
                btnGreen.BackColor = Color.Transparent;
                btnRed.BackColor = Color.Transparent;
                btnYellow.BackColor = Color.Transparent;
            }
            ClickPosition = ClickPosition + 1;
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            ClickPosition = 1;
            Level = 1;
            levelcount = 4;
            lblCountDown.Text = "";
            lblLevel.Text = Level.ToString();
            lblSequence.Text = levelcount.ToString();
            sequence.Clear();
            btnBlue.BackColor = Color.Transparent;
            btnGreen.BackColor = Color.Transparent;
            btnRed.BackColor = Color.Transparent;
            btnYellow.BackColor = Color.Transparent;
        }

        private void btnBlue_MouseDown(object sender, MouseEventArgs e)
        {
            if (levelcount == sequence.Count())
            {
                var btn = sequence.Where(r => r.Position == ClickPosition).FirstOrDefault();
                if (btn.ButtonId == 2)
                {
                    btnBlue.BackColor = Color.Blue;
                    Success();
                }
                else
                {
                    btnBlue.BackColor = Color.Orange;
                    Fail();
                }
            }
            else
            {
                btnBlue.BackColor = Color.Blue;
            }
        }

        private void btnBlue_MouseUp(object sender, MouseEventArgs e)
        {
            btnBlue.BackColor = Color.Transparent;
        }

        private void btnGreen_MouseDown(object sender, MouseEventArgs e)
        {
            if (levelcount == sequence.Count())
            {
                
                var btn = sequence.Where(r => r.Position == ClickPosition).FirstOrDefault();
                if (btn.ButtonId == 1)
                {
                    btnGreen.BackColor = Color.Green;                   
                    Success();
                }
                else
                {
                    btnGreen.BackColor = Color.Orange;
                    Fail();
                }
            }
            else
            {
                btnGreen.BackColor = Color.Green;
            }
        }

        private void btnGreen_MouseUp(object sender, MouseEventArgs e)
        {
            btnGreen.BackColor = Color.Transparent;
        }

        private void btnRed_MouseDown(object sender, MouseEventArgs e)
        {
            if (levelcount == sequence.Count())
            {               
                var btn = sequence.Where(r => r.Position == ClickPosition).FirstOrDefault();
                if (btn.ButtonId == 3)
                {
                    btnRed.BackColor = Color.Red;              
                    Success();
                }
                else
                {
                    btnRed.BackColor = Color.Orange;
                    Fail();
                }
            }
            else
            {
                btnRed.BackColor = Color.Red;
            }
        }

        private void btnRed_MouseUp(object sender, MouseEventArgs e)
        {
            btnRed.BackColor = Color.Transparent;
        }

        private void btnYellow_MouseDown(object sender, MouseEventArgs e)
        {
            if (levelcount == sequence.Count())
            {
                var btn = sequence.Where(r => r.Position == ClickPosition).FirstOrDefault();
                if (btn.ButtonId == 4)
                {
                    btnYellow.BackColor = Color.Yellow;
                    Success();
                }
                else
                {
                    btnYellow.BackColor = Color.Orange;
                    Fail();
                }
            }
            else
            {
                btnYellow.BackColor = Color.Yellow;
            }
        }

        private void btnYellow_MouseUp(object sender, MouseEventArgs e)
        {
            btnYellow.BackColor = Color.Transparent;
        }

    }
    public class Buttons
    {
        public int ButtonId { get; set; }
        public string ButtonColor { get; set; }
    }
    public class ButtonSequence
    {
        public int ButtonId { get; set; }
        public string ButtonColor { get; set; }
        public int Position { get; set; }
    }
}
