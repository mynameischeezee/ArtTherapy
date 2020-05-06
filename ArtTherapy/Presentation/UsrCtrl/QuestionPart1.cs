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
        private void NextQestion()
        {
            MainForm.CurrentQuestion += 1;
            LoadQuestionsAndAnswersText(MainForm.CurrentQuestion);
        }
        private void QuestionPart1_Load(object sender, EventArgs e)
        {
            
            NextQestion();

        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (MainForm.CurrentQuestion == 12)
            {
                MainForm.CurrentQuestion = 1;
                NextQestion();
            }
            else
            {
                NextQestion();
            }
            
        }
    }
}
