using System;

using Microsoft.Extensions.Logging;

using R5T.T0132;


namespace R5T.F0043
{
	[FunctionalityMarker]
	public partial interface ILibraryOperator : IFunctionalityMarker
	{
		public (string libraryName, string unadjustedLibraryName) GetLibraryNames(
			string endeavorName,
			bool isPrivate,
			ILogger logger)
        {
			var unadjustedLibraryName = Instances.LibraryNameOperator.GetUnadjustedLibraryName(endeavorName);

			var libraryName = Instances.LibraryNameOperator.AdjustLibraryName_ForPrivacy(
				unadjustedLibraryName,
				isPrivate,
				logger);

			return (libraryName, unadjustedLibraryName);
		}

		public string GetLibraryName(
			string endeavorName,
			bool isPrivate,
			ILogger logger)
        {
			var (libraryName, _) = this.GetLibraryNames(
				endeavorName,
				isPrivate,
				logger);

			return libraryName;
        }

		public LibraryDescriptors GetDescriptors(
			string endeavorName,
			string endeavorDescription,
			bool isPrivate,
			ILogger logger)
        {
			var (libraryName, unadjustedLibraryName) = this.GetLibraryNames(
				endeavorName,
				isPrivate,
				logger);

			var libraryDescription = Instances.LibraryDescriptionOperator.GetLibraryDescription(endeavorDescription);

			var libraryDescriptors = new LibraryDescriptors
			{
				UnadjustedName = unadjustedLibraryName,
				Name = libraryName,
				Description = libraryDescription,
			};

			return libraryDescriptors;
		}
	}
}