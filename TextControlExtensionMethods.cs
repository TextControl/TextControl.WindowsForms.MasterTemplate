using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TXTextControl;

namespace TextControlExtensionMethods
{
    // struct to store the paragraph style names for
    // all paragraphs
    public struct ParStyle
    {
        public Paragraph Paragraph;
        public string StyleName;
        
        public ParStyle(Paragraph paragraph, string styleName)
        {
            this.Paragraph = paragraph;
            this.StyleName = styleName;
        }
    }

    public static class TextControlExtensionMethods
    {
        // extension method to apply all paragraph styles
        // from a master template to an existing TextControl
        public static bool ApplyMasterTemplate(this TextControl textControl, string masterTemplate, StreamType streamType)
        {
            // list to keep all style names
            List<ParStyle> styles = new List<ParStyle>();

            using (ServerTextControl serverTextControl = new ServerTextControl())
            {
                serverTextControl.Create();

                // load the master template
                try {
                    serverTextControl.Load(masterTemplate, streamType);
                }
                catch {
                    return false;
                }

                // loop through all paragraphs to store the used
                // style names
                foreach (IFormattedText textPart in textControl.TextParts)
                {
                    foreach (Paragraph par in textPart.Paragraphs)
                    {
                        ParStyle style = new ParStyle(par, par.FormattingStyle);
                        styles.Add(style);
                    }
                }

                // loop through all paragraph styles and
                // replace the style, if the name already exist
                foreach (ParagraphStyle style in serverTextControl.ParagraphStyles)
                {
                    if (textControl.ParagraphStyles.GetItem(style.Name) != null)
                    {
                        textControl.ParagraphStyles.Remove(style.Name);

                        // create a new style and add it to TextControl
                        ParagraphStyle newStyle = new ParagraphStyle(style);
                        textControl.ParagraphStyles.Add(newStyle);
                    }
                }
            }

            // apply the stored style names to all paragraphs
            foreach (ParStyle par in styles)
            {
                par.Paragraph.FormattingStyle = par.StyleName;
            }

            return true;
        }
    }
}
