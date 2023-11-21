using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Quiz
{
    public partial class lblQuestion : Form
    {
        private List<Question> questions;
        private int currentQuestion;
        private int score;
        public lblQuestion()
        {
            InitializeComponent();
            InitializeQuestions();
            currentQuestion = 0;
            score = 0;
            ShowQuestion(currentQuestion);
        }
        private void InitializeQuestions()
        {
            questions = new List<Question>
            {
                new Question("Qual é a capital da França?",
                             new List<string> { "Madri", "Berlim", "Paris", "Londres" }, 3),
                new Question("Quem descobriu a penicilina?",
                             new List<string> { "Alexander Fleming", "Marie Curie", "Isaac Newton", "Albert Einstein" }, 1),
                new Question("Quantos continentes existem?",
                             new List<string> { "5", "6", "7", "8" }, 3)
            };
        }

        private void ShowQuestion(int questionNumber)
        {
            if (questionNumber < questions.Count)
            {
                Question question = questions[questionNumber];
                lblQuestionn.Text = question.QuestionText;
                radioButton1.Text = question.Choices[0];
                radioButton2.Text = question.Choices[1];
                radioButton3.Text = question.Choices[2];
                radioButton4.Text = question.Choices[3];
            }
            else
            {
                MessageBox.Show($"Quiz completo! Sua pontuação final é {score}/{questions.Count}");
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentQuestion < questions.Count)
            {
                Question current = questions[currentQuestion];
                int selectedAnswer = 0;
                if (radioButton1.Checked)
                {
                    selectedAnswer = 1;
                }
                else if (radioButton2.Checked)
                {
                    selectedAnswer = 2;
                }
                else if (radioButton3.Checked)
                {
                    selectedAnswer = 3;
                }
                else if (radioButton4.Checked)
                {
                    selectedAnswer = 4;
                }

                if (selectedAnswer == current.CorrectAnswer)
                {
                    score++;
                }

                currentQuestion++;
                ShowQuestion(currentQuestion);
            }
        }


        public class Question
        {
            public string QuestionText { get; set; }
            public List<string> Choices { get; set; }
            public int CorrectAnswer { get; set; }

            public Question(string questionText, List<string> choices, int correctAnswer)
            {
                QuestionText = questionText;
                Choices = choices;
                CorrectAnswer = correctAnswer;
            }
        }

        private void btnnNext_Click_Click(object sender, EventArgs e)
        {
                if (currentQuestion < questions.Count)
                {
                    Question current = questions[currentQuestion];
                    int selectedAnswer = 0;
                    if (radioButton1.Checked)
                    {
                        selectedAnswer = 1;
                    }
                    else if (radioButton2.Checked)
                    {
                        selectedAnswer = 2;
                    }
                    else if (radioButton3.Checked)
                    {
                        selectedAnswer = 3;
                    }
                    else if (radioButton4.Checked)
                    {
                        selectedAnswer = 4;
                    }

                    if (selectedAnswer == current.CorrectAnswer)
                    {
                        score++;
                    }

                    currentQuestion++;
                    ShowQuestion(currentQuestion);
                
            }
        }
    }
}
