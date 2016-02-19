
using Arquitetura.Dominio.Aggregates.Base;
using Arquitetura.Dominio.Aggregates.Enums;
using System;

namespace Arquitetura.Dominio.Aggregates.UsuarioAgg
{
    public static class UsuarioFactory
    {
        public static Usuario CreateUsuario(
            string nomeUsuario,
            string email,
            string senha,
            string nome,
            string cpf,
            string endereco,
            string complemento,
            string numero,
            string bairro,
            string cidade,
            eEstado? estado,
            string cep,
            string telefone,
            string celular,
            eSexo? sexo,
            bool newsletter,
            bool ativo)
        {
            var usuario = new Usuario();

            if (nomeUsuario != null)
            {
                usuario.NomeUsuario = nomeUsuario.Trim();
            }

            if (email != null)
            {
                usuario.Email = email.Trim();
            }

            usuario.Senha = senha;

            if (nome != null)
            {
                usuario.Nome = nome.Trim();
            }

            usuario.Cpf = cpf;
            usuario.Endereco = endereco;
            usuario.Complemento = complemento;
            usuario.Numero = numero;
            usuario.Bairro = bairro;
            usuario.Cidade = cidade;
            usuario.Estado = estado;
            usuario.Cep = cep;
            usuario.Telefone = telefone;
            usuario.Celular = celular;
            usuario.Sexo = sexo;
            usuario.Newsletter = newsletter;
            usuario.Ativo = ativo;

            return usuario;
        }

        public static TokenSenha CreateTokenSenha(int usuarioId)
        {
            var tokenSenha = new TokenSenha();
            tokenSenha.UsuarioId = usuarioId;
            tokenSenha.GerarToken();

            return tokenSenha;
        }
    }
}
