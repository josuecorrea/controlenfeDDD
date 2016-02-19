using System.Data.Entity.ModelConfiguration;
using Arquitetura.Dominio.Aggregates.UsuarioAgg;

namespace Arquitetura.Infraestrutura.UnitOfWork.Mapping
{
    class UsuarioEntityConfiguration : EntityTypeConfiguration<Usuario>
    {
        public UsuarioEntityConfiguration()
        {
            // Configurando propriedades e chaves
            this.HasKey(c => c.Id);

            this.Property(c => c.Id)
                .HasColumnName("ID_CUSU")
                .IsRequired();

            this.Property(c => c.NomeUsuario)
                .HasColumnName("USU_CUSU")
                .IsRequired()
                .HasMaxLength(50);

            this.Property(c => c.Email)
                .HasColumnName("EMAIL_CUSU")
                .IsRequired()
                .HasMaxLength(320);

            this.Property(c => c.Senha)
                .HasColumnName("SENHA_CUSU")
                .IsRequired();

            this.Property(c => c.Nome)
                .HasColumnName("NOME_CUSU")
                .IsRequired()
                .HasMaxLength(100);

            this.Property(c => c.Cpf)
                .HasColumnName("CPF_CUSU")
                .HasMaxLength(18);

            this.Property(c => c.Endereco)
                .HasColumnName("ENDERECO_CUSU")
                .HasMaxLength(50);

            this.Property(c => c.Complemento)
                .HasColumnName("ENDCOMP_CUSU")
                .HasMaxLength(50);

            this.Property(c => c.Numero)
                .HasColumnName("ENDNUMERO_CUSU")
                .HasMaxLength(20);

            this.Property(c => c.Bairro)
                .HasColumnName("ENDBAIRRO_CUSU")
                .HasMaxLength(50);

            this.Property(c => c.Cidade)
                .HasColumnName("ENDCIDADE_CUSU")
                .HasMaxLength(100);

            this.Property(c => c.Estado)
                .HasColumnName("ESTADO_CUSU");

            this.Property(c => c.Cep)
                .HasColumnName("CEP")
                .HasMaxLength(18);

            this.Property(c => c.Telefone)
                .HasColumnName("FONE_CUSU")
                .HasMaxLength(15);

            this.Property(c => c.Celular)
                .HasColumnName("CEL_CUSU")
                .HasMaxLength(15);

            this.Property(c => c.Newsletter)
                .HasColumnName("NEWSLETTER_CUSU");

            this.Property(c => c.Sexo)
                .HasColumnName("SEXO_CUSU")
                .IsRequired();

            this.Property(c => c.Ativo)
                .HasColumnName("ATIVO_CUSU");
            
            //Configurando a Tabela
            this.ToTable("cadusu");
        }
    }
}
