using System;


namespace R5T.E0063
{
	public class Operations : IOperations
	{
		#region Infrastructure

	    public static IOperations Instance { get; } = new Operations();

	    private Operations()
	    {
        }

	    #endregion
	}
}