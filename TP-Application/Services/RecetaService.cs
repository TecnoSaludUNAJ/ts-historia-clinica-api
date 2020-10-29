using TP_Domain.Commands;
using TP_Domain.DTOs;
using TP_Domain.Entities;

namespace TP_Application.Services
{
    public interface IRecetaService
    {
        RecetaDto CreateReceta(RecetaDto analisis);
    }

    public class RecetaService : IRecetaService
    {
        private readonly IGenericsRepository _repository;

        public RecetaService(IGenericsRepository repository)
        {
            _repository = repository;
        }

        public RecetaDto CreateReceta(RecetaDto analisis)
        {
            var entity = new Receta
            {
                DescripcionReceta = analisis.DescripcionReceta,
                RegistroId = analisis.RegistroId
            };
            _repository.Add<Receta>(entity);

            return new RecetaDto
            {
                DescripcionReceta = entity.DescripcionReceta,
                RegistroId = entity.RegistroId
            };
        }
    }
}
