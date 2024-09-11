

using System.Collections.Generic;
using BlazorTest.Data;

namespace BlazorTest.Data

{
	public class SchoolService
	{
		public List<School> Schools { get; } = new List<School>
		{
			new School { SchoolName = "UIC", Address = "Davao", SchoolCode = "ABC" },
			new School { SchoolName = "UIC", Address = "Davao", SchoolCode = "ABC" }
		};
	}
}
