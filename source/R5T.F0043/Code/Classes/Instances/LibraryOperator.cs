using System;


namespace R5T.F0043
{
	public class LibraryOperator : ILibraryOperator
	{
		#region Infrastructure

	    public static ILibraryOperator Instance { get; } = new LibraryOperator();

	    private LibraryOperator()
	    {
        }

	    #endregion
	}
}