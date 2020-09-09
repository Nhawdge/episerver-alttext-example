using Alloy.Models.Media;
using EPiServer.Shell;

namespace Alloy.Business.EditorDescriptors
{
    public class AltTextDescriptor : UIDescriptor<ImageFile>, IEditorDropBehavior
    {
        public EditorDropBehavior EditorDropBehaviour { get; set; }

        public AltTextDescriptor() : base()
        {
            EditorDropBehaviour = EditorDropBehavior.CreateContentBlock;
        }
    }
}
