﻿using System;
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
            MainForm.CurrentQuestionPart2 += 1;
            LoadQuestionsAndAnswersText(MainForm.CurrentQuestionPart2);
            QuestionNumber.Text = $"Питання {MainForm.CurrentQuestionPart2} з 5";

        }
        private void Next_Click(object sender, EventArgs e)
        {
            if (MainForm.CurrentQuestionPart2 == 5)
            {
                SelectAnswerPart2.Select(CurrentAnswer);
                CurrentAnswer = 0;
                UnCheck();
                if (UserMood.HighestMood())
                {
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
                
            }
            else
            {
                SelectAnswerPart2.Select(CurrentAnswer);
                CurrentAnswer = 0;
                UnCheck();
                NextQestion();
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
        }
        private void QuestionPart2_Load(object sender, EventArgs e)
        {
            NextQestion();
            PartText.Text = "Частина 2";
        }
    }
}
