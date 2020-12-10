using System;
using TP_Domain.Commands;
using TP_Domain.DTOs;
using TP_Domain.Entities;
using TP_Domain.Queries;

namespace TP_Application.Services
{
    public interface IRegistroService
    {
        Registro CreateRegistro(RegistroDTO registro);
    }

    public class RegistroService : IRegistroService
    {
        private readonly IGenericsRepository _repository;


        public RegistroService(IGenericsRepository repository)
        {
            _repository = repository;
            
        }

        public Registro CreateRegistro(RegistroDTO registro)
        {
            DateTime fechaconsulta = DateTime.Now;

            var entity = new Registro
            {
                Analisis = registro.Analisis,
                Diagnostico = registro.Diagnostico,
                EspecialistaId = registro.EspecialistaId,
                FechaRegistro = DateTime.Now,
                MotivoConsulta = registro.MotivoConsulta,
                ProximaRevision = registro.ProximaRevision,
                Receta = registro.Receta,
            };
            _repository.Add<Registro>(entity);
            // add HC
            var hc = new HistoriaClinica
            {
                PacienteId = registro.pacienteId,
                RegistroId = entity.RegistroId
            };
            _repository.Add<HistoriaClinica>(hc);
            return entity;
        }
    }
}
