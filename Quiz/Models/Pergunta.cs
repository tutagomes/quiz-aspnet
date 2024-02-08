using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Quiz.Models
{
    public class Pergunta
    {
        public string pergunta { get; set; }
        public string categoria { get; set; }
        public Dictionary<int, string> alternativas { get; set; }
        public int pontuacao { get; set; }
        public int correta { get; set; }
        public int peso { get; set; }
    }
}