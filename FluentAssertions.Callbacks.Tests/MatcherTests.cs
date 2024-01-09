namespace FluentAssertions.Callbacks.Tests;

public class MatcherTests
{
	[Fact]
	public void SingleArgument()
	{
		var spy = new CallbackSpy<List<int>>();
		spy.Callback([42]);
		spy.Should().HaveBeenCalledWith(x => x.SequenceEqual([42]));
	}
	
	[Fact]
	public void TwoArguments()
	{
		var spy = new CallbackSpy<List<int>, List<int>>();
		spy.Callback([42], [43]);
		spy.Should().HaveBeenCalledWith(
				x => x.SequenceEqual([42]),
				x => x.SequenceEqual([43]));
	}
	
	[Fact]
	public void ThreeArguments()
	{
		var spy = new CallbackSpy<List<int>, List<int>, List<int>>();
		spy.Callback([42], [43], [44]);
		spy.Should().HaveBeenCalledWith(
				x => x.SequenceEqual([42]),
				x => x.SequenceEqual([43]),
				x => x.SequenceEqual([44]));
	}
	
	[Fact]
	public void FourArguments()
	{
		var spy = new CallbackSpy<List<int>, List<int>, List<int>, List<int>>();
		spy.Callback([42], [43], [44], [45]);
		spy.Should().HaveBeenCalledWith(
				x => x.SequenceEqual([42]),
				x => x.SequenceEqual([43]),
				x => x.SequenceEqual([44]),
				x => x.SequenceEqual([45]));
	}
	
	[Fact]
	public void FiveArguments()
	{
		var spy = new CallbackSpy<List<int>, List<int>, List<int>, List<int>, List<int>>();
		spy.Callback([42], [43], [44], [45], [46]);
		spy.Should().HaveBeenCalledWith(
				x => x.SequenceEqual([42]),
				x => x.SequenceEqual([43]),
				x => x.SequenceEqual([44]),
				x => x.SequenceEqual([45]),
				x => x.SequenceEqual([46]));
	}
	
	[Fact]
	public void SixArguments()
	{
		var spy = new CallbackSpy<List<int>, List<int>, List<int>, List<int>, List<int>, List<int>>();
		spy.Callback([42], [43], [44], [45], [46], [47]);
		spy.Should().HaveBeenCalledWith(
				x => x.SequenceEqual([42]),
				x => x.SequenceEqual([43]),
				x => x.SequenceEqual([44]),
				x => x.SequenceEqual([45]),
				x => x.SequenceEqual([46]),
				x => x.SequenceEqual([47]));
	}
	
	[Fact]
	public void SevenArguments()
	{
		var spy = new CallbackSpy<List<int>, List<int>, List<int>, List<int>, List<int>, List<int>, List<int>>();
		spy.Callback([42], [43], [44], [45], [46], [47], [48]);
		spy.Should().HaveBeenCalledWith(
				x => x.SequenceEqual([42]),
				x => x.SequenceEqual([43]),
				x => x.SequenceEqual([44]),
				x => x.SequenceEqual([45]),
				x => x.SequenceEqual([46]),
				x => x.SequenceEqual([47]),
				x => x.SequenceEqual([48]));
	}
	
	[Fact]
	public void EightArguments()
	{
		var spy = new CallbackSpy<List<int>, List<int>, List<int>, List<int>, List<int>, List<int>, List<int>, List<int>>();
		spy.Callback([42], [43], [44], [45], [46], [47], [48], [49]);
		spy.Should().HaveBeenCalledWith(
				x => x.SequenceEqual([42]),
				x => x.SequenceEqual([43]),
				x => x.SequenceEqual([44]),
				x => x.SequenceEqual([45]),
				x => x.SequenceEqual([46]),
				x => x.SequenceEqual([47]),
				x => x.SequenceEqual([48]),
				x => x.SequenceEqual([49]));
	}
	
	[Fact]
	public void NineArguments()
	{
		var spy = new CallbackSpy<List<int>, List<int>, List<int>, List<int>, List<int>, List<int>, List<int>, List<int>, List<int>>();
		spy.Callback([42], [43], [44], [45], [46], [47], [48], [49], [50]);
		spy.Should().HaveBeenCalledWith(
				x => x.SequenceEqual([42]),
				x => x.SequenceEqual([43]),
				x => x.SequenceEqual([44]),
				x => x.SequenceEqual([45]),
				x => x.SequenceEqual([46]),
				x => x.SequenceEqual([47]),
				x => x.SequenceEqual([48]),
				x => x.SequenceEqual([49]),
				x => x.SequenceEqual([50]));
	}
}
