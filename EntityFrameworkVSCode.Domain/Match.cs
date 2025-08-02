namespace EntityFrameworkCoreVSCore.Domain;

public class Match : BaseDomainModel
{
    public int HomeTeamScore { get; set; }
    public int AwayTeamScore { get; set; }
    public decimal TicketPrice { get; set; }
    public DateTime MatchDate { get; set; }
    public int HomeTeamId { get; set; }
    public Team HomeTeam { get; set; }
    public int AwayTeamId { get; set; }
    public Team AwayTeam { get; set; }
}
