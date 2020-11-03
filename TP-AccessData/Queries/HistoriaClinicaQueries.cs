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

        public List<HistoriaClinicaResponseDto> Get(int pacienteid)
        {
            var db = new QueryFactory(connection, sqlKataCompiler);

            if (pacienteid != 0)
            {
                var query = db.Query("HistoriaClinica")
            .SelectRaw(@"
                HistoriaClinica.HistoriaClinicaId,
                HistoriaClinica.PacienteId,
                Receta.DescripcionReceta,
                Registro.MotivoConsulta,
                Analisis.DescripcionAnalisis,
                Registro.Diagnostico,
                Registro.ProximaRevision
                     ")
            .Join("Registro", "HistoriaClinica.HistoriaClinicaId", "Registro.HistoriaClinicaId", "=", "inner join")
            .Join("Receta", "Receta.RegistroId", "Registro.RegistroId", "=")
            .Join("Analisis", "Analisis.RegistroId", "Registro.RegistroId", "=")
            .Where("HistoriaClinica.PacienteId", "=", pacienteid);

                var result = query.Get<HistoriaClinicaResponseDto>();

                return result.ToList();
            }
            else {

                var query = db.Query("HistoriaClinica")
            .SelectRaw(@"
                HistoriaClinica.HistoriaClinicaId,
                HistoriaClinica.PacienteId,
                Receta.DescripcionReceta,
                Registro.MotivoConsulta,
                Analisis.DescripcionAnalisis,
                Registro.Diagnostico,
                Registro.ProximaRevision
                     ")
            .Join("Registro", "HistoriaClinica.HistoriaClinicaId", "Registro.HistoriaClinicaId", "=", "inner join")
            .Join("Receta", "Receta.RegistroId", "Registro.RegistroId", "=")
            .Join("Analisis", "Analisis.RegistroId", "Registro.RegistroId", "=");
             var result = query.Get<HistoriaClinicaResponseDto>();

                return result.ToList();
            }

        }
    }
}
