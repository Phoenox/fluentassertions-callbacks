namespace FluentAssertions.Callbacks.Tests;

public class CallbackTests
{
	[Fact]
	public void NoArguments()
	{
		var spy = new CallbackSpy();
		spy.Callback();
		spy.Should().HaveBeenCalled();
	}
	
	[Fact]
	public void SingleArgument()
	{
		var spy = new CallbackSpy<int>();
		spy.Callback(42);
		spy.Should().HaveBeenCalledWith(42);
	}

	[Fact]
	public void TwoArguments()
	{
		var spy = new CallbackSpy<int, int>();
		spy.Callback(42, 43);
		spy.Should().HaveBeenCalledWith(42, 43);
	}
	
	[Fact]
	public void ThreeArguments()
	{
		var spy = new CallbackSpy<int, int, int>();
		spy.Callback(42, 43, 44);
		spy.Should().HaveBeenCalledWith(42, 43, 44);
	}
	
	[Fact]
	public void FourArguments()
	{
		var spy = new CallbackSpy<int, int, int, int>();
		spy.Callback(42, 43, 44, 45);
		spy.Should().HaveBeenCalledWith(42, 43, 44, 45);
	}
	
	[Fact]
	public void FiveArguments()
	{
		var spy = new CallbackSpy<int, int, int, int, int>();
		spy.Callback(42, 43, 44, 45, 46);
		spy.Should().HaveBeenCalledWith(42, 43, 44, 45, 46);
	}
	
	[Fact]
	public void SixArguments()
	{
		var spy = new CallbackSpy<int, int, int, int, int, int>();
		spy.Callback(42, 43, 44, 45, 46, 47);
		spy.Should().HaveBeenCalledWith(42, 43, 44, 45, 46, 47);
	}
	
	[Fact]
	public void SevenArguments()
	{
		var spy = new CallbackSpy<int, int, int, int, int, int, int>();
		spy.Callback(42, 43, 44, 45, 46, 47, 48);
		spy.Should().HaveBeenCalledWith(42, 43, 44, 45, 46, 47, 48);
	}
	
	[Fact]
	public void EightArguments()
	{
		var spy = new CallbackSpy<int, int, int, int, int, int, int, int>();
		spy.Callback(42, 43, 44, 45, 46, 47, 48, 49);
		spy.Should().HaveBeenCalledWith(42, 43, 44, 45, 46, 47, 48, 49);
	}
	
	[Fact]
	public void NineArguments()
	{
		var spy = new CallbackSpy<int, int, int, int, int, int, int, int, int>();
		spy.Callback(42, 43, 44, 45, 46, 47, 48, 49, 50);
		spy.Should().HaveBeenCalledWith(42, 43, 44, 45, 46, 47, 48, 49, 50);
	}
}
