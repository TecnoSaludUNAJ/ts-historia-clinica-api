using TP_Domain.Commands;


namespace TP_Application.Services
{
    public interface IAnalisisService
    {

    }

    public class AnalisisService : IAnalisisService
    {
        private readonly IGenericsRepository _repository;

        public AnalisisService(IGenericsRepository repository)
        {
            _repository = repository;
        }

    }
}
