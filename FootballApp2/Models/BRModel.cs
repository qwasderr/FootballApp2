namespace FootballApp2.Models
{
    public class BRModel
    {
        public BRModel()
        {
            Blob = new BlobModel();
        }
        public string? Status { get; set; }
        public bool Error { get; set; }
        public BlobModel Blob { get; set; }
    }
}
