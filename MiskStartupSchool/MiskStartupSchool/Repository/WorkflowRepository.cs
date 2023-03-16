using Microsoft.EntityFrameworkCore;
using MiskStartupSchool.Context;
using MiskStartupSchool.DTO;
using MiskStartupSchool.Entities;
using MiskStartupSchool.Services;

namespace MiskStartupSchool.Repository
{
    public class WorkflowRepository : IWorkflowRepository
    {
        private readonly ApplicationDbContext _context;

        public WorkflowRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        
        public async Task<WorkflowDto> GetWorkflow(string Id)
        {
            var data = await _context.application.FirstOrDefaultAsync(x => x.ApplicationId == Id);
            if (data == null) return null;

            return new WorkflowDto()
            {
                stages = data.stages
            };
        }
        
        public async Task<bool> UpdateWorkflow(WorkflowDto program, string Id)
        {
            var data = await _context.application.FirstOrDefaultAsync(x => x.ApplicationId == Id);

            if (data == null) return false;

            data.stages = program.stages;

            _context.Update(data);
            return _context.SaveChanges() > 0;
        }
    }
}
