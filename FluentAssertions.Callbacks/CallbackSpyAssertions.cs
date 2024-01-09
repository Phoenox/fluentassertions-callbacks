namespace FluentAssertions.Callbacks;

using System.Text;
using Execution;
using Primitives;

public class CallbackSpyAssertions
		: ReferenceTypeAssertions<CallbackSpy, CallbackSpyAssertions>
{
	public CallbackSpyAssertions(CallbackSpy spy)
			: base(spy)
	{
	}
	
	protected override string Identifier => "callbackSpy";
	
	public AndConstraint<CallbackSpyAssertions> HaveBeenCalled(
			string because = "", params object[] becauseArgs)
	{
		Execute.Assertion
				.BecauseOf(because, becauseArgs)
				.ForCondition(Subject.InvocationCount > 0)
				.FailWith("Expected callback to have been invoked, but it was not.");
		return new AndConstraint<CallbackSpyAssertions>(this);
	}
}

public class CallbackSpyAssertions<T>
		: ReferenceTypeAssertions<CallbackSpy<T>, CallbackSpyAssertions<T>>
{
	public CallbackSpyAssertions(CallbackSpy<T> spy)
		: base(spy)
	{
	}
	
	protected override string Identifier => "callbackSpy";
	
	public AndConstraint<CallbackSpyAssertions<T>> HaveBeenCalled(
			string because = "", params object[] becauseArgs)
	{
		Execute.Assertion
				.BecauseOf(because, becauseArgs)
				.ForCondition(Subject.InvokedWithArguments.Any())
				.FailWith("Expected callback to have been invoked, but it was not.");
		return new AndConstraint<CallbackSpyAssertions<T>>(this);
	}
	
	public AndConstraint<CallbackSpyAssertions<T>> HaveBeenCalledWith(
			T arg, string because = "", params object[] becauseArgs)
	{
		Execute.Assertion
				.BecauseOf(because, becauseArgs)
				.ForCondition(Subject.InvokedWithArguments.Contains(arg))
				.FailWith(CreateErrorMessage(arg, Subject.InvokedWithArguments));
		return new AndConstraint<CallbackSpyAssertions<T>>(this);
	}
	
	private static string CreateErrorMessage(T expectedArgument, List<T> actualArguments)
	{
		var stringBuilder = new StringBuilder();
		stringBuilder.Append($"Expected callback to have been invoked with {expectedArgument}, but it was ");
		if (!actualArguments.Any())
		{
			stringBuilder.AppendLine("not invoked.");
			return stringBuilder.ToString();
		}

		stringBuilder.AppendLine("invoked with:");
		foreach (var argument in actualArguments)
		{
			stringBuilder.AppendLine($"- {argument}");
		}

		return stringBuilder.ToString();
	}
}

public class CallbackSpyAssertions<T1, T2>
		: ReferenceTypeAssertions<CallbackSpy<T1, T2>, CallbackSpyAssertions<T1, T2>>
{
	public CallbackSpyAssertions(CallbackSpy<T1, T2> spy)
			: base(spy)
	{
	}
	
	protected override string Identifier => "callbackSpy";
	
	public AndConstraint<CallbackSpyAssertions<T1, T2>> HaveBeenCalled(
			string because = "", params object[] becauseArgs)
	{
		Execute.Assertion
				.BecauseOf(because, becauseArgs)
				.ForCondition(Subject.InvokedWithArguments.Any())
				.FailWith("Expected callback to have been invoked, but it was not.");
		return new AndConstraint<CallbackSpyAssertions<T1, T2>>(this);
	}
	
	public AndConstraint<CallbackSpyAssertions<T1, T2>> HaveBeenCalledWith(
			T1 arg1, T2 arg2, string because = "", params object[] becauseArgs)
	{
		Execute.Assertion
				.BecauseOf(because, becauseArgs)
				.ForCondition(Subject.InvokedWithArguments.Contains((arg1, arg2)))
				.FailWith(CreateErrorMessage((arg1, arg2), Subject.InvokedWithArguments));
		return new AndConstraint<CallbackSpyAssertions<T1, T2>>(this);
	}
	
	private static string CreateErrorMessage((T1, T2) expectedArgument, List<(T1, T2)> actualArguments)
	{
		var stringBuilder = new StringBuilder();
		stringBuilder.Append($"Expected callback to have been invoked with {expectedArgument}, but it was ");
		if (!actualArguments.Any())
		{
			stringBuilder.AppendLine("not invoked.");
			return stringBuilder.ToString();
		}

		stringBuilder.AppendLine("invoked with:");
		foreach (var argument in actualArguments)
		{
			stringBuilder.AppendLine($"- {argument}");
		}

		return stringBuilder.ToString();
	}
}

