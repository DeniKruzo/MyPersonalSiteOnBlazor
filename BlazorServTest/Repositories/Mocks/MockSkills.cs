using BlazorServTest.Abstract;
using BlazorServTest.Models.Domains;

namespace BlazorServTest.Repositories.Mocks
{
    public class MockSkills : IHaveSkills
    {
        public List<HardSkills> GetSkills()
        {
            return new List<HardSkills>()
            {
                new HardSkills()
                {
                    Name = "C#",
                    Since = new DateTime(2019,09,01),
                    CurrentLevel = "Junior"
                },
                new HardSkills()
                {
                    Name = "SQL",
                    Since = new DateTime(2020,09,01),
                    CurrentLevel = "Junior"
                },
            };
        }
    }
}
