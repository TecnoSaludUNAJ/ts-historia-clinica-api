using SqlKata.Compilers;
using SqlKata.Execution;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using TP_Domain.DTOs;
using TP_Domain.Queries;

namespace TP_AccessData.Queries
{
    public class HistoriaClinicaQueries : IHistoriaClinicaQueries
    {
        private readonly IDbConnection connection;
        private readonly Compiler sqlKataCompiler;

        public HistoriaClinicaQueries(IDbConnection connection, Compiler sqlKataCompiler)
        {
            this.connection = connection;
            this.sqlKataCompiler = sqlKataCompiler;
        }

        public List<HistoriaClinicaResponseDto> GetByPacienteId(int pacienteid)
        {
            var db = new QueryFactory(connection, sqlKataCompiler);

            var query = db.Query("HistoriaClinica")
            .Join("Registros", "Registros.RegistroId", "HistoriaClinica.RegistroId")
            .Where("HistoriaClinica.PacienteId", "=", pacienteid);

            var result = query.Get<HistoriaClinicaResponseDto>();
            return result.ToList();         
 
        }
    }
}
