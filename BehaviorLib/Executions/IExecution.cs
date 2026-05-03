namespace BehaviorLib.Executions;

public interface IExecution<in TContext,out TResult>:IBehavior<TContext,TResult>
{
    
}