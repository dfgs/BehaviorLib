namespace BehaviorLib.Executions;

public class SelectBehavior<TContext,TResultIn,TResultOut>:Action<TContext,TResultOut>
{
	public override string Description =>"Select";
	private readonly IBehavior<TContext, TResultIn> behaviorIn;
	private readonly Func<TResultIn,TResultOut> selector;
	
	public SelectBehavior(IBehavior<TContext,TResultIn> BehaviorIn,Func<TResultIn,TResultOut> Selector)
	{
		this.behaviorIn = BehaviorIn;
		this.selector = Selector;
	}

	public override ITickResult<TResultOut> Tick(TContext Context, long Ticks)
	{
		ITickResult<TResultIn> resultIn;
			
		resultIn = behaviorIn.Tick(Context, Ticks);
		switch(resultIn)
		{
			case SuccessTickResult<TResultIn> successResult:
				return new SuccessTickResult<TResultOut>(selector(successResult.Result));
			case ProgressTickResult<TResultIn>:
				return new ProgressTickResult<TResultOut>();
		}
		return new FailTickResult<TResultOut>();
	}
	
}