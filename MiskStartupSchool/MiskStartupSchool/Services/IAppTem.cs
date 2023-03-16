using MiskStartupSchool.DTO;

namespace MiskStartupSchool.Services
{
    public interface IAppTem
    {
        Task<AppTemplateDto> GetTemplate(string Id);
        Task<bool> UpdateTemplate(AppTemplateDto program, string Id);
    }
}
