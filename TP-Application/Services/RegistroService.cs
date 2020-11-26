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


        public RegistroService(IGenericsRepository repository)
        {
            _repository = repository;
            
        }

        public RegistroDto CreateRegistro(RegistroDto registro)
        {
            DateTime fechaconsulta = DateTime.Now;

            var entity = new Registro
            {
                MotivoConsulta = registro.MotivoConsulta,
                Diagnostico = registro.Diagnostico,
                ProximaRevision = registro.ProximaRevision,
                EspecialistaId = registro.EspecialistaId,
                HistoriaClinicaId = registro.HistoriaClinicaId,
                FechaRegistro = fechaconsulta


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
