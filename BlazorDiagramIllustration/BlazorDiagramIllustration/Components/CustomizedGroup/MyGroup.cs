using Blazor.Diagrams.Core.Models;

namespace BlazorDiagramIllustration.Components.CustomizedGroup
{
    public class MyGroup : GroupModel
    {
        public MyGroup(IEnumerable<NodeModel> children, byte padding = 30, bool autoSize = true) : base(children, padding, autoSize)
        {
        }
    }
}
