using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                             new List<string> { "5", "6", "7", "8" }, 2)
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
               
                ScoreForm scoreForm = new ScoreForm(score, questions.Count);
                scoreForm.ShowDialog();
            }
        }


        private void btnnNext_Click_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Botão Next clicado");

            if (currentQuestion < questions.Count)
            {
                Question current = questions[currentQuestion];
                int selectedAnswer = GetSelectedAnswer();

                if (selectedAnswer == current.CorrectAnswer)
                {
                    score++;
                }

                currentQuestion++;
                ShowQuestion(currentQuestion);
            }
            else
            {
                // Caso currentQuestion atinja o número total de questões
                if (currentQuestion == questions.Count)
                {
                    // Esconder o Form1
                    this.Hide();

                    // Escolher o próximo formulário com base na pontuação
                    Form nextForm = GetNextForm();
                    nextForm.ShowDialog();

                    // Exibir novamente o Form1 após a transição (opcional)
                    this.Show();
                }
            }
        }

        private Form GetNextForm()
        {
            // Lógica para determinar o próximo formulário com base na pontuação
            if (score >= 2)
            {
                return new lblQuestion3();
            }
            else if (score == 1)
            {
                return new lblQuestion2();
            }
            else
            {
                return new ScoreForm(score, questions.Count);
            }

        }

        private int GetSelectedAnswer()
        {
            if (radioButton1.Checked) return 1;
            else if (radioButton2.Checked) return 2;
            else if (radioButton3.Checked) return 3;
            else if (radioButton4.Checked) return 4;
            else return 0; // Nenhum selecionado
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
    }

    public partial class ScoreForm : Form
    {
        private int finalScore;
        private int totalQuestions;

        public ScoreForm(int score, int total)
        {
            InitializeComponent();
            finalScore = score;
            totalQuestions = total;
            DisplayScore();
        }

        private void DisplayScore()
        {
            lblScore.Text = ("Pontuação Final é: "  + finalScore + "/" + totalQuestions);
        }
    }
}
