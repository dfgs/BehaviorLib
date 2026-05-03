namespace BehaviorLib.Controls;

public class Parallel<TContext,TResult>:IControl<TContext,TResult>
{
    public string Description => "Parallel";
    
    
    
    public ITickResult<TResult> Tick(TContext Context, int Milliseconds)
    {
        throw new NotImplementedException();
    }
}