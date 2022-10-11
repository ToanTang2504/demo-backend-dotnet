namespace SpaApp.Models
{
    public class Tab
    {
        public int Id { get; set; }

        public TabContent[]? TabContents { get; set; }
    }

    public class TabContent
    {
        public string? Name { get; set; }
        public string? Price { get; set; }
        public string? Description { get; set; }
    }
}
