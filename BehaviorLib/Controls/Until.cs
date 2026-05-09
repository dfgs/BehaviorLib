namespace BehaviorLib.Controls;

public class Until<TContext,TResult>:Decorator<TContext,TResult>
{
	public override string Description=> "Until";

	private Func<TContext,long, bool> condition;
	
	public Until(IBehavior<TContext, TResult> ChildBehavior,Func<TContext,long,bool> Condition):base(ChildBehavior)
	{
		this.condition = Condition;
	}
	
	public override ITickResult<TResult> Tick(TContext Context, long Ticks)
	{
		ITickResult<TResult> childResult;
		childResult = ChildBehavior.Tick(Context, Ticks);
		switch (childResult)
		{
			case ISucessTickResult<TResult> success:
				if (condition(Context,Ticks)) return success;
				else return new ProgressTickResult<TResult>();
			default:
				return childResult;
		}
	}
	
}