public class CallbackSpyAssertions<T1, T2, T3>
		: ReferenceTypeAssertions<CallbackSpy<T1, T2, T3>, CallbackSpyAssertions<T1, T2, T3>>
{
	public CallbackSpyAssertions(CallbackSpy<T1, T2, T3> spy)
			: base(spy)
	{
	}
	
	protected override string Identifier => "callbackSpy";
	
	public AndConstraint<CallbackSpyAssertions<T1, T2, T3>> HaveBeenCalled(
			string because = "", params object[] becauseArgs)
	{
		Execute.Assertion
				.BecauseOf(because, becauseArgs)
				.ForCondition(Subject.InvokedWithArguments.Any())
				.FailWith("Expected callback to have been invoked, but it was not.");
		return new AndConstraint<CallbackSpyAssertions<T1, T2, T3>>(this);
	}
	
	public AndConstraint<CallbackSpyAssertions<T1, T2, T3>> HaveBeenCalledWith(
			T1 arg1, T2 arg2, T3 arg3, string because = "", params object[] becauseArgs)
	{
		Execute.Assertion
				.BecauseOf(because, becauseArgs)
				.ForCondition(Subject.InvokedWithArguments.Contains((arg1, arg2, arg3)))
				.FailWith(CreateErrorMessage((arg1, arg2, arg3), Subject.InvokedWithArguments));
		return new AndConstraint<CallbackSpyAssertions<T1, T2, T3>>(this);
	}
	
	private static string CreateErrorMessage((T1, T2, T3) expectedArgument, List<(T1, T2, T3)> actualArguments)
	{
		var stringBuilder = new StringBuilder();
		stringBuilder.Append($"Expected callback to have been invoked with {expectedArgument}, but it was ");
		if (!actualArguments.Any())
		{
			stringBuilder.AppendLine("not invoked.");
			return stringBuilder.ToString();
		}

		stringBuilder.AppendLine("invoked with:");
		foreach (var argument in actualArguments)
		{
			stringBuilder.AppendLine($"- {argument}");
		}

		return stringBuilder.ToString();
	}
}

public class CallbackSpyAssertions<T1, T2, T3, T4>
		: ReferenceTypeAssertions<CallbackSpy<T1, T2, T3, T4>, CallbackSpyAssertions<T1, T2, T3, T4>>
{
	public CallbackSpyAssertions(CallbackSpy<T1, T2, T3, T4> spy)
			: base(spy)
	{
	}
	
	protected override string Identifier => "callbackSpy";
	
	public AndConstraint<CallbackSpyAssertions<T1, T2, T3, T4>> HaveBeenCalled(
			string because = "", params object[] becauseArgs)
	{
		Execute.Assertion
				.BecauseOf(because, becauseArgs)
				.ForCondition(Subject.InvokedWithArguments.Any())
				.FailWith("Expected callback to have been invoked, but it was not.");
		return new AndConstraint<CallbackSpyAssertions<T1, T2, T3, T4>>(this);
	}
	
	public AndConstraint<CallbackSpyAssertions<T1, T2, T3, T4>> HaveBeenCalledWith(
			T1 arg1, T2 arg2, T3 arg3, T4 arg4, string because = "", params object[] becauseArgs)
	{
		Execute.Assertion
				.BecauseOf(because, becauseArgs)
				.ForCondition(Subject.InvokedWithArguments.Contains((arg1, arg2, arg3, arg4)))
				.FailWith(CreateErrorMessage((arg1, arg2, arg3, arg4), Subject.InvokedWithArguments));
		return new AndConstraint<CallbackSpyAssertions<T1, T2, T3, T4>>(this);
	}
	
	private static string CreateErrorMessage((T1, T2, T3, T4) expectedArgument, List<(T1, T2, T3, T4)> actualArguments)
	{
		var stringBuilder = new StringBuilder();
		stringBuilder.Append($"Expected callback to have been invoked with {expectedArgument}, but it was ");
		if (!actualArguments.Any())
		{
			stringBuilder.AppendLine("not invoked.");
			return stringBuilder.ToString();
		}

		stringBuilder.AppendLine("invoked with:");
		foreach (var argument in actualArguments)
		{
			stringBuilder.AppendLine($"- {argument}");
		}

		return stringBuilder.ToString();
	}
}

