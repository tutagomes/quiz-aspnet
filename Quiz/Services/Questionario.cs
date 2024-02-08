using Newtonsoft.Json;
using Quiz.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;

namespace Quiz.Services
{
    public class Questionario
    {
        private List<Pergunta> _perguntas;
        public List<Pergunta> CarregarPerguntas(string caminhoArquivo = null)
        {
            if (caminhoArquivo == null) {
                caminhoArquivo = HostingEnvironment.MapPath("~/Dados/Perguntas.json");
            }
            var json = File.ReadAllText(caminhoArquivo);
            _perguntas = JsonConvert.DeserializeObject<List<Pergunta>>(json);
            return _perguntas;
        }

        public List<Pergunta> SelecionarPerguntasAleatorias(int quantidade = 6)
        {
            if (_perguntas == null || _perguntas.Count < 1)
            {
                var pergunta = new Pergunta
                {
                    pergunta = "Nenhuma pergunta carregada",
                    peso = 0,
                    categoria = "",
                    correta = -1,
                    pontuacao = 0
                };
                var lista = new List<Pergunta>();
                lista.Append(pergunta);
                return lista;
            };
            return _perguntas.Take(quantidade).ToList();
        }


    }
}