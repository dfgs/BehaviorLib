namespace BehaviorLib.Executions;

public class Execute<TContext>:Action<TContext,bool>
{
	public override string Description =>"Execute";
	private System.Action<TContext,long> action;

	public Execute(System.Action<TContext,long> Action)
	{
		this.action = Action;
	}
	
	public override ITickResult<bool> Tick(TContext Context, long Ticks)
	{
		try
		{
			this.action(Context, Ticks);
			return new SuccessTickResult<bool>(true);
		}
		catch (Exception e)
		{
			return new FailTickResult<bool>();
		}
	}
}

public class Execute<TContext,TResult>:Action<TContext,TResult>
{
	public override string Description =>"Execute";
	private System.Func<TContext,long,TResult> function;

	public Execute(System.Func<TContext,long,TResult> Function)
	{
		this.function = Function;
	}
	
	public override ITickResult<TResult> Tick(TContext Context, long Ticks)
	{
		try
		{
			TResult result=this.function(Context, Ticks);
			return new SuccessTickResult<TResult>(result);
		}
		catch (Exception e)
		{
			return new FailTickResult<TResult>();
		}
	}
}