public class CallbackSpyAssertions<T1, T2, T3, T4, T5>
		: ReferenceTypeAssertions<CallbackSpy<T1, T2, T3, T4, T5>, CallbackSpyAssertions<T1, T2, T3, T4, T5>>
{
	public CallbackSpyAssertions(CallbackSpy<T1, T2, T3, T4, T5> spy)
			: base(spy)
	{
	}
	
	protected override string Identifier => "callbackSpy";
	
	public AndConstraint<CallbackSpyAssertions<T1, T2, T3, T4, T5>> HaveBeenCalled(
			string because = "", params object[] becauseArgs)
	{
		Execute.Assertion
				.BecauseOf(because, becauseArgs)
				.ForCondition(Subject.InvokedWithArguments.Any())
				.FailWith("Expected callback to have been invoked, but it was not.");
		return new AndConstraint<CallbackSpyAssertions<T1, T2, T3, T4, T5>>(this);
	}
	
	public AndConstraint<CallbackSpyAssertions<T1, T2, T3, T4, T5>> HaveBeenCalledWith(
			T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, string because = "", params object[] becauseArgs)
	{
		Execute.Assertion
				.BecauseOf(because, becauseArgs)
				.ForCondition(Subject.InvokedWithArguments.Contains((arg1, arg2, arg3, arg4, arg5)))
				.FailWith(CreateErrorMessage((arg1, arg2, arg3, arg4, arg5), Subject.InvokedWithArguments));
		return new AndConstraint<CallbackSpyAssertions<T1, T2, T3, T4, T5>>(this);
	}
	
	private static string CreateErrorMessage(
			(T1, T2, T3, T4, T5) expectedArgument, List<(T1, T2, T3, T4, T5)> actualArguments)
	{
		var stringBuilder = new StringBuilder();
		stringBuilder.Append($"Expected callback to have been invoked with {expectedArgument}, but it was ");
		if (!actualArguments.Any())
		{
			stringBuilder.AppendLine("not invoked.");
			return stringBuilder.ToString();
		}

		stringBuilder.AppendLine("invoked with:");
		foreach (var argument in actualArguments)
		{
			stringBuilder.AppendLine($"- {argument}");
		}

		return stringBuilder.ToString();
	}
}

public class CallbackSpyAssertions<T1, T2, T3, T4, T5, T6>
		: ReferenceTypeAssertions<CallbackSpy<T1, T2, T3, T4, T5, T6>, CallbackSpyAssertions<T1, T2, T3, T4, T5, T6>>
{
	public CallbackSpyAssertions(CallbackSpy<T1, T2, T3, T4, T5, T6> spy)
			: base(spy)
	{
	}
	
	protected override string Identifier => "callbackSpy";
	
	public AndConstraint<CallbackSpyAssertions<T1, T2, T3, T4, T5, T6>> HaveBeenCalled(
			string because = "", params object[] becauseArgs)
	{
		Execute.Assertion
				.BecauseOf(because, becauseArgs)
				.ForCondition(Subject.InvokedWithArguments.Any())
				.FailWith("Expected callback to have been invoked, but it was not.");
		return new AndConstraint<CallbackSpyAssertions<T1, T2, T3, T4, T5, T6>>(this);
	}
	
	public AndConstraint<CallbackSpyAssertions<T1, T2, T3, T4, T5, T6>> HaveBeenCalledWith(
			T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6,
			string because = "", params object[] becauseArgs)
	{
		Execute.Assertion
				.BecauseOf(because, becauseArgs)
				.ForCondition(Subject.InvokedWithArguments.Contains((arg1, arg2, arg3, arg4, arg5, arg6)))
				.FailWith(CreateErrorMessage((arg1, arg2, arg3, arg4, arg5, arg6), Subject.InvokedWithArguments));
		return new AndConstraint<CallbackSpyAssertions<T1, T2, T3, T4, T5, T6>>(this);
	}
	
	private static string CreateErrorMessage(
			(T1, T2, T3, T4, T5, T6) expectedArgument, List<(T1, T2, T3, T4, T5, T6)> actualArguments)
	{
		var stringBuilder = new StringBuilder();
		stringBuilder.Append($"Expected callback to have been invoked with {expectedArgument}, but it was ");
		if (!actualArguments.Any())
		{
			stringBuilder.AppendLine("not invoked.");
			return stringBuilder.ToString();
		}

		stringBuilder.AppendLine("invoked with:");
		foreach (var argument in actualArguments)
		{
			stringBuilder.AppendLine($"- {argument}");
		}

		return stringBuilder.ToString();
	}
}

