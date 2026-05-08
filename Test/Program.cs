using BehaviorLib;
using BehaviorLib.Executions;
using Test;

IBehavior<Player,bool> behavior;




behavior = from position in Behavior.Execute<Player,int>((Player,Ticks)=> Player.LocateTreasure(Ticks))
			from result in Behavior.Execute<Player,bool>((Player,Ticks)=>Player.MoveTo(Ticks, position))
			select result;


Console.WriteLine("Start");

Player player = new Player();
ITickResult<bool> r;
for (long tick = 0; tick < 10; tick++)
{
	r = behavior.Tick(player, tick);
	Console.WriteLine("{0}",r);
}
	
