using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace FutIngressos
{
    class Jogos
    {
        // atributos
        public int CodigoJogo { get; private set; }
        public int Disponivel { get; private set; }
        public int IngressosMandante { get; private set; }
        public int IngressosVisitante { get; private set; }
        public double ValorMandante { get; private set; }
        public double ValorVisitante { get; private set; }
        public DateTime Data { get; private set; }
        public string Descricao { get; private set; }
        public string LocalEstadio { get; private set; }
        public string TimeMandante { get; private set; }
        public string TimeVisitante { get; private set; }
        
        // construtores
        public Jogos()
        {

        }
        public Jogos(int CodigoJogo, int Disponivel, int IngressosMandante, int IngressosVisitante, double ValorMandante, double ValorVisitante,
            DateTime Data, string Descricao, string LocalEstadio, string TimeMandante, string TimeVisitante)
        {
            this.CodigoJogo = CodigoJogo;
            this.Data = Data;
            this.Descricao = Descricao;
            this.LocalEstadio = LocalEstadio;
            this.TimeMandante = TimeMandante;
            this.TimeVisitante = TimeVisitante;
            this.Disponivel = Disponivel;
            this.IngressosMandante = IngressosMandante;
            this.IngressosVisitante = IngressosVisitante;
            this.ValorMandante = ValorMandante;
            this.ValorVisitante = ValorVisitante;
        }

        public string AlterarDados(int CodigoJogo, int Disponivel, int IngressosMandante, int IngressosVisitante, double ValorMandante, double ValorVisitante,
            DateTime Data, string Descricao, string LocalEstadio, string TimeMandante, string TimeVisitante)
        {
            string ret = "";
            if (this.CodigoJogo == CodigoJogo)
            {
                this.Data = Data;
                this.Descricao = Descricao;
                this.LocalEstadio = LocalEstadio;
                this.TimeMandante = TimeMandante;
                this.TimeVisitante = TimeVisitante;
                this.Disponivel = Disponivel;
                this.IngressosMandante = IngressosMandante;
                this.IngressosVisitante = IngressosVisitante;
                this.ValorMandante = ValorMandante;
                this.ValorVisitante = ValorVisitante;
                ret = ConfirmaAlteracao(true);
            }
            else
            {
                ret = ConfirmaAlteracao(false);
            }
            return ret;
        }
        public string ConfirmaAlteracao(bool v)
        {
            string msg;
            if (v == true)
            {
                msg = "Alteração efetuada";
            }
            else
            {
                msg = "Alteração Não efetuada, valide os parâmetros";
            }
            return msg;
        }

        public override string ToString()
        {
            return "Codigo: " + this.CodigoJogo +
            "\r\n Data: " + this.Data +
            "\r\n Descricao: " + this.Descricao +
            "\r\n Local: " + this.LocalEstadio +
            "\r\n Mandante: " + this.TimeMandante +
            "\r\n Visitante: " + this.TimeVisitante +
            "\r\n Disponivel: " + this.Disponivel +
            "\r\n Ingressos Mandante: " + this.IngressosMandante +
            "\r\n Ingressos Visitante: " + this.IngressosVisitante +
            "\r\n Valor Mandante: " + this.ValorMandante +
            "\r\n Valor Visitante: " + this.ValorVisitante;
        }
    }
}
