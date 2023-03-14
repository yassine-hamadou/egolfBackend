namespace egolfWebApi.Models.GameType;

public class GameType
{
    public long Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; } = "No description";
}