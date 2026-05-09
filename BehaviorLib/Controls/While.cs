namespace BehaviorLib.Controls;

public class While<TContext,TResult>:Decorator<TContext,TResult>
{
	public override string Description=> "Until";

	private Func<TContext,long, bool> condition;
	
	public While(IBehavior<TContext, TResult> ChildBehavior,Func<TContext,long,bool> Condition):base(ChildBehavior)
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
				if (condition(Context,Ticks)) return new ProgressTickResult<TResult>();
				else return success;
			default:
				return childResult;
		}
	}
	
}