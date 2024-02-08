using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Quiz.Models;
using Quiz.Services;

namespace Quiz
{
    public partial class Quiz1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                InitQuestionario();
            }
        }

        protected void InitQuestionario ()
        {
            rblAlternativas.Visible = true;
            btnProximo.Visible = true;
            lblResultado.Visible = false;
            lblPergunta.Visible = true;

            var questionario = new Questionario();
            // Carregar perguntas do arquivo JSON e selecionar 6 aleatoriamente
            questionario.CarregarPerguntas();
            var perguntasSelecionadas = questionario.SelecionarPerguntasAleatorias();

            // Armazenar as perguntas selecionadas em ViewState ou Session para uso posterior
            Session["PerguntasSelecionadas"] = perguntasSelecionadas;
            Session["IndiceAtual"] = 0;

            // Mostrar a primeira pergunta
            MostrarPerguntaAtual();
        }
        private void MostrarPerguntaAtual()
        {
            var perguntasSelecionadas = (List<Pergunta>)Session["PerguntasSelecionadas"];
            var indiceAtual = (int)Session["IndiceAtual"];

            if (indiceAtual < perguntasSelecionadas.Count)
            {
                var perguntaAtual = perguntasSelecionadas[indiceAtual];
                lblPergunta.Text = perguntaAtual.pergunta;
                rblAlternativas.Items.Clear();

                foreach (var alternativa in perguntaAtual.alternativas)
                {
                    rblAlternativas.Items.Add(new ListItem(alternativa.Value, alternativa.Key.ToString()));
                }
            }
            else
            {
                // Se todas as perguntas foram respondidas, mostra o resultado
                MostrarResultado();
            }
        }

        protected void btnStartOver_Click(object sender, EventArgs e)
        {
            InitQuestionario();
        }

        protected void btnProximo_Click(object sender, EventArgs e)
        {
            VerificarResposta();
            var indiceAtual = (int)Session["IndiceAtual"];
            indiceAtual++;
            Session["IndiceAtual"] = indiceAtual;

            MostrarPerguntaAtual();
        }

        protected void VerificarResposta()
        {
            var perguntasSelecionadas = (List<Pergunta>)Session["PerguntasSelecionadas"];
            var indiceAtual = (int)Session["IndiceAtual"];

            if (indiceAtual < perguntasSelecionadas.Count)
            {
                var perguntaAtual = perguntasSelecionadas[indiceAtual];
                var respostaSelecionada = rblAlternativas.SelectedValue;

                if (!string.IsNullOrEmpty(respostaSelecionada) && int.Parse(respostaSelecionada) == perguntaAtual.correta)
                {
                    RespostasCorretas++;
                }
            }
        }

        private void MostrarResultado()
        {
            rblAlternativas.Visible = false;
            btnProximo.Visible = false;
            lblResultado.Visible = true;
            lblPergunta.Visible = false;
            lblResultado.Text = $"<h6>Você acertou <strong>{RespostasCorretas}</strong> das <strong>{((List<Pergunta>)Session["PerguntasSelecionadas"]).Count}</strong> perguntas.</h6>";
            btnStartOver.Visible = true;
        }

        public int RespostasCorretas
        {
            get
            {
                return Session["RespostasCorretas"] != null ? (int)Session["RespostasCorretas"] : 0;
            }
            set
            {
                Session["RespostasCorretas"] = value;
            }
        }
    }
}


