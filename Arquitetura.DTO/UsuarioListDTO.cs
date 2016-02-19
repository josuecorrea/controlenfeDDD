using Arquitetura.Dominio.Aggregates.Enums;

namespace Arquitetura.DTO
{
    public class UsuarioListDTO
    {
        public int Id { get; set; }

        public string NomeUsuario { get; set; }

        public string Email { get; set; }
        
        public string Nome { get; set; }

        public string Cpf { get; set; }

        public bool Ativo { get; set; }
    }
}
