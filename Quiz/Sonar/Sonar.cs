using System;
using System.Data.SqlClient;

namespace Quiz
{
    public class Sonar2
    {
        // Complexidade ciclomática alta
        public void ComplexMethod()
        {
            int x = 0;
            if (x == 0)
            {
                Console.WriteLine("Zero");
            }
            else if (x == 1)
            {
                Console.WriteLine("One");
                if (x ==1 )
                {
                    Console.WriteLine("One");
                    if (x == 1)
                    {
                        Console.WriteLine("One");
                        if (x == 1)
                        {
                            Console.WriteLine("One");
                        }
                    }
                }
            }
            else if (x == 2)
            {
                Console.WriteLine("Two");
            }
            else
            {
                Console.WriteLine("Other");
            }
        }

        // Comentário de código
        // Este método faz algo importante
        public int DoSomething(int a)
        {
            // var a = "teste";
            // Console.WriteLine(a);
            var b = 30;
            Console.WriteLine("Doing something");
            return b + b;
        }

        // Uso de string literais em código
        public string GetGreeting()
        {
            var a = "Hello, World!";
            var b = "Hello, World!";
            var c = "Hello, World!";
            var d = "Hello, World!";
            var e = "Hello, World!";
            var f = "Hello, World!";
            return "Hello, World!";
        }

        // Nomes de variáveis inadequados e muitos parametros
        public void Calculate(int a, int b, int c, int d, int e, int f, int g, int h, int j)
        {
            int resultado = a + b;
            Console.WriteLine("Sum: " + c);
        }

        // Funções muito longas
        public void LongFunction()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Line " + i);
            }
            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine("Line " + j);
            }
            for (int k = 0; k < 10; k++)
            {
                Console.WriteLine("Line " + k);
            }
            for (int k = 0; k < 10; k++)
            {
                Console.WriteLine("Line " + k);
            }
            for (int k = 0; k < 10; k++)
            {
                Console.WriteLine("Line " + k);
            }
            for (int k = 0; k < 10; k++)
            {
                Console.WriteLine("Line " + k);
            }
            for (int k = 0; k < 10; k++)
            {
                Console.WriteLine("Line " + k);
            }
            for (int k = 0; k < 10; k++)
            {
                Console.WriteLine("Line " + k);
            }
            for (int k = 0; k < 10; k++)
            {
                Console.WriteLine("Line " + k);
            }
            for (int k = 0; k < 10; k++)
            {
                Console.WriteLine("Line " + k);
            }
            for (int k = 0; k < 10; k++)
            {
                Console.WriteLine("Line " + k);
            }
            for (int k = 0; k < 10; k++)
            {
                Console.WriteLine("Line " + k);
            }
            for (int k = 0; k < 10; k++)
            {
                Console.WriteLine("Line " + k);
            }

        }

        // Problema de segurança: SQL Injection
        public void VulnerableMethod(string userInput)
        {
            string query = "SELECT * FROM Users WHERE Name = '" + userInput + "'";
            using (SqlConnection connection = new SqlConnection("YourConnectionString"))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader["Name"]);
                }
            }
        }
    }
}
