using Godot;
using System;

public partial class RandomEvent : Node2D
{
	private Timer timer;
	public override void _Ready()
	{
		timer = this.GetNode<Timer>("Timer");
		timer.Start();
	}
	
	void _on_timer_timeout(){
		GD.Print("Timer");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
