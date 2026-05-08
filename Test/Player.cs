using BehaviorLib;

namespace Test;

public class Player
{
	public ITickResult<int> LocateTreasure(long Ticks)
	{
		return new SuccessTickResult<int>(15);
	}
	public ITickResult<bool> MoveTo(long Ticks, int Position)
	{
		if (Ticks < 9) return new ProgressTickResult<bool>();
		else return new SuccessTickResult<bool>(true);
	}
	
}