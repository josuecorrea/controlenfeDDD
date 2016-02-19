using AutoMapper;
using Arquitetura.DTO;
using Arquitetura.Dominio.Aggregates.UsuarioAgg;
using Arquitetura.Dominio.Aggregates.ConfiguracaoAgg;

namespace Arquitetura.Infraestrutura.Adapter
{
    public class AutomapperTypeAdapterFactory : ITypeAdapterFactory
    {
        #region Constructor

        /// <summary>
        /// Create a new Automapper type adapter factory
        /// </summary>
        public AutomapperTypeAdapterFactory()
        {
            // Mapeamentos
            Mapper.CreateMap<Usuario, UsuarioDTO>();
            Mapper.CreateMap<Usuario, UsuarioListDTO>();
            Mapper.CreateMap<ConfiguracaoServidorEmail, ConfiguracaoServidorEmailDTO>();
        }

        #endregion

        #region ITypeAdapterFactory Members

        public ITypeAdapter Create()
        {
            return new AutomapperTypeAdapter();
        }

        #endregion
    }
}
