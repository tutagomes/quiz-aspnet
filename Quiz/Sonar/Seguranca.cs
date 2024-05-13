using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace Quiz.Sonar
{
    public class Seguranca
    {
        // 1. Injeção de SQL
        public void GetUserById(string userId)
        {
            var query = "SELECT * FROM Users WHERE UserId = '" + userId + "';";
            // Código que executa a consulta
        }

        // 2. Uso de Criptografia Fraca
        public string EncryptData(string data)
        {
            using (var md5 = MD5.Create())
            {
                var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(data));
                return Convert.ToBase64String(hash);
            }
        }

        // 3. Dados Sensíveis em Logs
        public void Login(string username, string password)
        {
            Console.WriteLine("Login attempt with username: " + username + " and password: " + password);
            // Código de autenticação
        }

        // 4. Falta de Validação de Entrada
        public void CreateUser(string username, string email)
        {
            var user = new User { Username = username, Email = email };
            // Código para salvar o usuário
        }

        // 5. Exposição de Informações Sensíveis
        public void HandleError(Exception ex)
        {
            Console.WriteLine("Erro: " + ex.Message);
            Console.WriteLine("Stack Trace: " + ex.StackTrace);
        }

        // 26. Armazenamento de Senhas em Texto Plano
        public void StorePassword(string password)
        {
            var query = "INSERT INTO Users (Password) VALUES ('" + password + "')";
            // Código para executar a consulta
        }

        // 27. Falta de Controle de Acesso Adequado
        public void RestrictedAction()
        {
            // Código sem verificação de acesso
        }

        // 28. Cross-Site Scripting (XSS)
        public void RenderUserInput(string userInput)
        {
            Console.WriteLine("<div>" + userInput + "</div>");
        }

        // 29. Falta de Proteção Contra CSRF
        public void ProcessForm(string data)
        {
            // Código de processamento do formulário sem proteção CSRF
        }

        // 30. Falta de Auditoria de Segurança
        public void PerformAction()
        {
            // Código sem logs de auditoria
        }
    }
}