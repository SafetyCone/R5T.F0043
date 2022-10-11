using System;


namespace R5T.F0043
{
	public class LibraryDescriptionOperator : ILibraryDescriptionOperator
	{
		#region Infrastructure

	    public static ILibraryDescriptionOperator Instance { get; } = new LibraryDescriptionOperator();

	    private LibraryDescriptionOperator()
	    {
        }

	    #endregion
	}
}