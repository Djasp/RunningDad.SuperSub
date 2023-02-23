using RunningDad.SuperSub.Models;
using SQLite;

namespace RunningDad.SuperSub.Repositories;

public class PlayerRepository
{
    private readonly SQLiteConnection _connection;
    private string _statusMessage;

    public PlayerRepository()
    {
        _connection = new SQLiteConnection(Constants.DatabasePath, Constants.Flags);
        _connection.CreateTable<Player>();
    }

    public void Add(Player newPlayer)
    {
        try
        {
            var result = _connection.Insert(newPlayer);
            _statusMessage = $"{result} record(s) added [Name: {newPlayer.Name}]";
        }
        catch (Exception ex)
        {
            _statusMessage = $"Error: {ex.Message}";
        }
    }

    public List<Player> GetAll(int teamId)
    {
        try
        {
            return _connection.Table<Player>().Where(p=> p.TeamId == teamId).ToList();
        }
        catch (Exception ex)
        {
            _statusMessage = $"Error: {ex.Message}";
        }
        return null;
    }

    public Player Get(int id)
    {
        try
        {
            return _connection.Table<Player>().FirstOrDefault(t => t.Id == id);
        }
        catch (Exception ex)
        {
            _statusMessage = $"Error: {ex.Message}";
        }
        return null;
    }
    
    public void Update(Player Player)
    {
        try
        {
            var result = _connection.Update(Player);
            _statusMessage = $"{result} record(s) updated [Name: {Player.Name}]";
        }
        catch (Exception ex)
        {
            _statusMessage = $"Error: {ex.Message}";
        }
    }
    
    public void Delete(Player Player)
    {
        try
        {
            var result = _connection.Delete(Player);
            _statusMessage = $"{result} record(s) deleted [Name: {Player.Name}]";
        }
        catch (Exception ex)
        {
            _statusMessage = $"Error: {ex.Message}";
        }
    }
}