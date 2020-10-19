using SqlKata.Compilers;
using SqlKata.Execution;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
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

        public HistoriaClinicaResponseDto GetByPacienteid(int pacienteid)
        {
            var db = new QueryFactory(connection, sqlKataCompiler);

            var hhcc = db.Query("HistoriaClinica")
                .SelectRaw("*")
                .Where("PacienteId", "=", pacienteid).FirstOrDefault<HistoriaClinicaResponseDto>();

            if (hhcc != null)
            {
                return hhcc;
            }
            else
            {
                return null;
            }

        }
    }
}
