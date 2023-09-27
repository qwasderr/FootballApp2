namespace FootballApp2.Models
{
    public class Pagination
    {
        public int skip { get; set; }
        public int limit { get; set; }
        public int total { get; set; }

        public string nextLink { get; set; }
    }
    public class PaginationTeam : Pagination
    {
        public List<Team> team { get; set; }
    }
}
