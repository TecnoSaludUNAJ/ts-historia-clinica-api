using TP_Domain.Commands;


namespace TP_Application.Services
{
    public interface IRecetaService
    {

    }

    public class RecetaService : IRecetaService
    {
        private readonly IGenericsRepository _repository;

        public RecetaService(IGenericsRepository repository)
        {
            _repository = repository;
        }

    }
}
