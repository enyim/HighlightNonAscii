using System;
using System.Linq;
using System.Collections.Generic;

using Microsoft.VisualStudio.Text.Tagging;

namespace Enyim.Extensions.HighlightNonAscii
{
    internal class NonAsciiHighlightTag : TextMarkerTag
    {
        public NonAsciiHighlightTag() : base(NonAsciiHighlightFormatDefinition.TAG)
        {
        }
    }
}
