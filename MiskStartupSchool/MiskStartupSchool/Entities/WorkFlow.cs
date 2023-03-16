namespace MiskStartupSchool.Entities
{
    public class WorkFlow : ProgramTemplate
    {
        public ICollection<Stage>? stages { get; set; }

    }
}
