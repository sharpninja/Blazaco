using Blazaco.Editor.Options;
using System;

namespace Blazaco.Editor
{
    public class EditorModel
    {
        public EditorModel() { }

        public EditorModel(EditorOptions options)
        {
            Options = options;
        }

        public EditorModel(EditorOptions options, EditorLayoutInfo layoutInfo)
        {
            Options = options;
            LayoutInfo = layoutInfo;
        }

        public string Id { get; set; } = $"Blazaco_{new Random().Next(0, 1000000).ToString()}";
        public EditorOptions Options { get; set; } = new EditorOptions();
        public EditorLayoutInfo LayoutInfo { get; set; } = new EditorLayoutInfo();
    }
}
