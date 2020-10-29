using TP_Domain.DTOs;

namespace TP_Domain.Queries
{
    public interface IHistoriaClinicaQueries
    {
        HistoriaClinicaResponseDto GetByPacienteid(int pacienteid);
    }
}
