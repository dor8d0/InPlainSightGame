using Godot;
using System;

public partial class GlobalEnemy : Node2D
{

	public override void _Ready()
	{
		GbEvents.TimerDone += Alert;
	}


	public static void Alert()
	{
		GD.Print("Alerted");
	}


}
