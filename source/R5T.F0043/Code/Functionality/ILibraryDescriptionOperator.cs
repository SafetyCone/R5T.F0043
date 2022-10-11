using System;

using R5T.T0132;


namespace R5T.F0043
{
	[FunctionalityMarker]
	public partial interface ILibraryDescriptionOperator : IFunctionalityMarker
	{
		public string GetLibraryDescription(string endeavorDescription)
		{
			// The library description is just the endeavor description.
			var libraryDescription = endeavorDescription;
			return libraryDescription;
		}
	}
}