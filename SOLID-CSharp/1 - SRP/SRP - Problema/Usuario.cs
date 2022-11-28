using System;
using System.Data;
using System.Data.SqlClient;
//using System.Data.SqlClient;
using System.Net.Mail;

namespace SOLID_CSharp._1___SRP.SRP___Problema
{   //Principio da Responsabilidade unica
    class Usuario
    {
        // Propriedades do Usuario
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }

        public string AdicinarUsuario()
        {
            if (!Email.Contains("@"))
                return "Usuário com email inválido!";

            if (CPF.Length != 11)
                return "Usuário com CPF inválido";

            using (var conection = new SqlConnection())
            {
                var command = new SqlCommand();

                conection.ConnectionString = "StringConexão";
                command.Connection = conection;
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO USUARIO (NOME, EMAIL CPF, DATANASCIMENTO) VALUES (@nome, @email, @cpf, @dataNas))";

                command.Parameters.AddWithValue("nome", Nome);
                command.Parameters.AddWithValue("email", Email);
                command.Parameters.AddWithValue("cpf", CPF);
                command.Parameters.AddWithValue("dataNas", DataNascimento);

                conection.Open();
                command.ExecuteNonQuery();
            }

            var mail = new MailMessage("csharp@solid.com", Email);
            var client = new SmtpClient
            {
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.google.com"
            };

            mail.Subject = "Bem Vindo.";
            mail.Body = "Parabéns! Você está cadastrado.";
            client.Send(mail);

            return "Usuário cadastrado com sucesso!";
        }
        }

    }
}
