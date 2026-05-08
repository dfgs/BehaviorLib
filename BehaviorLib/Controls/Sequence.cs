namespace BehaviorLib.Controls;

public class Sequence<TContext,TResult>: IControl<TContext,TResult>
{
    public string Description => "Sequence";
   

    private IBehavior<TContext,TResult>[] behaviors ;

    public Sequence(params IBehavior<TContext,TResult>[] Behaviors)
    {
        this.behaviors = Behaviors;
    }
    public ITickResult<TResult> Tick(TContext Context, long Ticks)
    {
        throw new NotImplementedException();
    }

}