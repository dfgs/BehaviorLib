using BehaviorLib.Controls;
using BehaviorLib.Executions;

namespace BehaviorLib;

public static class Behavior
{
    
    public static IBehavior<TContext,TResult> Sequence<TContext,TResult>(params IBehavior<TContext,TResult>[] Behaviors)
    {
        return new Sequence<TContext,TResult>(Behaviors);
    }

    public static IBehavior<TContext,TResult> Success<TContext,TResult>(Func<TContext,TResult> Function)
    {
        return new Success<TContext,TResult>(Function);
    }
    public static IBehavior<TContext,TResult> Fail<TContext,TResult>()
    {
        return new Fail<TContext,TResult>();
    }

}