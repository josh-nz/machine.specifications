using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Machine.Specifications.Specs.Assertions.String
{
	[Subject("ShouldNotBeEmpty() assertion")]
	public class when_ShouldNotBeEmpty_is_called_with_empty_string
	{
		static Exception _exception;
		static string _sourceString = string.Empty;

		Because of = () =>
			_exception = Catch.Exception(() => _sourceString.ShouldNotBeEmpty());

		It should_throw_specification_exception = () =>
			_exception.ShouldBeOfType<SpecificationException>();
	}

	[Subject("ShouldNotBeEmpty() assertion")]
	public class when_ShouldNotBeEmpty_is_called_with_non_empty_string
	{
		static Exception _exception;
		static string _sourceString = "somestring";

		Because of = () =>
			_exception = Catch.Exception(() => _sourceString.ShouldNotBeEmpty());

		It should_not_throw_specification_exception = () =>
			_exception.ShouldBeNull();
	}

	[Subject("ShouldNotBeEmpty() assertion")]
	public class when_ShouldNotBeEmpty_is_called_with_null_string
	{
		static Exception _exception;
		static string _sourceString = null;

		Because of = () =>
			_exception = Catch.Exception(() => _sourceString.ShouldNotBeEmpty());

		It should_throw_specification_exception = () =>
			_exception.ShouldBeOfType<SpecificationException>();
	}
}
