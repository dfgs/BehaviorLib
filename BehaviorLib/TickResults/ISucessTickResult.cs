namespace BehaviorLib;

public interface ISucessTickResult<out TResult>:ITickResult<TResult>
{
	TResult Result
	{
		get;
	}
}