namespace BehaviorLib.Controls;

public class Parallel<TContext,TResult>:IControl<TContext,TResult>
{
    public string Description => "Parallel";
    
    
    
    public ITickResult<TResult> Tick(TContext Context, long Ticks)
    {
        throw new NotImplementedException();
    }
}