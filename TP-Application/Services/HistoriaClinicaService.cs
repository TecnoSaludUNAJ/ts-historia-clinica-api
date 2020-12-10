using System.Collections.Generic;
using TP_Domain.Commands;
using TP_Domain.DTOs;
using TP_Domain.Entities;
using TP_Domain.Queries;

namespace TP_Application.Services
{
    public interface IHistoriaClinicaService
    {
       List<HistoriaClinicaResponseDto>  GetHistoriaClinica(int pacienteid);

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

        public List<HistoriaClinicaResponseDto> GetHistoriaClinica(int pacienteid)
        {
            return _query.GetByPacienteId(pacienteid);
        }
    }








}
