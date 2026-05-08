namespace BehaviorLib.Executions;

public class Success<TContext,TResult>:Action<TContext,TResult>
{
	public override string Description =>"Success";
	private readonly Func<TContext,TResult> function;

	public Success(Func<TContext,TResult> Function)
	{
		this.function = Function;
	}
	
	public override ITickResult<TResult> Tick(TContext Context, long Ticks)
	{
		return new SuccessTickResult<TResult>(function(Context));
	}
}