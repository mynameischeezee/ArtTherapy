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
    public partial class QuestionPart1 : UserControl
    {
        private int CurrentAnswer = 0;
        public QuestionPart1()
        {
            InitializeComponent();
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
            MainForm.CurrentQuestion += 1;
            LoadQuestionsAndAnswersText(MainForm.CurrentQuestion);
            QuestionNumber.Text = $"Питання {MainForm.CurrentQuestion} з 13";

        }
        private void QuestionPart1_Load(object sender, EventArgs e)
        {
            
            NextQestion();

        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (MainForm.CurrentQuestion == 13)
            {
                SelectAnswer.Select(CurrentAnswer);
                CurrentAnswer = 0;
                UnCheck();
                if (UserTemperament.HighestTemperament())
                {
                    QuestionText.Text = MainQuestions.Part1ControlQuestion.QuestionText;
                    Answer1.Text = MainQuestions.Part1ControlQuestion.AnswerAText;
                    Answer2.Text = MainQuestions.Part1ControlQuestion.AnswerBText;
                    Answer3.Text = MainQuestions.Part1ControlQuestion.AnswerCText;
                    Answer4.Text = MainQuestions.Part1ControlQuestion.AnswerDText;
                    MainForm.CurrentQuestion += 1;
                    QuestionNumber.Text = "Контрольне Запитання: ";
                }
                else
                {
                    MessageBox.Show("Hello Gordon");
                }
            }
            else
            {

                SelectAnswer.Select(CurrentAnswer);
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

        private void Answer4_CheckedChanged(object sender, EventArgs e)
        {
            CurrentAnswer = 4;
        }
    }
}
