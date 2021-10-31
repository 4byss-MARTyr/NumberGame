using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Game
{
    public partial class Form1 : Form
    {
        private const int DEFAULT_LIVES_COUNT = 5;
        private const int DEFAULT_WINS_TO_WIN = 3;
        private int SoughteredNumber { get; set; }
        private int Lives { get; set; } = DEFAULT_LIVES_COUNT;
        private int Wins { get; set; } = 0;


        public Form1()
        {
            Random rndObject = new Random();
            SoughteredNumber = rndObject.Next(1, 100);
            Debug.WriteLine(SoughteredNumber);


            InitializeComponent();
            ConditionInit();
            WinsNumInit();
            LivesNumInit();

        }

        private void WinsNumInit()
        {
            WinsNum.Text = $"Количество побед: {Wins}";
        }

        private void LivesNumInit()
        {
            LivesNum.Text = $"Количество жизней: {Lives}";
        }

        private void ConditionInit()
        {
            SetCondition("Ваша задача угадать число от 1 до 100.");
            if (Lives == 0)
            {
                SetCondition("У вас кончились жизни. Вы проиграли.");
                var result = MessageBox.Show("Вы проиграли! \nЖелаете начать заново?", "Вы проиграли", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Reset();
                }
                else
                {
                    Application.Exit();
                }
            }

            if (Wins == DEFAULT_WINS_TO_WIN)
            {
                SetCondition("Вы победили!");
            }
        }

        private void Reset()
        {
            Random rndObject = new Random();
            SoughteredNumber = rndObject.Next(1, 100);
            Debug.WriteLine(SoughteredNumber);
            Lives = DEFAULT_LIVES_COUNT;
            Wins = 0;
            ConditionInit();
            WinsNumInit();
            LivesNumInit();
            SetStatus(null);
            Answer.Text = "";
        }

        private void SetStatus(string text)
        {
            AnswerStatus.Text = text;
        }

        private void SetCondition(string text)
        {
            Condition.Text = text;
        }

        private void Check_Click(object sender, EventArgs e)
        {

            Submit();
            
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы точно хотите перезапустить?", "Перезапуск?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Reset();
            }
            else
            {
                return;
            }
        }

        private void AnswerKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Submit();
            }
        }

        private void Submit()
        {
            string input = Answer.Text;
            int answer = 0;
            var parseResult = int.TryParse(input, out answer);

            if (SoughteredNumber > answer)
            {
                SetStatus($"Вы ввели {answer}. Это меньше чем нужно.");
                Lives--;
            }
            if (SoughteredNumber < answer)
            {
                SetStatus($"Вы ввели {answer}. Это больше чем нужно.");
                Lives--;
            }

            if (SoughteredNumber == answer)
            {
                Lives = DEFAULT_LIVES_COUNT;
                Wins++;

                Random rndObject = new Random();
                SoughteredNumber = rndObject.Next(1, 100);
                Debug.WriteLine(SoughteredNumber);
            }
            LivesNumInit();
            WinsNumInit();
            ConditionInit();
        }
    }
}
