using System.Text;

namespace HtmlGeneration.XmlToHtmlTree
{
    /// <summary>
    /// A class containing options for HTML serialization
    /// </summary>
    public class XmlToHtmlSerializationSettings
    {
        /// <summary>
        /// Attributes to set on any generated <detail> elements. Default ""
        /// </summary>
        public string DetailAttributes { get; set; } = "";
        /// <summary>
        /// Attributes to set on any generated <summary> elements. Default ""
        /// </summary>
        public string SummaryAttributes { get; set; } = "";
        /// <summary>
        /// Attributes to set on any generated <ul> elements. Default ""
        /// </summary>
        public string UlAttributes { get; set; } = "";
        /// <summary>
        /// Attributes to set on any generated <li> elements. Default ""
        /// </summary>
        public string LiAttributes { get; set; } = "";
        /// <summary>
        /// Whether to line-break after an element. Default false
        /// </summary>
        public bool LineBreak { get; set; } = false;
        /// <summary>
        /// Whether to indent the html code. Default false
        /// </summary>
        public bool Indent { get; set; } = false;
        /// <summary>
        /// The character used to indent. Default '\t'
        /// </summary>
        public char IndentCharacter { get; set; } = '\t';
        /// <summary>
        /// Encoding to encode the generated HTML. Default UTF-8
        /// </summary>
        public Encoding Encoding { get; set; } = Encoding.UTF8;
    }
}