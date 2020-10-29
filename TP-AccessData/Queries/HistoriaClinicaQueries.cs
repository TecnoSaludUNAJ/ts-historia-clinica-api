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
                .SelectRaw(@"
                HistoriaClinica.HistoriaClinicaId,
                HistoriaClinica.PacienteId,
                Receta.DescripcionReceta,
                Registro.MotivoConsulta,
                Analisis.DescripcionAnalisis,
                Registro.Diagnostico,
                Registro.ProximaRevision
                     ")
                .Join("Registro","HistoriaClinica.HistoriaClinicaId","Registro.HistoriaClinicaId","=","inner join")
                .Join("Receta","Receta.RegistroId","Registro.RegistroId","=")
                .Join("Analisis","Analisis.RegistroId","Registro.RegistroId","=")
                .Where("HistoriaClinica.PacienteId","=",pacienteid)   
                .FirstOrDefault<HistoriaClinicaResponseDto>();


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
