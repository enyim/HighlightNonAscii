using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Windows.Media;

using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;

namespace Enyim.Extensions.HighlightNonAscii
{
    [Export(typeof(EditorFormatDefinition))]
    [Name(NonAsciiHighlightFormatDefinition.TAG)]
    [UserVisible(true)]
    internal class NonAsciiHighlightFormatDefinition : MarkerFormatDefinition
    {
        public const string TAG = "MarkerFormatDefinition/" + nameof(NonAsciiHighlightFormatDefinition);

        public NonAsciiHighlightFormatDefinition()
        {
            ForegroundColor = Colors.Red;
            BackgroundColor = Colors.LightSalmon;
            DisplayName = "Highlight Non-Ascii";
            ZOrder = 100;
        }
    }
}
