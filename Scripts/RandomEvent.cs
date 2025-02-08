using Godot;
using System;

public partial class RandomEvent : Node2D
{
	private Timer timer;
	[Export] public int lowerBound = 5;
	[Export] public int upperBound = 15;

	
	

	public override void _Ready()
	{
		timer = this.GetNode<Timer>("Timer");
		timer.Start();

	}
	
	void _on_timer_timeout(){
		int randomTime = new Random().Next(3, 9);
		timer.WaitTime = randomTime;
		GD.Print("Timer");
		GbEvents.TimerDone?.Invoke();
		timer.Start();
		
	}

	public void emit()
	{
		
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
