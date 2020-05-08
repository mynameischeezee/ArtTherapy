using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArtTherapy.BussinesLogic;

namespace ArtTherapy.Presentation.UsrCtrl
{
    public partial class QuestionPart1 : UserControl
    {
        private int CurrentAnswer = 0;
        public QuestionPart2 Part2;
        private List<RadioButton> buttons = new List<RadioButton>();

        
        public QuestionPart1()
        {
            InitializeComponent();
            buttons.Add(Answer1);
            buttons.Add(Answer2);
            buttons.Add(Answer3);
            buttons.Add(Answer4);
        }
        private void LoadQuestionsAndAnswersText(int QuestionNumber)
        {
            QuestionText.Text = MainQuestions.Questions1[QuestionNumber - 1].QuestionText;
            Answer1.Text = MainQuestions.Questions1[QuestionNumber - 1].AnswerAText;
            Answer2.Text = MainQuestions.Questions1[QuestionNumber - 1].AnswerBText;
            Answer3.Text = MainQuestions.Questions1[QuestionNumber - 1].AnswerCText;
            Answer4.Text = MainQuestions.Questions1[QuestionNumber - 1].AnswerDText;
        }
        private void UnCheck()
        {
            Answer1.Checked = false;
            Answer2.Checked = false;
            Answer3.Checked = false;
            Answer4.Checked = false;
        }
        private void NextQestion()
        {
            CurrentAnswer = 0;
            MainForm.CurrentQuestionPart1 += 1;
            LoadQuestionsAndAnswersText(MainForm.CurrentQuestionPart1);
            QuestionNumber.Text = $"Питання {MainForm.CurrentQuestionPart1} з 13";

        }
        private void RemoveButtons()
        {
            List<int> ID = UserTemperament.IdOfHighest();

            foreach (int value in ID)
            {
                buttons[value].Visible = false;
            }
        }
        private void QuestionPart1_Load(object sender, EventArgs e)
        {
            
            NextQestion();

        }

        private void Next_Click(object sender, EventArgs e)
        {
            try
            {
                if (CurrentAnswer == 0)
                {
                    throw new Exception("No answer");
                }
                else
                {
                    if (MainForm.CurrentQuestionPart1 == 13)
                    {
                        SelectAnswerPart1.Select(CurrentAnswer);
                        CurrentAnswer = 0;
                        UnCheck();
                        if (UserTemperament.HighestTemperament())
                        {
                            RemoveButtons();
                            QuestionText.Text = MainQuestions.Part1ControlQuestion.QuestionText;
                            Answer1.Text = MainQuestions.Part1ControlQuestion.AnswerAText;
                            Answer2.Text = MainQuestions.Part1ControlQuestion.AnswerBText;
                            Answer3.Text = MainQuestions.Part1ControlQuestion.AnswerCText;
                            Answer4.Text = MainQuestions.Part1ControlQuestion.AnswerDText;
                            MainForm.CurrentQuestionPart1 += 1;
                            QuestionNumber.Text = "Контрольне Запитання: ";
                        }
                        else
                        {
                            Part2.Show();
                            Part2.BringToFront();
                            this.Hide();
                        }
                    }
                    else if (MainForm.CurrentQuestionPart1 == 14)
                    {
                        SelectAnswerPart1.Select(CurrentAnswer);
                        CurrentAnswer = 0;
                        Part2.Show();
                        Part2.BringToFront();
                        this.Hide();
                    }
                    else
                    {

                        SelectAnswerPart1.Select(CurrentAnswer);
                        CurrentAnswer = 0;
                        UnCheck();
                        NextQestion();
                    }
                }
            }

            catch
            {
                MessageBox.Show("Відповідь не обрана, оберіть відповідь.", "Увага !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Answer1_CheckedChanged(object sender, EventArgs e)
        {
            CurrentAnswer = 1;
        }

        private void Answer2_CheckedChanged(object sender, EventArgs e)
        {
            CurrentAnswer = 2;
        }

        private void Answer3_CheckedChanged(object sender, EventArgs e)
        {
            CurrentAnswer = 3;
        }

        private void Answer4_CheckedChanged(object sender, EventArgs e)
        {
            CurrentAnswer = 4;
        }
    }
}
