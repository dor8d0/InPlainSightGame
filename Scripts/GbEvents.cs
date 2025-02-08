using Godot;
using System;

public partial class GbEvents : Node
{
	public static Action TimerDone;
	public static Action DamageDone;

	public static void RaiseEvents()
	{
		TimerDone?.Invoke();
	}

}
