namespace egolfWebApi.Models.Member;

public class Member
{
    public long Id { get; set; }
    public string? Picture { get; set; }
    public string? Code { get; set; }
    public string? Fname { get; set; }
    public string? Lname { get; set; }
    public string? PlayerType { get; set; }
    public string? Phone { get; set; }
    public string? Email { get; set; }
    public string? Gender { get; set; }
    public string? DateOfBirth { get; set; }
    public string? ActivationCode { get; set; }
}