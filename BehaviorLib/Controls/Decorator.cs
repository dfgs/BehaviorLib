namespace BehaviorLib.Controls;

public abstract class Decorator<TContext,TResult>:IControl<TContext,TResult>
{
    public abstract string Description
    {
        get;
    }
    public abstract ITickResult<TResult> Tick(TContext Context, long Ticks);

    
}