public class CallbackSpyAssertions<T1, T2, T3, T4, T5, T6, T7>
		: ReferenceTypeAssertions<CallbackSpy<T1, T2, T3, T4, T5, T6, T7>, CallbackSpyAssertions<T1, T2, T3, T4, T5, T6, T7>>
{
	public CallbackSpyAssertions(CallbackSpy<T1, T2, T3, T4, T5, T6, T7> spy)
			: base(spy)
	{
	}
	
	protected override string Identifier => "callbackSpy";
	
	public AndConstraint<CallbackSpyAssertions<T1, T2, T3, T4, T5, T6, T7>> HaveBeenCalled(
			string because = "", params object[] becauseArgs)
	{
		Execute.Assertion
				.BecauseOf(because, becauseArgs)
				.ForCondition(Subject.InvokedWithArguments.Any())
				.FailWith("Expected callback to have been invoked, but it was not.");
		return new AndConstraint<CallbackSpyAssertions<T1, T2, T3, T4, T5, T6, T7>>(this);
	}
	
	public AndConstraint<CallbackSpyAssertions<T1, T2, T3, T4, T5, T6, T7>> HaveBeenCalledWith(
			T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7,
			string because = "", params object[] becauseArgs)
	{
		Execute.Assertion
				.BecauseOf(because, becauseArgs)
				.ForCondition(Subject.InvokedWithArguments.Contains((arg1, arg2, arg3, arg4, arg5, arg6, arg7)))
				.FailWith(CreateErrorMessage((arg1, arg2, arg3, arg4, arg5, arg6, arg7), Subject.InvokedWithArguments));
		return new AndConstraint<CallbackSpyAssertions<T1, T2, T3, T4, T5, T6, T7>>(this);
	}
	
	private static string CreateErrorMessage(
			(T1, T2, T3, T4, T5, T6, T7) expectedArgument, List<(T1, T2, T3, T4, T5, T6, T7)> actualArguments)
	{
		var stringBuilder = new StringBuilder();
		stringBuilder.Append($"Expected callback to have been invoked with {expectedArgument}, but it was ");
		if (!actualArguments.Any())
		{
			stringBuilder.AppendLine("not invoked.");
			return stringBuilder.ToString();
		}

		stringBuilder.AppendLine("invoked with:");
		foreach (var argument in actualArguments)
		{
			stringBuilder.AppendLine($"- {argument}");
		}

		return stringBuilder.ToString();
	}
}

