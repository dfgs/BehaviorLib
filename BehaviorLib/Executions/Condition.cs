namespace BehaviorLib.Executions;

public abstract class Condition<TContext,TResult>:IExecution<TContext,TResult>
{
    public abstract string Description
    {
        get;
    }
    public abstract ITickResult<TResult> Tick(TContext Context, long Ticks);

}