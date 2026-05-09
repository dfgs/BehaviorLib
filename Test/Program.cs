using BehaviorLib;
using BehaviorLib.Executions;
using Test;

IBehavior<Player,bool> behavior;

var LocateTreasure = Behavior.Execute<Player, int>((Player, Ticks) => Player.LocateTreasure(Ticks));

behavior = from position in LocateTreasure
			from result in Behavior.Execute<Player>((Player,Ticks)=>Player.MoveTo(Ticks, position)).While((Player,Tick)=>Player.Position!=position)
			select result;


Console.WriteLine("Start");

Player player = new Player();
ITickResult<bool> r;
do
{
	r = behavior.Tick(player, 1);
	Console.WriteLine("{0}", r);
	if (!(r is ProgressTickResult<bool>)) break;
} while (true);
	
