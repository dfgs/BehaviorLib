using System.Net;
using BehaviorLib.Executions;

namespace BehaviorLib;

public static class ParserExtensions
{
	#region Linq extensions
	public static IBehavior<TContext, TResultOut> Select<TContext,TResultIn,TResultOut>(this IBehavior<TContext,TResultIn> BehaviorIn, Func<TResultIn,TResultOut> Selector)
	{
		if (BehaviorIn == null) throw new ArgumentNullException(nameof(BehaviorIn));
		if (Selector == null) throw new ArgumentNullException(nameof(Selector));

		return new SelectBehavior<TContext, TResultIn,TResultOut>(BehaviorIn, Selector);
	}
	
	
	// Single_Single
	public static IBehavior<TContext, TResultOut> SelectMany<TContext, TResultIn, U, TResultOut>(
	   this IBehavior<TContext,TResultIn> BehaviorIn,
	   Func<TResultIn, IBehavior<TContext,U>> Selector,
	   Func<TResultIn, U, TResultOut> Projector)
	{
		if (BehaviorIn == null) throw new ArgumentNullException(nameof(BehaviorIn));
		if (Selector == null) throw new ArgumentNullException(nameof(Selector));
		if (Projector == null) throw new ArgumentNullException(nameof(Projector));

		return BehaviorIn.Then(t => Selector(t).Select(u => Projector(t,  u  )));
	}


	
	// Single_Single
	public static IBehavior<TContext,TResultOut> Then<TContext,TResultIn, TResultOut>(this IBehavior<TContext,TResultIn> BehaviorIn, Func<TResultIn, IBehavior<TContext,TResultOut>> Projection)
	{
		if (BehaviorIn == null) throw new ArgumentNullException(nameof(BehaviorIn));
		if (Projection == null) throw new ArgumentNullException(nameof(Projection));

		return new ProjectBehavior<TContext,TResultIn,TResultOut>(BehaviorIn, Projection);
	}

	
	#endregion


}
