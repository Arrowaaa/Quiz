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
using System.Diagnostics.Eventing.Reader;

namespace Quiz
{
    public partial class lblQuestion : Form
    {
        private List<Question> Alternativas; // Adicionando a lista Alternativas como um campo
        private int Acertos = 0;


        public lblQuestion()
        {//Este método é chamado quando um objeto desta classe é criado. Ele inicializa os componentes, inicializa as perguntas,
         //define acertos e pontos como zero e chama o método Perguntas() para exibir a primeira pergunta.

            InitializeComponent();
            InitializeQuestions();
            
        }


        private void InitializeQuestions()
        { //Método privado que inicializa a lista de perguntas com várias instâncias da classe Question.
          //Cada instância representa uma pergunta com suas opções de resposta e a resposta correta.

            Alternativas = new List<Question>
            {
                new Question("Qual é a capital da França?",
                             new List<string> { "Madri", "Berlim", "Paris", "Londres" },
                             new List<int> { 3 }),

                 new Question("Qual é a capital da França?",
                            new List<string> { "Madri", "Berlim", "Paris", "Londres" },
                            new List<int> { 3 }),

                 new Question("Quem descobriu a penicilina?",
                            new List<string> { "Alexander Fleming", "Marie Curie", "Isaac Newton", "Albert Einstein" },
                            new List<int> { 1 }),

                 new Question("Quantos continentes existem?",
                            new List<string> { "5", "6", "7", "8" },
                            new List<int> { 2 }),

                 new Question("Qual dos seguintes é um operador de concatenação de strings válido?",
                            new List<string> { "+", "*", "→", "” “" },
                            new List<int> { 1 }),

                 new Question("Para que serve uma biblioteca em programação?",
                            new List<string> { "Para que os usuários possam consultar e tomar emprestados livros de assuntos variados",
                            "Para que os programadores possam consultar a documentação da linguagem com facilidade",
                            "Uma biblioteca é um arquivo que organiza código pré-definido para o uso em aplicações",
                            "Para modularizar o desenvolvimento de estruturas de comparação e repetição" },
                            new List<int> { 3 }),

                 new Question("Qual dos seguintes itens possui apenas tipos válidos usados em lógica de programação (tipos primitivos)?",
                            new List<string> { "Inteiro, Temporal, Caractere, Double",
                            "Booleano, Real, Inteiro",
                            "Irracional, Inteiro, Booleano, Tipografia, Double",
                            "Inteiro, Booleano, Caractere, Double" },
                            new List<int> { 4 }),

                 new Question("Qual dos seguintes itens é melhor representado por um valor constante em um algoritmo?",
                            new List<string> { "Salário de um Funcionário",
                            "Valor da Temperatura no final de semana",
                            "Valor matemático de Pi",
                            "Distância da Terra à Lua" },
                            new List<int> { 3 }),

                 new Question("Qual dos seguintes itens mostra um laço for (para) escrito corretamente?",
                            new List<string> { "for (con = 1; con <= 10; con++) { instruções }",
                            "for (con = 10; con >= 1; con++) { instruções }",
                            "for (con == 10; con > 1; con–) { instruções }",
                            "for (con = 1; con < 10; con–) { instruções }" },
                            new List<int> { 1, 4 }),

                 new Question("O que é uma Variável?",
                            new List<string> { "Local na memória CMOS do computador empregado para armazenar de forma temporária os dados que são utilizados pelo programa.",
                            "Local na memória RAM do computador utilizado para armazenar temporariamente dados que são utilizados pelo programa.",
                            "Valor que varia conforme passa o tempo, sendo sempre modificado conforme o programa vai sendo executado.",
                            "Estado lógico de uma constante, que pode variar entre verdadeiro e falso" },
                            new List<int> { 2 }),

                 new Question(" Como funciona um laço while (enquanto)?",
                        new List<string> { "Um laço while repete o bloco de código associado enquanto um teste lógico realizado retornar falso.",
                        "Um laço while não repete o bloco de código associado enquanto um teste lógico realizado retornar verdadeiro.",
                        "Um laço while repete o bloco de código associado enquanto um teste lógico realizado retornar verdadeiro",
                        "Um laço while espera enquanto o usuário não pressiona uma tecla para decidir qual caminho tomar no fluxo do algoritmo" },
                        new List<int> { 3 }),

            };

     }

