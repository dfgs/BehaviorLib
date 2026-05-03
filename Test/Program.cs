using BehaviorLib;
using BehaviorLib.Executions;

Console.WriteLine("Hello, World!");

object context="test";
IBehavior<object,bool> behavior;


behavior = Behavior.Sequence(Behavior.Success<object,bool>((context)=>true),Behavior.Fail<object,bool>());


var test = behavior.Select<object, bool, int>(resultIn => resultIn?1:0);
var t=test.Tick(context, 10);

var test2 = from resultIn in behavior
	select resultIn?1:0;

behavior.Tick(context,10);	