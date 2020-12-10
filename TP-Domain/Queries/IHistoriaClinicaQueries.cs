using System.Collections.Generic;
using TP_Domain.DTOs;

namespace TP_Domain.Queries
{
    public interface IHistoriaClinicaQueries
    {
      List<HistoriaClinicaResponseDto> GetByPacienteId(int pacienteid);
    }
}
