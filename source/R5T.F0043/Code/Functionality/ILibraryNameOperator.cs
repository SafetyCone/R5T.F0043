using System;

using Microsoft.Extensions.Logging;

using R5T.T0132;


namespace R5T.F0043
{
	[FunctionalityMarker]
	public partial interface ILibraryNameOperator : IFunctionalityMarker
	{
		public string AdjustLibraryName_ForPrivacy(
			string unadjustedLibraryName,
			bool isPrivate)
		{
			var libraryName = Instances.NameOperator.AdjustNameForPrivacy(
				unadjustedLibraryName,
				isPrivate);

			return libraryName;
		}

		public string AdjustLibraryName_ForPrivacy(
			string unadjustedLibraryName,
			bool isPrivate,
			ILogger logger)
		{
			logger.LogInformation($"Unadjusted library name: '{unadjustedLibraryName}'.");

			logger.LogInformation($"Adjusting library name for privacy (is private: {isPrivate})...");

			var libraryName = this.AdjustLibraryName_ForPrivacy(
				unadjustedLibraryName,
				isPrivate);

			logger.LogInformation($"Adjusted library name for privacy. Library name: '{libraryName}'.");

			return libraryName;
		}

		public string GetUnadjustedLibraryName(string endeavorName)
		{
			// Unadjusted library name is just the script name.
			var output = endeavorName;
			return output;
		}
	}
}