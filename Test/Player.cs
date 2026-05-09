using BehaviorLib;

namespace Test;

public class Player
{
	public int Position { get; set; }
	
	public int LocateTreasure(long Ticks)
	{
		Console.WriteLine("Player: LocateTreasure({0})", Ticks);
		return 15;
	}
	public int MoveTo(long Ticks, int TargetPosition)
	{
		Console.WriteLine("Player: MoveTo({0},{1})", Ticks,TargetPosition);
		if (this.Position < TargetPosition) this.Position++;
		return this.Position;
	}
	
}