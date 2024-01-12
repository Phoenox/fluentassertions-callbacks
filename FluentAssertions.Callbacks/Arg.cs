namespace FluentAssertions.Callbacks;

public class Arg<T>(Predicate<T> predicate)
{
	public bool DoesMatch(T value)
		=> predicate(value);

	public override string ToString()
	{
		var type = typeof(T);
		return $"Predicate<{type}>";
	}

	public static implicit operator Arg<T>(T value)
		=> new ValueArg<T>(value);

	public static Arg<T> Is(Predicate<T> predicate)
		=> new(predicate);
}

public class ValueArg<T>(T value) : Arg<T>(x => Equals(x, value))
{
	public override string ToString()
		=> value?.ToString() ?? "null";
}
