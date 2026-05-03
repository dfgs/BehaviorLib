namespace BehaviorLib;

public class SuccessTickResult<TResult>:ISucessTickResult<TResult>
{
	public TResult Result { get; init; }

	public SuccessTickResult(TResult Result)
	{
		this.Result = Result;
	}
}