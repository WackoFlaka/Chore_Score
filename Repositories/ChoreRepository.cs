namespace Chore_Score.Repositories;

public class ChoreRepository
{
    private readonly IDbConnection _db;

    public ChoreRepository(IDbConnection db)
    {
        _db = db;
    }

    public List<Chore> GetChores()
    {
        string sql = "SELECT * FROM chores";
        List<Chore> chores = _db.Query<Chore>(sql).ToList();
        return chores;
    }

    internal Chore CreateChore(Chore data)
    {
        string sql = @"
        INSERT INTO chores(name, description) VALUES(@name, @description);
        
        SELECT * FROM chores WHERE id = LAST_INSERT_ID();
        ";

        Chore chore = _db.Query<Chore>(sql, data).FirstOrDefault();
        return chore;
    }
}