namespace BehaviorLib.Executions;

public class ProjectBehavior<TContext,TResultIn,TResultOut>:Action<TContext,TResultOut>
{
	public override string Description =>"Select";
	private IBehavior<TContext, TResultIn> behaviorIn;
	private Func<TResultIn, IBehavior<TContext,TResultOut>> projection ;
	
	public ProjectBehavior(IBehavior<TContext,TResultIn> BehaviorIn,Func<TResultIn, IBehavior<TContext,TResultOut>> Projection)
	{
		this.behaviorIn = BehaviorIn;
		this.projection = Projection;
	}

	public override ITickResult<TResultOut> Tick(TContext Context, long Ticks)
	{
		ITickResult<TResultIn> resultIn;

		resultIn = behaviorIn.Tick(Context,Ticks);
		switch(resultIn)
		{
			case SuccessTickResult<TResultIn> successResult:
				return projection(successResult.Result).Tick(Context, Ticks);
			case ProgressTickResult<TResultIn>:
				return new ProgressTickResult<TResultOut>();
		}
		return new FailTickResult<TResultOut>();
		
	}
	
}