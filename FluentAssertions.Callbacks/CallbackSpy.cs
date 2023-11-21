namespace FluentAssertions.Callbacks;

public class CallbackSpy
{
	public int InvocationCount { get; private set; }
	public Action Callback { get; }
	
	public CallbackSpy()
	{
		Callback = () => InvocationCount++;
	}
}

public class CallbackSpy<T>
{
	public List<T> InvokedWithArguments { get; } = new();
	public Action<T> Callback { get; }
	
	public CallbackSpy()
	{
		Callback = arg
				=> InvokedWithArguments.Add(arg);
	}
}

public class CallbackSpy<T1, T2>
{
	public List<(T1, T2)> InvokedWithArguments { get; } = new();
	public Action<T1, T2> Callback { get; }
	
	public CallbackSpy()
	{
		Callback = (arg1, arg2)
				=> InvokedWithArguments.Add((arg1, arg2));
	}
}

public class CallbackSpy<T1, T2, T3>
{
	public List<(T1, T2, T3)> InvokedWithArguments { get; } = new();
	public Action<T1, T2, T3> Callback { get; }
	
	public CallbackSpy()
	{
		Callback = (arg1, arg2, arg3)
				=> InvokedWithArguments.Add((arg1, arg2, arg3));
	}
}

public class CallbackSpy<T1, T2, T3, T4>
{
	public List<(T1, T2, T3, T4)> InvokedWithArguments { get; } = new();
	public Action<T1, T2, T3, T4> Callback { get; }
	
	public CallbackSpy()
	{
		Callback = (arg1, arg2, arg3, arg4)
				=> InvokedWithArguments.Add((arg1, arg2, arg3, arg4));
	}
}

public class CallbackSpy<T1, T2, T3, T4, T5>
{
	public List<(T1, T2, T3, T4, T5)> InvokedWithArguments { get; } = new();
	public Action<T1, T2, T3, T4, T5> Callback { get; }
	
	public CallbackSpy()
	{
		Callback = (arg1, arg2, arg3, arg4, arg5)
				=> InvokedWithArguments.Add((arg1, arg2, arg3, arg4, arg5));
	}
}

public class CallbackSpy<T1, T2, T3, T4, T5, T6>
{
	public List<(T1, T2, T3, T4, T5, T6)> InvokedWithArguments { get; } = new();
	public Action<T1, T2, T3, T4, T5, T6> Callback { get; }
	
	public CallbackSpy()
	{
		Callback = (arg1, arg2, arg3, arg4, arg5, arg6)
				=> InvokedWithArguments.Add((arg1, arg2, arg3, arg4, arg5, arg6));
	}
}

public class CallbackSpy<T1, T2, T3, T4, T5, T6, T7>
{
	public List<(T1, T2, T3, T4, T5, T6, T7)> InvokedWithArguments { get; } = new();
	public Action<T1, T2, T3, T4, T5, T6, T7> Callback { get; }
	
	public CallbackSpy()
	{
		Callback = (arg1, arg2, arg3, arg4, arg5, arg6, arg7)
				=> InvokedWithArguments.Add((arg1, arg2, arg3, arg4, arg5, arg6, arg7));
	}
}

public class CallbackSpy<T1, T2, T3, T4, T5, T6, T7, T8>
{
	public List<(T1, T2, T3, T4, T5, T6, T7, T8)> InvokedWithArguments { get; } = new();
	public Action<T1, T2, T3, T4, T5, T6, T7, T8> Callback { get; }
	
	public CallbackSpy()
	{
		Callback = (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8)
				=> InvokedWithArguments.Add((arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8));
	}
}

public class CallbackSpy<T1, T2, T3, T4, T5, T6, T7, T8, T9>
{
	public List<(T1, T2, T3, T4, T5, T6, T7, T8, T9)> InvokedWithArguments { get; } = new();
	public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> Callback { get; }
	
	public CallbackSpy()
	{
		Callback = (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9)
				=> InvokedWithArguments.Add((arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9));
	}
}