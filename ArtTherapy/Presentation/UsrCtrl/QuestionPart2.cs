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
    public partial class QuestionPart2 : UserControl
    {
        private int CurrentAnswer = 0;
        public Resultt result;
        private List<RadioButton> buttons = new List<RadioButton>();
        private void LoadQuestionsAndAnswersText(int QuestionNumber)
        {
            QuestionText.Text = MainQuestions.Questions2[QuestionNumber - 1].QuestionText;
            Answer1.Text = MainQuestions.Questions2[QuestionNumber - 1].AnswerAText;
            Answer2.Text = MainQuestions.Questions2[QuestionNumber - 1].AnswerBText;
            Answer3.Text = MainQuestions.Questions2[QuestionNumber - 1].AnswerCText;
        }
        private void UnCheck()
        {
            Answer1.Checked = false;
            Answer2.Checked = false;
            Answer3.Checked = false;
        }
        private void NextQestion()
        {
            CurrentAnswer = 0;
            MainForm.CurrentQuestionPart2 += 1;
            LoadQuestionsAndAnswersText(MainForm.CurrentQuestionPart2);
            QuestionNumber.Text = $"Питання {MainForm.CurrentQuestionPart2} з 5";

        }
        private void RemoveButtons()
        {
            List<int> ID = UserMood.IdOfHighest();

            foreach (int value in ID)
            {
                buttons[value].Visible = false;
            }
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
                    if (MainForm.CurrentQuestionPart2 == 5)
                    {
                        SelectAnswerPart2.Select(CurrentAnswer);
                        CurrentAnswer = 0;
                        UnCheck();
                        if (UserMood.HighestMood())
                        {
                            RemoveButtons();
                            QuestionText.Text = MainQuestions.Part2ControlQuestion.QuestionText;
                            Answer1.Text = MainQuestions.Part2ControlQuestion.AnswerAText;
                            Answer2.Text = MainQuestions.Part2ControlQuestion.AnswerBText;
                            Answer3.Text = MainQuestions.Part2ControlQuestion.AnswerCText;
                            MainForm.CurrentQuestionPart2 += 1;
                            QuestionNumber.Text = "Контрольне Запитання: ";
                        }
                        else
                        {
                            this.Hide();
                            result.Show();
                            result.BringToFront();
                            result.SetText();
                        }
                    }
                    else if (MainForm.CurrentQuestionPart2 == 6)
                    {
                        SelectAnswerPart2.Select(CurrentAnswer);
                        CurrentAnswer = 0;
                        this.Hide();
                        result.Show();
                        result.BringToFront();
                        result.SetText();

                    }
                    else
                    {
                        SelectAnswerPart2.Select(CurrentAnswer);
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
        public QuestionPart2()
        {
            InitializeComponent();
            buttons.Add(Answer1);
            buttons.Add(Answer2);
            buttons.Add(Answer3);
        }
        private void QuestionPart2_Load(object sender, EventArgs e)
        {
            NextQestion();
            PartText.Text = "Частина 2";
        }
    }
}
