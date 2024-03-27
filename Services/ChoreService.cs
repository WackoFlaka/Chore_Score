
namespace Chore_Score.Services;

public class ChoreService
{
    private readonly ChoreRepository _repository;

    public ChoreService(ChoreRepository repository)
    {
        _repository = repository;
    }
    public List<Chore> GetChores()
    {
        List<Chore> chores = _repository.GetChores();
        return chores;
    }

    public Chore CreateChore(Chore data)
    {
        Chore chore = _repository.CreateChore(data);
        return chore;
    }
}