using Messenger.Domain.Entities;
using Messenger.Domain.Interfaces.Repositories;
using Messenger.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace Messenger.Business.Services
{
    public class EmailService : BaseService<Email>, IEmailService
    {
        private readonly IBaseRepository<Email> _emailRepository;
        private readonly IConfiguration _configuration;

        public EmailService(IBaseRepository<Email> baseRepository, IConfiguration configuration) : base(baseRepository)
        {
            this._emailRepository = baseRepository;
            this._configuration = configuration;
        }

        public void SendEmails()
        {
            try
            {
                // Configurações do servidor SMTP
                string smtpServer = "seu_servidor_smtp";
                int smtpPort = 587;
                string username = "seu_email@example.com";
                string password = "sua_senha";

                // Crie uma mensagem de e-mail
                using (var mailMessage = new MailMessage())
                {
                    mailMessage.From = new MailAddress(username, "Seu Nome");
                    mailMessage.To.Add("destinatario@example.com");
                    mailMessage.Subject = "Assunto do e-mail";
                    mailMessage.Body = "Corpo do e-mail";
                    mailMessage.IsBodyHtml = true;

                    // Configure o cliente SMTP
                    using (var smtpClient = new SmtpClient(smtpServer, smtpPort))
                    {
                        smtpClient.EnableSsl = true;
                        smtpClient.UseDefaultCredentials = false;
                        smtpClient.Credentials = new NetworkCredential(username, password);

                        // Envie o e-mail
                        smtpClient.Send(mailMessage);
                    }
                }

                Console.WriteLine("E-mail enviado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao enviar o e-mail: {ex.Message}");
            }

        }
    }
}
