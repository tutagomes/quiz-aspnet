using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quiz.Models;
using Quiz.Services;
using System;
using System.Collections.Generic;

namespace Quiz.Tests
{
    [TestClass]
    public class QuestionarioTests
    {
        private string arquivoPerguntas = "../../Dados/Perguntas.json";
        [TestMethod]
        public void AdicionarPergunta_DeveAdicionarPerguntaCorretamente()
        {
            // Arrange
            var questionario = new Questionario();
            
            questionario.CarregarPerguntas(arquivoPerguntas);
            var novaPergunta = new Pergunta { peso = 3, pergunta = "Qual é a capital da Itália?", correta = 1, categoria = "Geografia" };

            // Act
            questionario.Perguntas.Add(novaPergunta);

            // Assert
            Assert.IsTrue(questionario.Perguntas.Contains(novaPergunta));
        }

        [TestMethod]
        public void RemoverPergunta_DeveRemoverPerguntaCorretamente()
        {
            // Arrange
            var questionario = new Questionario();
            var perguntaExistente = questionario.CarregarPerguntas(arquivoPerguntas)[0];

            // Act
            questionario.Perguntas.Remove(perguntaExistente);

            // Assert
            Assert.IsFalse(questionario.Perguntas.Contains(perguntaExistente));
        }

        [TestMethod]
        public void VerificarSePerguntaExiste_DeveRetornarTrueParaPerguntaExistente()
        {
            // Arrange
            var questionario = new Questionario();
            var perguntaExistente = questionario.CarregarPerguntas(arquivoPerguntas)[0];

            // Act
            var result = questionario.Perguntas.Exists(p => p.pergunta == perguntaExistente.pergunta);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void VerificarSePerguntaExiste_DeveRetornarFalseParaPerguntaInexistente()
        {
            // Arrange
            var questionario = new Questionario();
            questionario.CarregarPerguntas(arquivoPerguntas);

            // Act
            var result = questionario.Perguntas.Exists(p => p.pergunta == null);

            // Assert
            Assert.IsFalse(result);
        }
    }
}
