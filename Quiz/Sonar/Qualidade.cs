using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Quiz.Sonar
{
    public class Qualidade
    {
        // 6. Código Duplicado
        public void ProcessPayment(Payment payment)
        {
            Console.WriteLine("Processamento de pagamento iniciado.");
            Console.WriteLine("Processamento de pagamento iniciado."); // Código duplicado
        }

        // 7. Métodos Muito Longos
        public void PlaceOrder(Order order)
        {
            // Lógica complexa e extensa para processar o pedido
        }

        // 8. Classe com Muitas Responsabilidades
        public class UserManager
        {
            public void CreateUser() { }
            public void UpdateUser() { }
            public void DeleteUser() { }
            public void LogActivity() { }
            public void SendEmail() { }
        }

        // 9. Comentários Obsoletos
        public void GetProduct(int productId)
        {
            // Este método busca o produto pelo nome (comentário obsoleto)
            // Código que busca o produto pelo ID
        }

        // 10. Código Não Utilizado
        public void OldMethod()
        {
            // Método antigo não utilizado
        }

        // 11. Uso Ineficiente de Loops
        public void GenerateReport(List<Data> data)
        {
            foreach (var item in data)
            {
                foreach (var subItem in data)
                {
                    // Processamento ineficiente
                }
            }
        }

        // 12. I/O Síncrona
        public void ReadFile(string filePath)
        {
            var content = File.ReadAllText(filePath);
            // Processar conteúdo
        }

        // 13. Falta de Uso de Caching
        public List<Data> GetData()
        {
            var data = Database.GetData();
            return data;
        }

        // 14. Uso Excessivo de Memória
        public void ProcessData(List<Data> data)
        {
            var largeList = new List<LargeObject>();
            foreach (var item in data)
            {
                largeList.Add(new LargeObject()); // Uso desnecessário de memória
            }
        }

        // 15. Consultas SQL Ineficientes
        public List<User> GetAllUsers()
        {
            var query = "SELECT * FROM Users";
            // Código para executar a consulta
            return new List<User>();
        }

        // 16. Nomes de Variáveis Não Descritivos
        public void Calculate(int a, int b)
        {
            var x = a + b;
            // Código de cálculo
        }

        // 17. Falta de Consistência no Estilo de Codificação
        public void DoSomething()
        {
            var x = 10; // Sem espaços
            var y = 20; // Com espaços
        }

        // 18. Métodos com Muitos Parâmetros
        public void ComplexMethod(int a, int b, int c, int d, int e, int f)
        {
            // Código complexo
        }

        // 19. Linhas de Código Muito Longas
        public void ExampleMethod()
        {
            var example = "Este é um exemplo de uma linha de código que é muito longa e deve ser quebrada em várias linhas para melhorar a legibilidade e manter o código organizado.";
        }

        // 20. Uso Inadequado de Exceções
        public void DoSomethingWithExceptions()
        {
            try
            {
                // Código que pode lançar uma exceção
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message); // Captura de exceção genérica
            }
        }

        // 21. Dependências Não Gerenciadas
        public void UseExternalLibrary()
        {
            var library = new ExternalLibrary();
            library.DoSomething();
        }

        // 22. Falta de Testes Unitários
        public void PerformCriticalOperation()
        {
            // Operação crítica sem testes unitários
        }

        // 23. Uso de APIs Desatualizadas
        public void UseOldApi()
        {
            var oldApi = new OldApi();
            oldApi.DoSomething();
        }

        // 24. Hardcoding de Valores
        public void ConfigureService()
        {
            var timeout = 30; // Valor hardcoded
        }

        // 25. Falta de Modularização
        public class MonolithicClass
        {
            public void DoEverything()
            {
                // Código que faz muitas coisas
            }
        }
    }

    // Classes de suporte usadas no exemplo
    public class Payment
    {
        // Propriedades e métodos da classe Payment
    }

    public class Order
    {
        // Propriedades e métodos da classe Order
    }

    public class Data
    {
        // Propriedades e métodos da classe Data
    }

    public class LargeObject
    {
        // Propriedades e métodos da classe LargeObject
    }

    public class ExternalLibrary
    {
        public void DoSomething()
        {
            // Código da biblioteca externa
        }
    }

    public class OldApi
    {
        public void DoSomething()
        {
            // Código da API desatualizada
        }
    }

    public static class Database
    {
        public static List<Data> GetData()
        {
            // Simulação de obtenção de dados do banco de dados
            return new List<Data>();
        }
    }

    public class User
    {
        public string Username { get; set; }
        public string Email { get; set; }
    }
}