using System;
using TP_Domain.Commands;
using TP_Domain.DTOs;
using TP_Domain.Entities;
using TP_Domain.Queries;

namespace TP_Application.Services
{
    public interface IRegistroService
    {
        RegistroDto CreateRegistro(RegistroDto registro);
    }

    public class RegistroService : IRegistroService
    {
        private readonly IGenericsRepository _repository;
        private readonly IRegistroQueries _query;

        public RegistroService(IGenericsRepository repository, IRegistroQueries query)
        {
            _repository = repository;
            _query = query;
        }

        public RegistroDto CreateRegistro(RegistroDto registro)
        {


            var entity = new Registro
            {
                MotivoConsulta = registro.MotivoConsulta,
                Diagnostico = registro.Diagnostico,
                ProximaRevision = registro.ProximaRevision,
                EspecialistaId = registro.EspecialistaId,
                HistoriaClinicaId = registro.HistoriaClinicaId,
                FechaRegistro = DateTime.Now
               
                
            };
            _repository.Add<Registro>(entity);

            return new RegistroDto
            {
                MotivoConsulta = entity.MotivoConsulta,
                Diagnostico = entity.Diagnostico,
                ProximaRevision = entity.ProximaRevision,
                EspecialistaId = entity.EspecialistaId,
                HistoriaClinicaId = entity.HistoriaClinicaId
            };
        }
    }
}
