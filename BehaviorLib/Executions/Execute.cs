namespace BehaviorLib.Executions;

public class Execute<TContext,TResult>:Action<TContext,TResult>
{
	public override string Description =>"Execute";
	private readonly Func<TContext,long,ITickResult<TResult>> function;

	public Execute(Func<TContext,long,ITickResult<TResult>> Function)
	{
		this.function = Function;
	}
	
	public override ITickResult<TResult> Tick(TContext Context, long Ticks)
	{
		return function(Context, Ticks);
	}
}