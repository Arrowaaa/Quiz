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
                             new List<string> { "5", "6", "7", "8" }, 2),

                new Question("Qual dos seguintes é um operador de concatenação de strings válido?",
                             new List<string> { "+", "*", "→", "” “" }, 1),

                new Question("Para que serve uma biblioteca?",
                             new List<string> { "Para que os usuários possam consultar e tomar emprestados livros de assuntos variados",
                                 "Para que os programadores possam consultar a documentação da linguagem com facilidade", 
                                 "Uma biblioteca é um arquivo que organiza código pré-definido para o uso em aplicações", 
                                 "Para modularizar o desenvolvimento de estruturas de comparação e repetição" }, 3),

                new Question("Qual dos seguintes itens possui apenas tipos válidos usados em lógica de programação (tipos primitivos)?",
                             new List<string> { "Inteiro, Temporal, Caractere, Double",
                                 "Booleano, Real, Inteiro", 
                                 "Irracional, Inteiro, Booleano, Tipografia, Double", 
                                 "Inteiro, Booleano, Caractere, Double" }
                             , 4),

                new Question("Qual dos seguintes itens é melhor representado por um valor constante em um algoritmo?",
                             new List<string> { "Salário de um Funcionário", 
                                 "Valor da Temperatura no final de semana", 
                                 "Valor matemático de Pi", 
                                 "Distância da Terra à Lua" }, 3),

                new Question("Qual dos seguintes itens mostra um laço for (para) escrito corretamente?",
                             new List<string> { "para (con = 1; con <= 10; con++) { instruções }", 
                                 "para (con = 10; con >= 1; con++) { instruções }",
                                 "para (con == 10; con > 1; con–) { instruções }", 
                                 "para (con = 1; con < 10; con–) { instruções }" }, 1),

                new Question("O que é uma Variável?",
                             new List<string> { "Local na memória CMOS do computador empregado para armazenar de forma temporária os dados que são utilizados pelo programa.", 
                                 "Local na memória RAM do computador utilizado para armazenar temporariamente dados que são utilizados pelo programa.", 
                                 "Valor que varia conforme passa o tempo, sendo sempre modificado conforme o programa vai sendo executado.", 
                                 "Estado lógico de uma constante, que pode variar entre verdadeiro e falso" }, 2),
                
                new Question(" Como funciona um laço while (enquanto)?",
                             new List<string> { "Um laço while repete o bloco de código associado enquanto um teste lógico realizado retornar falso.", 
                                 "Um laço while não repete o bloco de código associado enquanto um teste lógico realizado retornar verdadeiro.",
                                 "Um laço while repete o bloco de código associado enquanto um teste lógico realizado retornar verdadeiro", 
                                 "Um laço while espera enquanto o usuário não pressiona uma tecla para decidir qual caminho tomar no fluxo do algoritmo" }, 3),
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

        private void btnnNext_Click_Click(object sender, EventArgs e)
        {
            // Verifica se uma opção foi selecionada
            int selectedAnswer = GetSelectedAnswer();

            if (selectedAnswer > 0)
            {
                // Verifica se a resposta selecionada está correta
                if (selectedAnswer == questions[currentQuestion].CorrectAnswer)
                {
                    score++; // Incrementa a pontuação se a resposta estiver correta
                }

                // Avança para a próxima pergunta
                currentQuestion++;

                // Exibe a próxima pergunta ou mostra a pontuação final se todas as perguntas foram respondidas
                ShowQuestion(currentQuestion);
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
