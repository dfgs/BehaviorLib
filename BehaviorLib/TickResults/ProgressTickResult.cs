namespace BehaviorLib;

public class ProgressTickResult<TResult>:IProgressTickResult<TResult>
{
	public override string ToString()
	{
		return "In progress";
	}
}