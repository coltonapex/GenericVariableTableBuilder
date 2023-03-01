﻿using System;
using System.Text;
using GenericParameterTableBuilder.GenericParameterTableBuilder

public class GenericParameterTableBuilderTests
{
	[Fact]
	public SingleColumnTableBuildsWhenTypeIsBool()
	{
		List<bool> values = new List<bool>();
		StringBuilder goal = new StringBuilder();

		for(int x = 0; x < 5; x++)
		{
			values.Add(true);
			values.Add(false);
		}

		goal.Append("DECLARE @@Name TABLE (Column BIT);");
        goal.Append("INSERT INTO @@Name TABLE VALUES ;");

		foreach(var value in values)
		{
			goalString.Append($$"({value}),");
		}

		string.Remove(goal.Length - 1, 1);
		string.Append(";");

		var test = BuildGenericParameterTable("Name", "Column", values);

		Assert.Equal(goal.ToString(), test);
    }
}
