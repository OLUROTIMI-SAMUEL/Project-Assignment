using MiskStartupSchool.DTO;

namespace MiskStartupSchool.Services
{
    public interface IWorkflowRepository
    {
        Task<WorkflowDto> GetWorkflow(string Id);
        Task<bool> UpdateWorkflow(WorkflowDto program, string Id);
    }
}
