namespace BehaviorLib.Controls;

public class FallBack<TContext,TResult>:IControl<TContext,TResult>
{
    public string Description => "FallBack";
    
    
    
    public ITickResult<TResult> Tick(TContext Context, int Milliseconds)
    {
        throw new NotImplementedException();
    }
}