using System;
using System.Linq;
using System.Collections.Generic;

using Microsoft.VisualStudio.Text;
using Microsoft.VisualStudio.Text.Tagging;

namespace Enyim.Extensions.HighlightNonAscii
{
    internal class NonAsciiTagger : ITagger<NonAsciiHighlightTag>
    {
        public event EventHandler<SnapshotSpanEventArgs> TagsChanged;

        public IEnumerable<ITagSpan<NonAsciiHighlightTag>> GetTags(NormalizedSnapshotSpanCollection spans)
        {
            foreach (var span in spans)
            {
                for (var i = span.Start.Position; i < span.End.Position; i++)
                {
                    var c = span.Snapshot[i];
                    if (c > 127)
                    {
                        yield return new TagSpan<NonAsciiHighlightTag>(new SnapshotSpan(new SnapshotPoint(span.Snapshot, i), 1), new NonAsciiHighlightTag());
                    }
                }
            }
        }
    }
}