        private void Perguntas(int questionNumber)
        // Método privado que exibe a próxima pergunta na interface gráfica com base no número da pergunta recebido como argumento.
        {
            if (questionNumber >= 0 && questionNumber < Alternativas.Count)
            {
                Question question = Alternativas[questionNumber];
                lblQuestionn.Text = question.QuestionText;
                radioButton1.Text = question.Escolhas[0];
                radioButton2.Text = question.Escolhas[1];
                radioButton3.Text = question.Escolhas[2];
                radioButton4.Text = question.Escolhas[3];


                if (GetSelectedAnswer() == Alternativas[questionNumber].Correta)
                {
                    Acertos++;// Incremento de Acertos se a resposta estiver correta
                }

                else
                {
                    // Lidar com o caso em que questionNumber está fora do intervalo
                    //MessageBox.Show("Todas as perguntas foram respondidas. O jogo terminou!");
                    //return
                    if (questionNumber >= 0)
                    {
                        MessageBox.Show("Resposta incorreta. A resposta correta é: " + Alternativas[questionNumber].Escolhas[Alternativas[questionNumber].Correta - 1]);
                    }
                }
            }

            else
            {
                // Lógica para lidar com o caso de todas as perguntas terem sido respondidas
                MessageBox.Show("Todas as perguntas foram respondidas. O jogo terminou!");
                return;
            }
        }


        private int GetSelectedAnswer()
        { //Método privado que verifica qual opção de resposta foi selecionada pelo usuário e retorna o número correspondente
          //à opção selecionada(radiobutton1) indica 1 para a primeira opção, 2 para a segunda e assim por diante). Retorna 0 se nenhuma opção foi selecionada.

            if (radioButton1.Checked) return 1;
            else if (radioButton2.Checked) return 2;
            else if (radioButton3.Checked) return 3;
            else if (radioButton4.Checked) return 4;
            else return 0; // Nenhum selecionado
        }

        public class Question
        { //Ela tem um getter (get) e um setter (set) automáticos.
          //Isso significa que você pode acessar o valor da propriedade usando QuestionText e atribuir um novo valor a ela.
            public string QuestionText { get; set; }
            public List<string> Escolhas { get; set; }
            public int Correta { get; set; }
            public int RespostaEscolhida { get; set; } // Adicionando a propriedade RespostaEscolhida

            public Question(string questionText, List<string> choices, List<int> respostasCorretas)
            {
                QuestionText = questionText; // Propriedade que armazena as perguntas.
                Escolhas = choices; //Propriedade que armazena as escolhas.
                Correta = respostasCorretas[0]; // Propriedade que armazena o índice da resposta correta.
            }
        }

        private void btnnNext_Click_Click(object sender, EventArgs e)
        {
            int selectedAnswer = GetSelectedAnswer();

            if (selectedAnswer > 0)
            {
                // DialogResult confirmResult = MessageBox.Show("Está seguro dessa escolha?", "Confirmação", MessageBoxButtons.YesNo);

                //if (confirmResult == DialogResult.Yes)
                {
                    if (selectedAnswer == Alternativas[Acertos].Correta)
                    {
                        Acertos++;
                    }

                    if (Acertos < Alternativas.Count) // Verifica se ainda há perguntas a serem exibidas
                    {
                        Perguntas(Acertos); // Chama a próxima pergunta
                    }
                    else
                    {
                        //Todas as perguntas foram respondidas
                        MessageBox.Show("Todas as perguntas foram respondidas. O jogo terminou!");
                        if (Acertos == Alternativas.Count) // Todas as perguntas foram respondidas corretamente
                        {
                            ScoreForm scoreForm = new ScoreForm(Acertos, Alternativas.Count, Alternativas);
                            scoreForm.ShowDialog();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma resposta.");
            }
            // Limpa a seleção dos RadioButtons
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
        }
            
    }
      

        public partial class ScoreForm : Form
        {
            private int Pontuacaofinal;
            private int totaldeperguntas;
            private List<lblQuestion.Question> Alternativas;

            public ScoreForm(int Pontos, int total, List<lblQuestion.Question> alternativas)
            {
                InitializeComponent();
                Pontuacaofinal = Pontos;
                totaldeperguntas = total;
                Alternativas = alternativas;
                DisplayScore();
            }
        private void DisplayScore()
        {
            lblScore.Text = ("Pontuação Final é: " + Pontuacaofinal + "/" + totaldeperguntas);

            foreach (var question in Alternativas)
            {
                // Supondo que você tenha uma propriedade "RespostaEscolhida" na classe Question
                if (question.RespostaEscolhida != question.Correta)
                {
                    MessageBox.Show("Você escolheu a alternativa: " + question.Escolhas[question.RespostaEscolhida - 1] +
                            ". A resposta correta era: " + question.Escolhas[question.Correta - 1]);
                }
            }
        }
    }

 
        public class Question
        {
        public string QuestionText { get; set; }
        public List<string> Escolhas { get; set; }
        public int Correta { get; set; }

        public Question(string questionText, List<string> choices, List<int> respostasCorretas)
        {
            QuestionText = questionText;
            Escolhas = choices;
            Correta = respostasCorretas[0]; // Supondo que haja apenas uma resposta correta por pergunta
        }
    }
}

