using Blazor.Diagrams.Core;
using Workshop.Models;

namespace Workshop.Services;

public class DiagramService
{
    public DiagramService()
    {
    }

    public void LoadWorkflow(Diagram diagram, Workflow workflow)
    {
        if (diagram == null || workflow == null)
            throw new ArgumentNullException();

        foreach (var node in workflow.Nodes)
        {
            diagram.Nodes.Add(node);
        }
    }
}
