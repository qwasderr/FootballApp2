namespace FootballApp2.Models.JsonModels
{
    public class Rootobject
    {
        public Player player { get; set; }
    }

    public class Player
    {
        public string name { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string slug { get; set; }
        public string shortName { get; set; }
        public Team team { get; set; }
        public string position { get; set; }
        public string jerseyNumber { get; set; }
        public int height { get; set; }
        public string preferredFoot { get; set; }
        public int userCount { get; set; }
        public int id { get; set; }
        public Country3 country { get; set; }
        public int shirtNumber { get; set; }
        public int dateOfBirthTimestamp { get; set; }
        public int contractUntilTimestamp { get; set; }
        public int proposedMarketValue { get; set; }
        public Proposedmarketvalueraw proposedMarketValueRaw { get; set; }
    }

    public class Team
    {
        public string name { get; set; }
        public string slug { get; set; }
        public string shortName { get; set; }
        public string gender { get; set; }
        public Sport sport { get; set; }
        public Tournament tournament { get; set; }
        public Primaryuniquetournament primaryUniqueTournament { get; set; }
        public int userCount { get; set; }
        public string nameCode { get; set; }
        public bool disabled { get; set; }
        public bool national { get; set; }
        public int type { get; set; }
        public int id { get; set; }
        public Country2 country { get; set; }
        public Teamcolors teamColors { get; set; }
    }

    public class Sport
    {
        public string name { get; set; }
        public string slug { get; set; }
        public int id { get; set; }
    }

    public class Tournament
    {
        public string name { get; set; }
        public string slug { get; set; }
        public Category category { get; set; }
        public Uniquetournament uniqueTournament { get; set; }
        public int priority { get; set; }
        public int id { get; set; }
    }

    public class Category
    {
        public string name { get; set; }
        public string slug { get; set; }
        public Sport1 sport { get; set; }
        public int id { get; set; }
        public string flag { get; set; }
        public string alpha2 { get; set; }
    }

    public class Sport1
    {
        public string name { get; set; }
        public string slug { get; set; }
        public int id { get; set; }
    }

    public class Uniquetournament
    {
        public string name { get; set; }
        public string slug { get; set; }
        public string primaryColorHex { get; set; }
        public string secondaryColorHex { get; set; }
        public Category1 category { get; set; }
        public int userCount { get; set; }
        public int id { get; set; }
        public Country country { get; set; }
        public bool displayInverseHomeAwayTeams { get; set; }
    }

    public class Category1
    {
        public string name { get; set; }
        public string slug { get; set; }
        public Sport2 sport { get; set; }
        public int id { get; set; }
        public string flag { get; set; }
        public string alpha2 { get; set; }
    }

    public class Sport2
    {
        public string name { get; set; }
        public string slug { get; set; }
        public int id { get; set; }
    }

    public class Country
    {
    }

    public class Primaryuniquetournament
    {
        public string name { get; set; }
        public string slug { get; set; }
        public string primaryColorHex { get; set; }
        public string secondaryColorHex { get; set; }
        public Category2 category { get; set; }
        public int userCount { get; set; }
        public int id { get; set; }
        public Country1 country { get; set; }
        public bool displayInverseHomeAwayTeams { get; set; }
    }

    public class Category2
    {
        public string name { get; set; }
        public string slug { get; set; }
        public Sport3 sport { get; set; }
        public int id { get; set; }
        public string flag { get; set; }
        public string alpha2 { get; set; }
    }

    public class Sport3
    {
        public string name { get; set; }
        public string slug { get; set; }
        public int id { get; set; }
    }

    public class Country1
    {
    }

    public class Country2
    {
        public string alpha2 { get; set; }
        public string name { get; set; }
    }

    public class Teamcolors
    {
        public string primary { get; set; }
        public string secondary { get; set; }
        public string text { get; set; }
    }

    public class Country3
    {
        public string alpha2 { get; set; }
        public string name { get; set; }
    }

    public class Proposedmarketvalueraw
    {
        public int value { get; set; }
        public string currency { get; set; }
    }
}