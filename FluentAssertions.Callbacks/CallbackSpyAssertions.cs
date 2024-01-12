namespace FluentAssertions.Callbacks;

using System.Text;
using Execution;
using Primitives;

public class CallbackSpyAssertions(CallbackSpy spy)
		: ReferenceTypeAssertions<CallbackSpy, CallbackSpyAssertions>(spy)
{
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

public class CallbackSpyAssertions<T>(CallbackSpy<T> spy)
		: ReferenceTypeAssertions<CallbackSpy<T>, CallbackSpyAssertions<T>>(spy)
{
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
	
	[Obsolete("Use Arg<T>.Is(Predicate<T>) instead.")]
	public AndConstraint<CallbackSpyAssertions<T>> HaveBeenCalledWith(
			Predicate<T> matcher, string because = "", params object[] becauseArgs)
	{
		Execute.Assertion
				.BecauseOf(because, becauseArgs)
				.ForCondition(Subject.InvokedWithArguments.Exists(matcher))
				.FailWith("Expected callback to have been invoked with matching arguments, but it was not.");
		return new AndConstraint<CallbackSpyAssertions<T>>(this);
	}
	
	public AndConstraint<CallbackSpyAssertions<T>> HaveBeenCalledWith(
			Arg<T> arg, string because = "", params object[] becauseArgs)
	{
		Execute.Assertion
				.BecauseOf(because, becauseArgs)
				.ForCondition(Subject.InvokedWithArguments.Exists(arg.DoesMatch))
				.FailWith(CreateErrorMessage(arg, Subject.InvokedWithArguments));
		return new AndConstraint<CallbackSpyAssertions<T>>(this);
	}
	
	private static string CreateErrorMessage(Arg<T> arg, List<T> actualArguments)
	{
		var stringBuilder = new StringBuilder();
		stringBuilder.Append($"Expected callback to have been invoked with ({arg}), but it was ");
		if (!actualArguments.Any())
		{
			stringBuilder.AppendLine("not invoked.");
			return stringBuilder.ToString();
		}

		stringBuilder.AppendLine("invoked with:");
		foreach (var argument in actualArguments)
			stringBuilder.AppendLine($"- {argument}");
		return stringBuilder.ToString();
	}
}

public class CallbackSpyAssertions<T1, T2>(CallbackSpy<T1, T2> spy)
		: ReferenceTypeAssertions<CallbackSpy<T1, T2>, CallbackSpyAssertions<T1, T2>>(spy)
{
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
	
	[Obsolete("Use Arg<T>.Is(Predicate<T>) instead.")]
	public AndConstraint<CallbackSpyAssertions<T1, T2>> HaveBeenCalledWith(
			Predicate<T1> m1, Predicate<T2> m2, string because = "", params object[] becauseArgs)
	{
		Execute.Assertion
				.BecauseOf(because, becauseArgs)
				.ForCondition(Subject.InvokedWithArguments.Exists(x => m1(x.Item1) && m2(x.Item2)))
				.FailWith("Expected callback to have been invoked with matching arguments, but it was not.");
		return new AndConstraint<CallbackSpyAssertions<T1, T2>>(this);
	}
	
	public AndConstraint<CallbackSpyAssertions<T1, T2>> HaveBeenCalledWith(
			Arg<T1> arg1, Arg<T2> arg2, string because = "", params object[] becauseArgs)
	{
		Execute.Assertion
				.BecauseOf(because, becauseArgs)
				.ForCondition(Subject.InvokedWithArguments.Exists(x =>
				{
					return arg1.DoesMatch(x.Item1)
					       && arg2.DoesMatch(x.Item2);
				}))
				.FailWith(CreateErrorMessage(arg1, arg2, Subject.InvokedWithArguments));
		return new AndConstraint<CallbackSpyAssertions<T1, T2>>(this);
	}
	
	private static string CreateErrorMessage(Arg<T1> arg1, Arg<T2> arg2, List<(T1, T2)> actualArguments)
	{
		var stringBuilder = new StringBuilder();
		stringBuilder.Append($"Expected callback to have been invoked with ({arg1}, {arg2}), but it was ");
		if (!actualArguments.Any())
		{
			stringBuilder.AppendLine("not invoked.");
			return stringBuilder.ToString();
		}

		stringBuilder.AppendLine("invoked with:");
		foreach (var argument in actualArguments)
			stringBuilder.AppendLine($"- {argument}");
		return stringBuilder.ToString();
	}
}

public class CallbackSpyAssertions<T1, T2, T3>(CallbackSpy<T1, T2, T3> spy)
		: ReferenceTypeAssertions<CallbackSpy<T1, T2, T3>, CallbackSpyAssertions<T1, T2, T3>>(spy)
{
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
	
	[Obsolete("Use Arg<T>.Is(Predicate<T>) instead.")]
	public AndConstraint<CallbackSpyAssertions<T1, T2, T3>> HaveBeenCalledWith(
			Predicate<T1> m1, Predicate<T2> m2, Predicate<T3> m3,
			string because = "", params object[] becauseArgs)
	{
		Execute.Assertion
				.BecauseOf(because, becauseArgs)
				.ForCondition(Subject.InvokedWithArguments.Exists(
						x => m1(x.Item1) && m2(x.Item2) && m3(x.Item3)))
				.FailWith("Expected callback to have been invoked with matching arguments, but it was not.");
		return new AndConstraint<CallbackSpyAssertions<T1, T2, T3>>(this);
	}
	
	public AndConstraint<CallbackSpyAssertions<T1, T2, T3>> HaveBeenCalledWith(
			Arg<T1> arg1, Arg<T2> arg2, Arg<T3> arg3,
			string because = "", params object[] becauseArgs)
	{
		Execute.Assertion
				.BecauseOf(because, becauseArgs)
				.ForCondition(Subject.InvokedWithArguments.Exists(x =>
				{
					return arg1.DoesMatch(x.Item1)
					       && arg2.DoesMatch(x.Item2)
					       && arg3.DoesMatch(x.Item3);
				}))
				.FailWith(CreateErrorMessage(arg1, arg2, arg3, Subject.InvokedWithArguments));
		return new AndConstraint<CallbackSpyAssertions<T1, T2, T3>>(this);
	}
	
	private static string CreateErrorMessage(
			Arg<T1> arg1, Arg<T2> arg2, Arg<T3> arg3,
			List<(T1, T2, T3)> actualArguments)
	{
		var stringBuilder = new StringBuilder();
		stringBuilder.Append($"Expected callback to have been invoked with ({arg1}, {arg2}, {arg3}), but it was ");
		if (!actualArguments.Any())
		{
			stringBuilder.AppendLine("not invoked.");
			return stringBuilder.ToString();
		}

		stringBuilder.AppendLine("invoked with:");
		foreach (var argument in actualArguments)
			stringBuilder.AppendLine($"- {argument}");
		return stringBuilder.ToString();
	}
}

public class CallbackSpyAssertions<T1, T2, T3, T4>(CallbackSpy<T1, T2, T3, T4> spy)
		: ReferenceTypeAssertions<CallbackSpy<T1, T2, T3, T4>, CallbackSpyAssertions<T1, T2, T3, T4>>(spy)
{
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
	
	[Obsolete("Use Arg<T>.Is(Predicate<T>) instead.")]
	public AndConstraint<CallbackSpyAssertions<T1, T2, T3, T4>> HaveBeenCalledWith(
			Predicate<T1> m1, Predicate<T2> m2, Predicate<T3> m3, Predicate<T4> m4,
			string because = "", params object[] becauseArgs)
	{
		Execute.Assertion
				.BecauseOf(because, becauseArgs)
				.ForCondition(Subject.InvokedWithArguments.Exists(
						x => m1(x.Item1) && m2(x.Item2) && m3(x.Item3) && m4(x.Item4)))
				.FailWith("Expected callback to have been invoked with matching arguments, but it was not.");
		return new AndConstraint<CallbackSpyAssertions<T1, T2, T3, T4>>(this);
	}
	
	public AndConstraint<CallbackSpyAssertions<T1, T2, T3, T4>> HaveBeenCalledWith(
			Arg<T1> arg1, Arg<T2> arg2, Arg<T3> arg3, Arg<T4> arg4,
			string because = "", params object[] becauseArgs)
	{
		Execute.Assertion
				.BecauseOf(because, becauseArgs)
				.ForCondition(Subject.InvokedWithArguments.Exists(x =>
				{
					return arg1.DoesMatch(x.Item1)
					       && arg2.DoesMatch(x.Item2)
					       && arg3.DoesMatch(x.Item3)
					       && arg4.DoesMatch(x.Item4);
				}))
				.FailWith(CreateErrorMessage(arg1, arg2, arg3, arg4, Subject.InvokedWithArguments));
		return new AndConstraint<CallbackSpyAssertions<T1, T2, T3, T4>>(this);
	}
	
	private static string CreateErrorMessage(
			Arg<T1> arg1, Arg<T2> arg2, Arg<T3> arg3, Arg<T4> arg4,
			List<(T1, T2, T3, T4)> actualArguments)
	{
		var stringBuilder = new StringBuilder();
		stringBuilder.Append($"Expected callback to have been invoked with ({arg1}, {arg2}, {arg3}, {arg4}), but it was ");
		if (!actualArguments.Any())
		{
			stringBuilder.AppendLine("not invoked.");
			return stringBuilder.ToString();
		}

		stringBuilder.AppendLine("invoked with:");
		foreach (var argument in actualArguments)
			stringBuilder.AppendLine($"- {argument}");
		return stringBuilder.ToString();
	}
}

public class CallbackSpyAssertions<T1, T2, T3, T4, T5>(CallbackSpy<T1, T2, T3, T4, T5> spy)
		: ReferenceTypeAssertions<CallbackSpy<T1, T2, T3, T4, T5>,
				CallbackSpyAssertions<T1, T2, T3, T4, T5>>(spy)
{
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
	
	[Obsolete("Use Arg<T>.Is(Predicate<T>) instead.")]
	public AndConstraint<CallbackSpyAssertions<T1, T2, T3, T4, T5>> HaveBeenCalledWith(
			Predicate<T1> m1, Predicate<T2> m2, Predicate<T3> m3, Predicate<T4> m4, Predicate<T5> m5,
			string because = "", params object[] becauseArgs)
	{
		Execute.Assertion
				.BecauseOf(because, becauseArgs)
				.ForCondition(Subject.InvokedWithArguments.Exists(
						x => m1(x.Item1) && m2(x.Item2) && m3(x.Item3) && m4(x.Item4) && m5(x.Item5)))
				.FailWith("Expected callback to have been invoked with matching arguments, but it was not.");
		return new AndConstraint<CallbackSpyAssertions<T1, T2, T3, T4, T5>>(this);
	}
	
	public AndConstraint<CallbackSpyAssertions<T1, T2, T3, T4, T5>> HaveBeenCalledWith(
			Arg<T1> arg1, Arg<T2> arg2, Arg<T3> arg3, Arg<T4> arg4, Arg<T5> arg5,
			string because = "", params object[] becauseArgs)
	{
		Execute.Assertion
				.BecauseOf(because, becauseArgs)
				.ForCondition(Subject.InvokedWithArguments.Exists(x =>
				{
					return arg1.DoesMatch(x.Item1)
					       && arg2.DoesMatch(x.Item2)
					       && arg3.DoesMatch(x.Item3)
					       && arg4.DoesMatch(x.Item4)
					       && arg5.DoesMatch(x.Item5);
				}))
				.FailWith(CreateErrorMessage(arg1, arg2, arg3, arg4, arg5, Subject.InvokedWithArguments));
		return new AndConstraint<CallbackSpyAssertions<T1, T2, T3, T4, T5>>(this);
	}
	
	private static string CreateErrorMessage(
			Arg<T1> arg1, Arg<T2> arg2, Arg<T3> arg3, Arg<T4> arg4, Arg<T5> arg5,
			List<(T1, T2, T3, T4, T5)> actualArguments)
	{
		var stringBuilder = new StringBuilder();
		stringBuilder.Append($"Expected callback to have been invoked with ({arg1}, {arg2}, {arg3}, {arg4}, {arg5}), but it was ");
		if (!actualArguments.Any())
		{
			stringBuilder.AppendLine("not invoked.");
			return stringBuilder.ToString();
		}

		stringBuilder.AppendLine("invoked with:");
		foreach (var argument in actualArguments)
			stringBuilder.AppendLine($"- {argument}");
		return stringBuilder.ToString();
	}
}

public class CallbackSpyAssertions<T1, T2, T3, T4, T5, T6>(CallbackSpy<T1, T2, T3, T4, T5, T6> spy)
		: ReferenceTypeAssertions<CallbackSpy<T1, T2, T3, T4, T5, T6>,
				CallbackSpyAssertions<T1, T2, T3, T4, T5, T6>>(spy)
{
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
	
	[Obsolete("Use Arg<T>.Is(Predicate<T>) instead.")]
	public AndConstraint<CallbackSpyAssertions<T1, T2, T3, T4, T5, T6>> HaveBeenCalledWith(
			Predicate<T1> m1, Predicate<T2> m2, Predicate<T3> m3, Predicate<T4> m4, Predicate<T5> m5,
			Predicate<T6> m6,
			string because = "", params object[] becauseArgs)
	{
		Execute.Assertion
				.BecauseOf(because, becauseArgs)
				.ForCondition(Subject.InvokedWithArguments.Exists(
						x => m1(x.Item1) && m2(x.Item2) && m3(x.Item3) && m4(x.Item4) && m5(x.Item5)
						     && m6(x.Item6)))
				.FailWith("Expected callback to have been invoked with matching arguments, but it was not.");
		return new AndConstraint<CallbackSpyAssertions<T1, T2, T3, T4, T5, T6>>(this);
	}
	
	public AndConstraint<CallbackSpyAssertions<T1, T2, T3, T4, T5, T6>> HaveBeenCalledWith(
			Arg<T1> arg1, Arg<T2> arg2, Arg<T3> arg3, Arg<T4> arg4, Arg<T5> arg5, Arg<T6> arg6,
			string because = "", params object[] becauseArgs)
	{
		Execute.Assertion
				.BecauseOf(because, becauseArgs)
				.ForCondition(Subject.InvokedWithArguments.Exists(x =>
				{
					return arg1.DoesMatch(x.Item1)
					       && arg2.DoesMatch(x.Item2)
					       && arg3.DoesMatch(x.Item3)
					       && arg4.DoesMatch(x.Item4)
					       && arg5.DoesMatch(x.Item5)
					       && arg6.DoesMatch(x.Item6);
				}))
				.FailWith(CreateErrorMessage(arg1, arg2, arg3, arg4, arg5, arg6, Subject.InvokedWithArguments));
		return new AndConstraint<CallbackSpyAssertions<T1, T2, T3, T4, T5, T6>>(this);
	}
	
	private static string CreateErrorMessage(
			Arg<T1> arg1, Arg<T2> arg2, Arg<T3> arg3, Arg<T4> arg4, Arg<T5> arg5, Arg<T6> arg6,
			List<(T1, T2, T3, T4, T5, T6)> actualArguments)
	{
		var stringBuilder = new StringBuilder();
		stringBuilder.Append($"Expected callback to have been invoked with ({arg1}, {arg2}, {arg3}, {arg4}, {arg5}, {arg6}), but it was ");
		if (!actualArguments.Any())
		{
			stringBuilder.AppendLine("not invoked.");
			return stringBuilder.ToString();
		}

		stringBuilder.AppendLine("invoked with:");
		foreach (var argument in actualArguments)
			stringBuilder.AppendLine($"- {argument}");
		return stringBuilder.ToString();
	}
}

public class CallbackSpyAssertions<T1, T2, T3, T4, T5, T6, T7>(
		CallbackSpy<T1, T2, T3, T4, T5, T6, T7> spy)
		: ReferenceTypeAssertions<CallbackSpy<T1, T2, T3, T4, T5, T6, T7>,
				CallbackSpyAssertions<T1, T2, T3, T4, T5, T6, T7>>(spy)
{
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
	
	[Obsolete("Use Arg<T>.Is(Predicate<T>) instead.")]
	public AndConstraint<CallbackSpyAssertions<T1, T2, T3, T4, T5, T6, T7>> HaveBeenCalledWith(
			Predicate<T1> m1, Predicate<T2> m2, Predicate<T3> m3, Predicate<T4> m4, Predicate<T5> m5,
			Predicate<T6> m6, Predicate<T7> m7,
			string because = "", params object[] becauseArgs)
	{
		Execute.Assertion
				.BecauseOf(because, becauseArgs)
				.ForCondition(Subject.InvokedWithArguments.Exists(
						x => m1(x.Item1) && m2(x.Item2) && m3(x.Item3) && m4(x.Item4) && m5(x.Item5)
						     && m6(x.Item6) && m7(x.Item7)))
				.FailWith("Expected callback to have been invoked with matching arguments, but it was not.");
		return new AndConstraint<CallbackSpyAssertions<T1, T2, T3, T4, T5, T6, T7>>(this);
	}
	
	public AndConstraint<CallbackSpyAssertions<T1, T2, T3, T4, T5, T6, T7>> HaveBeenCalledWith(
			Arg<T1> arg1, Arg<T2> arg2, Arg<T3> arg3, Arg<T4> arg4, Arg<T5> arg5, Arg<T6> arg6,
			Arg<T7> arg7,
			string because = "", params object[] becauseArgs)
	{
		Execute.Assertion
				.BecauseOf(because, becauseArgs)
				.ForCondition(Subject.InvokedWithArguments.Exists(x =>
				{
					return arg1.DoesMatch(x.Item1)
					       && arg2.DoesMatch(x.Item2)
					       && arg3.DoesMatch(x.Item3)
					       && arg4.DoesMatch(x.Item4)
					       && arg5.DoesMatch(x.Item5)
					       && arg6.DoesMatch(x.Item6)
					       && arg7.DoesMatch(x.Item7);
				}))
				.FailWith(CreateErrorMessage(arg1, arg2, arg3, arg4, arg5, arg6, arg7, Subject.InvokedWithArguments));
		return new AndConstraint<CallbackSpyAssertions<T1, T2, T3, T4, T5, T6, T7>>(this);
	}
	
	private static string CreateErrorMessage(
			Arg<T1> arg1, Arg<T2> arg2, Arg<T3> arg3, Arg<T4> arg4, Arg<T5> arg5, Arg<T6> arg6,
			Arg<T7> arg7,
			List<(T1, T2, T3, T4, T5, T6, T7)> actualArguments)
	{
		var stringBuilder = new StringBuilder();
		stringBuilder.Append($"Expected callback to have been invoked with ({arg1}, {arg2}, {arg3}, {arg4}, {arg5}, {arg6}, {arg7}), but it was ");
		if (!actualArguments.Any())
		{
			stringBuilder.AppendLine("not invoked.");
			return stringBuilder.ToString();
		}

		stringBuilder.AppendLine("invoked with:");
		foreach (var argument in actualArguments)
			stringBuilder.AppendLine($"- {argument}");
		return stringBuilder.ToString();
	}
}

public class CallbackSpyAssertions<T1, T2, T3, T4, T5, T6, T7, T8>(
		CallbackSpy<T1, T2, T3, T4, T5, T6, T7, T8> spy)
		: ReferenceTypeAssertions<CallbackSpy<T1, T2, T3, T4, T5, T6, T7, T8>,
				CallbackSpyAssertions<T1, T2, T3, T4, T5, T6, T7, T8>>(spy)
{
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
	
	[Obsolete("Use Arg<T>.Is(Predicate<T>) instead.")]
	public AndConstraint<CallbackSpyAssertions<T1, T2, T3, T4, T5, T6, T7, T8>> HaveBeenCalledWith(
			Predicate<T1> m1, Predicate<T2> m2, Predicate<T3> m3, Predicate<T4> m4, Predicate<T5> m5,
			Predicate<T6> m6, Predicate<T7> m7, Predicate<T8> m8,
			string because = "", params object[] becauseArgs)
	{
		Execute.Assertion
				.BecauseOf(because, becauseArgs)
				.ForCondition(Subject.InvokedWithArguments.Exists(
						x => m1(x.Item1) && m2(x.Item2) && m3(x.Item3) && m4(x.Item4) && m5(x.Item5)
						     && m6(x.Item6) && m7(x.Item7) && m8(x.Item8)))
				.FailWith("Expected callback to have been invoked with matching arguments, but it was not.");
		return new AndConstraint<CallbackSpyAssertions<T1, T2, T3, T4, T5, T6, T7, T8>>(this);
	}
	
	public AndConstraint<CallbackSpyAssertions<T1, T2, T3, T4, T5, T6, T7, T8>> HaveBeenCalledWith(
			Arg<T1> arg1, Arg<T2> arg2, Arg<T3> arg3, Arg<T4> arg4, Arg<T5> arg5, Arg<T6> arg6,
			Arg<T7> arg7, Arg<T8> arg8,
			string because = "", params object[] becauseArgs)
	{
		Execute.Assertion
				.BecauseOf(because, becauseArgs)
				.ForCondition(Subject.InvokedWithArguments.Exists(x =>
				{
					return arg1.DoesMatch(x.Item1)
					       && arg2.DoesMatch(x.Item2)
					       && arg3.DoesMatch(x.Item3)
					       && arg4.DoesMatch(x.Item4)
					       && arg5.DoesMatch(x.Item5)
					       && arg6.DoesMatch(x.Item6)
					       && arg7.DoesMatch(x.Item7)
					       && arg8.DoesMatch(x.Item8);
				}))
				.FailWith(CreateErrorMessage(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, Subject.InvokedWithArguments));
		return new AndConstraint<CallbackSpyAssertions<T1, T2, T3, T4, T5, T6, T7, T8>>(this);
	}
	
	private static string CreateErrorMessage(
			Arg<T1> arg1, Arg<T2> arg2, Arg<T3> arg3, Arg<T4> arg4, Arg<T5> arg5, Arg<T6> arg6,
			Arg<T7> arg7, Arg<T8> arg8,
			List<(T1, T2, T3, T4, T5, T6, T7, T8)> actualArguments)
	{
		var stringBuilder = new StringBuilder();
		stringBuilder.Append($"Expected callback to have been invoked with ({arg1}, {arg2}, {arg3}, {arg4}, {arg5}, {arg6}, {arg7}, {arg8}), but it was ");
		if (!actualArguments.Any())
		{
			stringBuilder.AppendLine("not invoked.");
			return stringBuilder.ToString();
		}

		stringBuilder.AppendLine("invoked with:");
		foreach (var argument in actualArguments)
			stringBuilder.AppendLine($"- {argument}");
		return stringBuilder.ToString();
	}
}

public class CallbackSpyAssertions<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
		CallbackSpy<T1, T2, T3, T4, T5, T6, T7, T8, T9> spy)
		: ReferenceTypeAssertions<CallbackSpy<T1, T2, T3, T4, T5, T6, T7, T8, T9>,
				CallbackSpyAssertions<T1, T2, T3, T4, T5, T6, T7, T8, T9>>(spy)
{
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
	
	[Obsolete("Use Arg<T>.Is(Predicate<T>) instead.")]
	public AndConstraint<CallbackSpyAssertions<T1, T2, T3, T4, T5, T6, T7, T8, T9>> HaveBeenCalledWith(
			Predicate<T1> m1, Predicate<T2> m2, Predicate<T3> m3, Predicate<T4> m4, Predicate<T5> m5,
			Predicate<T6> m6, Predicate<T7> m7, Predicate<T8> m8, Predicate<T9> m9,
			string because = "", params object[] becauseArgs)
	{
		Execute.Assertion
				.BecauseOf(because, becauseArgs)
				.ForCondition(Subject.InvokedWithArguments.Exists(
						x => m1(x.Item1) && m2(x.Item2) && m3(x.Item3) && m4(x.Item4) && m5(x.Item5)
						     && m6(x.Item6) && m7(x.Item7) && m8(x.Item8) && m9(x.Item9)))
				.FailWith("Expected callback to have been invoked with matching arguments, but it was not.");
		return new AndConstraint<CallbackSpyAssertions<T1, T2, T3, T4, T5, T6, T7, T8, T9>>(this);
	}
	
	public AndConstraint<CallbackSpyAssertions<T1, T2, T3, T4, T5, T6, T7, T8, T9>> HaveBeenCalledWith(
			Arg<T1> arg1, Arg<T2> arg2, Arg<T3> arg3, Arg<T4> arg4, Arg<T5> arg5, Arg<T6> arg6,
			Arg<T7> arg7, Arg<T8> arg8, Arg<T9> arg9,
			string because = "", params object[] becauseArgs)
	{
		Execute.Assertion
				.BecauseOf(because, becauseArgs)
				.ForCondition(Subject.InvokedWithArguments.Exists(x =>
				{
					return arg1.DoesMatch(x.Item1)
					       && arg2.DoesMatch(x.Item2)
					       && arg3.DoesMatch(x.Item3)
					       && arg4.DoesMatch(x.Item4)
					       && arg5.DoesMatch(x.Item5)
					       && arg6.DoesMatch(x.Item6)
					       && arg7.DoesMatch(x.Item7)
					       && arg8.DoesMatch(x.Item8)
					       && arg9.DoesMatch(x.Item9);
				}))
				.FailWith(CreateErrorMessage(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, Subject.InvokedWithArguments));
		return new AndConstraint<CallbackSpyAssertions<T1, T2, T3, T4, T5, T6, T7, T8, T9>>(this);
	}
	
	private static string CreateErrorMessage(
			Arg<T1> arg1, Arg<T2> arg2, Arg<T3> arg3, Arg<T4> arg4, Arg<T5> arg5, Arg<T6> arg6,
			Arg<T7> arg7, Arg<T8> arg8, Arg<T9> arg9,
			List<(T1, T2, T3, T4, T5, T6, T7, T8, T9)> actualArguments)
	{
		var stringBuilder = new StringBuilder();
		stringBuilder.Append($"Expected callback to have been invoked with ({arg1}, {arg2}, {arg3}, {arg4}, {arg5}, {arg6}, {arg7}, {arg8}, {arg9}), but it was ");
		if (!actualArguments.Any())
		{
			stringBuilder.AppendLine("not invoked.");
			return stringBuilder.ToString();
		}

		stringBuilder.AppendLine("invoked with:");
		foreach (var argument in actualArguments)
			stringBuilder.AppendLine($"- {argument}");
		return stringBuilder.ToString();
	}
}