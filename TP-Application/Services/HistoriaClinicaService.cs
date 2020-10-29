using TP_Domain.Commands;
using TP_Domain.DTOs;
using TP_Domain.Entities;
using TP_Domain.Queries;

namespace TP_Application.Services
{
    public interface IHistoriaClinicaService
    {
        HistoriaClinicaResponseDto CreateHistoriaClinica(HistoriaClinicaDto historiaclinica);
        HistoriaClinicaResponseDto GetByPacienteId(int pacienteid);

    }

    public class HistoriaClinicaService : IHistoriaClinicaService
    {
        private readonly IGenericsRepository _repository;
        private readonly IHistoriaClinicaQueries _query;

        public HistoriaClinicaService(IGenericsRepository repository, IHistoriaClinicaQueries query)
        {
            _repository = repository;
            _query = query;
        }

        public HistoriaClinicaResponseDto CreateHistoriaClinica(HistoriaClinicaDto historiaclinica)
        {
            var entity = new HistoriaClinica
            {
                PacienteId = historiaclinica.PacienteId
            };
            _repository.Add<HistoriaClinica>(entity);

            return new HistoriaClinicaResponseDto
            {
                HistoriaClinicaId = entity.HistoriaClinicaId,
                PacienteId = entity.PacienteId
            };
        }

        public HistoriaClinicaResponseDto GetByPacienteId(int pacienteid)
        {
            return _query.GetByPacienteid(pacienteid);
        }
    }








}
