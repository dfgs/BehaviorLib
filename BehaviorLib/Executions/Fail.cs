namespace BehaviorLib.Executions;

public class Fail<TContext,TResult>:Action<TContext,TResult>
{
	public override string Description =>"Fail";
	
	public Fail()
	{
		
	}
	
	public override ITickResult<TResult> Tick(TContext Context, int Milliseconds)
	{
		return new FailTickResult<TResult>();
	}
}