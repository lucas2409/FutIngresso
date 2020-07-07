using System;
using System.Collections.Generic;
using System.Text;

namespace FutIngressos
{
    class Usuario
    {
        public int CodigoUsuario { get; private set; }
        public int CadastroAtivo { get; private set; }
        public int TipoUsuario { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public string DicaSenha { get; private set; }
        
        public Usuario() { }
        public Usuario(int CodigoUsuario, int CadastroAtivo, int TipoUsuario, string Nome, string Email, string Senha, string DicaSenha)
        {
            this.CodigoUsuario = CodigoUsuario;
            this.CadastroAtivo = CadastroAtivo;
            this.TipoUsuario = TipoUsuario;
            this.Nome = Nome;
            this.Email = Email;
            this.Senha = Senha;
            this.DicaSenha = DicaSenha;
        }
        public string AlterarDados(int CodigoUsuario, int CadastroAtivo, int TipoUsuario, string Nome, 
            string Email, string Senha, string DicaSenha)
        {
            string ret = "";
            if (this.CodigoUsuario == CodigoUsuario)
            {
                this.CadastroAtivo = CadastroAtivo;
                this.TipoUsuario = TipoUsuario;
                this.Nome = Nome;
                this.Email = Email;
                this.Senha = Senha;
                this.DicaSenha = DicaSenha;
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
            if (v == true) {
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
            return "Dados Atualizados: " + 
                   "\r\n Codigo Usuario: " + this.CodigoUsuario +
                   "\r\n Nome: " + this.Nome +
                   "\r\n Email: " + this.Email +
                   "\r\n Senha: " + this.Senha +
                   "\r\n Dica: " + this.DicaSenha +
                   "\r\n Tipo Usuario: " + this.TipoUsuario +
                   "\r\n Cadastro Ativo: " + this.CadastroAtivo;
        }
    }
}
