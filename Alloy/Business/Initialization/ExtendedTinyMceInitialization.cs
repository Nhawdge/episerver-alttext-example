using EPiServer.Cms.TinyMce.Core;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.ServiceLocation;

namespace Alloy.Business.Initialization
{
    [ModuleDependency(typeof(TinyMceInitialization))]
    public class ExtendedTinyMceInitialization : IConfigurableModule
    {
        public void Initialize(InitializationEngine context)
        {
        }

        public void Uninitialize(InitializationEngine context)
        {
        }

        public void ConfigureContainer(ServiceConfigurationContext context)
        {
            context.Services.Configure<TinyMceConfiguration>(config =>
            {

                var defaultConfig = config.Default()
                       .Menubar("file edit insert view table tools help")
                       .AddPlugin("epi-link epi-image-editor epi-dnd-processor epi-personalized-content print preview searchreplace autolink directionality visualblocks visualchars fullscreen image link media codesample table charmap hr pagebreak nonbreaking anchor toc insertdatetime lists textcolor wordcount imagetools help code")
                       .ContentCss("/static/apta/dist/css/editor.css")
                       .AddSetting("extended_valid_elements", "img[class|src|border=0|alt= |title|align|onmouseover|onmouseout|name], i[*], span[*], q[*]")
                       .Toolbar("epi-link | epi-image-editor | epi-personalized-content | cut copy paste | fullscreen", "styleselect  formatselect | bold italic superscript subscript blockquote | link unlink | alignleft aligncenter alignright alignjustify  | numlist bullist outdent indent  | removeformat", "table | code")
                       .BlockFormats("Paragraph=p;Heading 1=h1;Heading 2=h2;Heading 3=h3;Heading 4=h4;Heading 5=h5;Heading 6=h6;Preformatted=pre;Div=div");

            });
        }
    }
}
