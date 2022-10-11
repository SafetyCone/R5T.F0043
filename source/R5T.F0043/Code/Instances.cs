using System;

using R5T.F0044;


namespace R5T.F0043
{
    public static class Instances
    {
        public static ILibraryDescriptionOperator LibraryDescriptionOperator { get; } = F0043.LibraryDescriptionOperator.Instance;
        public static ILibraryNameOperator LibraryNameOperator { get; } = F0043.LibraryNameOperator.Instance;
        public static ILibraryOperator LibraryOperator { get; } = F0043.LibraryOperator.Instance;
		public static INameOperator NameOperator { get; } = F0044.NameOperator.Instance;
    }
}