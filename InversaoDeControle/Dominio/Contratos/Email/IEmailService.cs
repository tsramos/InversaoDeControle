using System;
using System.Collections.Generic;
using System.Text;

namespace InversaoDeControle.Dominio.Contratos.Email
{
    internal interface IEmailService
    {
        void EnviaEmailBoasVindas(string de, string para, string corpo);
    }
}
