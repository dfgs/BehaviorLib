namespace BehaviorLib;

public interface IBehavior<in TContext, out TResult>
{
    string Description
    {
        get;
    }

    ITickResult<TResult> Tick(TContext Context, int Milliseconds);
}