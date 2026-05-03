namespace BehaviorLib.Controls;

public interface IControl<in TContext, out TResult>:IBehavior<TContext, TResult>
{
    
}