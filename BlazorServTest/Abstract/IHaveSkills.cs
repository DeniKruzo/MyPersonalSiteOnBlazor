using BlazorServTest.Models.Domains;

namespace BlazorServTest.Abstract
{
    public interface IHaveSkills
    {
        List<HardSkills> GetSkills();
    }
}
