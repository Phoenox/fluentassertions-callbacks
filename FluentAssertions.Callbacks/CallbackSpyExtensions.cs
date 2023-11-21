namespace FluentAssertions.Callbacks;

public static class CallbackSpyExtensions
{
	public static CallbackSpyAssertions Should(this CallbackSpy spy)
		=> new(spy);
	
	public static CallbackSpyAssertions<T> Should<T>(this CallbackSpy<T> spy)
		=> new(spy);
	
	public static CallbackSpyAssertions<T1, T2> Should<T1, T2>(this CallbackSpy<T1, T2> spy)
		=> new(spy);
	
	public static CallbackSpyAssertions<T1, T2, T3> Should<T1, T2, T3>(this CallbackSpy<T1, T2, T3> spy)
		=> new(spy);
	
	public static CallbackSpyAssertions<T1, T2, T3, T4> Should<T1, T2, T3, T4>(this CallbackSpy<T1, T2, T3, T4> spy)
		=> new(spy);
	
	public static CallbackSpyAssertions<T1, T2, T3, T4, T5> Should<T1, T2, T3, T4, T5>(this CallbackSpy<T1, T2, T3, T4, T5> spy)
		=> new(spy);
		
	public static CallbackSpyAssertions<T1, T2, T3, T4, T5, T6> Should<T1, T2, T3, T4, T5, T6>(this CallbackSpy<T1, T2, T3, T4, T5, T6> spy)
		=> new(spy);
			
	public static CallbackSpyAssertions<T1, T2, T3, T4, T5, T6, T7> Should<T1, T2, T3, T4, T5, T6, T7>(this CallbackSpy<T1, T2, T3, T4, T5, T6, T7> spy)
		=> new(spy);
				
	public static CallbackSpyAssertions<T1, T2, T3, T4, T5, T6, T7, T8> Should<T1, T2, T3, T4, T5, T6, T7, T8>(this CallbackSpy<T1, T2, T3, T4, T5, T6, T7, T8> spy)
		=> new(spy);
					
	public static CallbackSpyAssertions<T1, T2, T3, T4, T5, T6, T7, T8, T9> Should<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this CallbackSpy<T1, T2, T3, T4, T5, T6, T7, T8, T9> spy)
		=> new(spy);
}
