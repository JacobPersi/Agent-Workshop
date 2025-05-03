using Microsoft.AspNetCore.Components;

namespace Workshop.Models
{
    public class TabItem
    {
        public string Title { get; set; } = string.Empty;
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public bool IsActive { get; set; }
        public RenderFragment? Content { get; set; }
    }
}