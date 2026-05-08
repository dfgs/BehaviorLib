namespace BehaviorLib.Controls;

public class FallBack<TContext,TResult>:IControl<TContext,TResult>
{
    public string Description => "FallBack";
    
    
    
    public ITickResult<TResult> Tick(TContext Context, long Ticks)
    {
        throw new NotImplementedException();
    }
}