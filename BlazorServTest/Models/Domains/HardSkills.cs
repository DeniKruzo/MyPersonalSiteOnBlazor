namespace BlazorServTest.Models.Domains
{
    public class HardSkills
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = "Empty Name";

        public DateTime Since { get; set; } = DateTime.Now;

        public string CurrentLevel { get; set; } = "Beginner";
    }
}
