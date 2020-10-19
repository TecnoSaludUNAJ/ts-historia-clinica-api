using TP_Domain.Commands;


namespace TP_Application.Services
{
    public interface IRegistroService
    {
        
    }

    public class RegistroService : IRegistroService
    {
        private readonly IGenericsRepository _repository;

        public RegistroService(IGenericsRepository repository)
        {
            _repository = repository;
        }

    }
}
