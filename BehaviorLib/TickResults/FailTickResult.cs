namespace BehaviorLib;

public class FailTickResult<TResult>:IFailTickResult<TResult>
{
	public override string ToString()
	{
		return "Fail";
	}
}