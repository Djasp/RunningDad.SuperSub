using RunningDad.SuperSub.Models;
using SQLite;

namespace RunningDad.SuperSub.Repositories;

public class TeamRepository
{
    private readonly SQLiteConnection _connection;
    private string _statusMessage;

    public TeamRepository()
    {
        _connection = new SQLiteConnection(Constants.DatabasePath, Constants.Flags);
        _connection.CreateTable<Team>();
    }

    public void Add(Team newTeam)
    {
        try
        {
            var result = _connection.Insert(newTeam);
            _statusMessage = $"{result} record(s) added [Name: {newTeam.Name}]";
        }
        catch (Exception ex)
        {
            _statusMessage = $"Error: {ex.Message}";
        }
    }

    public List<Team> GetAll()
    {
        try
        {
            return _connection.Table<Team>().ToList();
        }
        catch (Exception ex)
        {
            _statusMessage = $"Error: {ex.Message}";
        }
        return null;
    }

    public Team Get(int id)
    {
        try
        {
            return _connection.Table<Team>().FirstOrDefault(t => t.Id == id);
        }
        catch (Exception ex)
        {
            _statusMessage = $"Error: {ex.Message}";
        }
        return null;
    }
    
    public void Update(Team team)
    {
        try
        {
            var result = _connection.Update(team);
            _statusMessage = $"{result} record(s) updated [Name: {team.Name}]";
        }
        catch (Exception ex)
        {
            _statusMessage = $"Error: {ex.Message}";
        }
    }
    
    public void Delete(Team team)
    {
        try
        {
            var result = _connection.Delete(team);
            _statusMessage = $"{result} record(s) deleted [Name: {team.Name}]";
        }
        catch (Exception ex)
        {
            _statusMessage = $"Error: {ex.Message}";
        }
    }
}