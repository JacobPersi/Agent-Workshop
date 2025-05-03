using Workshop.Models;
using Workshop.Models.Abstract;
using Workshop.Models.Nodes;

using Point = Blazor.Diagrams.Core.Geometry.Point;

namespace Workshop.Services;

public class WorkflowService
{
    public WorkflowService()
    {
    }

    public Workflow LoadDefault()
    {
        return new Workflow()
        {
            Nodes = new List<Node>()
            {
                new LanguageNode() {
                    Title = "NODE 1",
                    Position = new Point(800, 400)
                }
            }
        };
    }
}
