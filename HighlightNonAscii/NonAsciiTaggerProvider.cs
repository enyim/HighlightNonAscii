using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.Composition;

using Microsoft.VisualStudio.Text;
using Microsoft.VisualStudio.Text.Editor;
using Microsoft.VisualStudio.Text.Tagging;
using Microsoft.VisualStudio.Utilities;

namespace Enyim.Extensions.HighlightNonAscii
{
    [Export(typeof(IViewTaggerProvider))]
    [ContentType("text")]
    [ContentType("code")]
    [TagType(typeof(TextMarkerTag))]
    [TextViewRole(PredefinedTextViewRoles.Document)]
    internal class NonAsciiTaggerProvider : IViewTaggerProvider
    {
        public ITagger<T> CreateTagger<T>(ITextView textView, ITextBuffer buffer) where T : ITag
        {
            if (textView.TextBuffer != buffer) return null;

            return buffer.Properties.GetOrCreateSingletonProperty(() => new NonAsciiTagger()) as ITagger<T>;
        }
    }
}