public class CallbackSpyAssertions<T1, T2, T3, T4, T5, T6, T7, T8>
		: ReferenceTypeAssertions<CallbackSpy<T1, T2, T3, T4, T5, T6, T7, T8>, CallbackSpyAssertions<T1, T2, T3, T4, T5, T6, T7, T8>>
{
	public CallbackSpyAssertions(CallbackSpy<T1, T2, T3, T4, T5, T6, T7, T8> spy)
			: base(spy)
	{
	}
	
	protected override string Identifier => "callbackSpy";
	
	public AndConstraint<CallbackSpyAssertions<T1, T2, T3, T4, T5, T6, T7, T8>> HaveBeenCalled(
			string because = "", params object[] becauseArgs)
	{
		Execute.Assertion
				.BecauseOf(because, becauseArgs)
				.ForCondition(Subject.InvokedWithArguments.Any())
				.FailWith("Expected callback to have been invoked, but it was not.");
		return new AndConstraint<CallbackSpyAssertions<T1, T2, T3, T4, T5, T6, T7, T8>>(this);
	}
	
	public AndConstraint<CallbackSpyAssertions<T1, T2, T3, T4, T5, T6, T7, T8>> HaveBeenCalledWith(
			T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8,
			string because = "", params object[] becauseArgs)
	{
		Execute.Assertion
				.BecauseOf(because, becauseArgs)
				.ForCondition(Subject.InvokedWithArguments.Contains((arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8)))
				.FailWith(CreateErrorMessage((arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8), Subject.InvokedWithArguments));
		return new AndConstraint<CallbackSpyAssertions<T1, T2, T3, T4, T5, T6, T7, T8>>(this);
	}
	
	private static string CreateErrorMessage(
			(T1, T2, T3, T4, T5, T6, T7, T8) expectedArgument,
			List<(T1, T2, T3, T4, T5, T6, T7, T8)> actualArguments)
	{
		var stringBuilder = new StringBuilder();
		stringBuilder.Append($"Expected callback to have been invoked with {expectedArgument}, but it was ");
		if (!actualArguments.Any())
		{
			stringBuilder.AppendLine("not invoked.");
			return stringBuilder.ToString();
		}

		stringBuilder.AppendLine("invoked with:");
		foreach (var argument in actualArguments)
		{
			stringBuilder.AppendLine($"- {argument}");
		}

		return stringBuilder.ToString();
	}
}

public class CallbackSpyAssertions<T1, T2, T3, T4, T5, T6, T7, T8, T9>
		: ReferenceTypeAssertions<CallbackSpy<T1, T2, T3, T4, T5, T6, T7, T8, T9>, CallbackSpyAssertions<T1, T2, T3, T4, T5, T6, T7, T8, T9>>
{
	public CallbackSpyAssertions(CallbackSpy<T1, T2, T3, T4, T5, T6, T7, T8, T9> spy)
			: base(spy)
	{
	}
	
	protected override string Identifier => "callbackSpy";
	
	public AndConstraint<CallbackSpyAssertions<T1, T2, T3, T4, T5, T6, T7, T8, T9>> HaveBeenCalled(
			string because = "", params object[] becauseArgs)
	{
		Execute.Assertion
				.BecauseOf(because, becauseArgs)
				.ForCondition(Subject.InvokedWithArguments.Any())
				.FailWith("Expected callback to have been invoked, but it was not.");
		return new AndConstraint<CallbackSpyAssertions<T1, T2, T3, T4, T5, T6, T7, T8, T9>>(this);
	}
	
	public AndConstraint<CallbackSpyAssertions<T1, T2, T3, T4, T5, T6, T7, T8, T9>> HaveBeenCalledWith(
			T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9,
			string because = "", params object[] becauseArgs)
	{
		Execute.Assertion
				.BecauseOf(because, becauseArgs)
				.ForCondition(Subject.InvokedWithArguments.Contains((arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9)))
				.FailWith(CreateErrorMessage((arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9), Subject.InvokedWithArguments));
		return new AndConstraint<CallbackSpyAssertions<T1, T2, T3, T4, T5, T6, T7, T8, T9>>(this);
	}
	
	private static string CreateErrorMessage(
			(T1, T2, T3, T4, T5, T6, T7, T8, T9) expectedArgument,
			List<(T1, T2, T3, T4, T5, T6, T7, T8, T9)> actualArguments)
	{
		var stringBuilder = new StringBuilder();
		stringBuilder.Append($"Expected callback to have been invoked with {expectedArgument}, but it was ");
		if (!actualArguments.Any())
		{
			stringBuilder.AppendLine("not invoked.");
			return stringBuilder.ToString();
		}

		stringBuilder.AppendLine("invoked with:");
		foreach (var argument in actualArguments)
		{
			stringBuilder.AppendLine($"- {argument}");
		}

		return stringBuilder.ToString();
	}
}