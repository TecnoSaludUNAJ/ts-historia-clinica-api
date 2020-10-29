using TP_Domain.Commands;
using TP_Domain.DTOs;
using TP_Domain.Entities;

namespace TP_Application.Services
{
    public interface IAnalisisService
    {
        AnalisisDto CreateAnalisis(AnalisisDto analisis);
    }

    public class AnalisisService : IAnalisisService
    {
        private readonly IGenericsRepository _repository;

        public AnalisisService(IGenericsRepository repository)
        {
            _repository = repository;
        }

        public AnalisisDto CreateAnalisis(AnalisisDto analisis)
        {
            var entity = new Analisis
            {
                DescripcionAnalisis = analisis.DescripcionAnalisis,
                RegistroId = analisis.RegistroId

            };
            _repository.Add<Analisis>(entity);

            return new AnalisisDto
            {
                DescripcionAnalisis = entity.DescripcionAnalisis,
                RegistroId = entity.RegistroId
            };
        }
    }
}
