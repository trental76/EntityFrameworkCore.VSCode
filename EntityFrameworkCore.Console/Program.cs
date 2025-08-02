using EntityFrameworkVSCode.Data;
using Microsoft.EntityFrameworkCore;

using var context = new FootballLeageDbContext();
await GetAllTeamsAsync();
await SearchByName();

async Task GetAllTeamsAsync()
{
    var teams = await context.Teams.ToListAsync();
    teams.ForEach(team => Console.WriteLine(team.Name));
}

async Task SearchByName()
{
    Console.WriteLine("Enter desired teams:");
    var desiredTeams = Console.ReadLine();
    var teams = await context.Teams
        .Where(t => !string.IsNullOrWhiteSpace(t.Name) &&
            t.Name.Contains(desiredTeams)).ToListAsync();

    teams.ForEach(team => Console.WriteLine(team.Name));
}