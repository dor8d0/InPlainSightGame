using Godot;
using System;

public partial class RandomEvent : Node2D
{
	public Timer cooldownTimer;
	[Export] public int lowerBound = 5;
	[Export] public int upperBound = 15;

	public override void _Ready()
	{
		cooldownTimer = this.GetNode<Timer>("CooldownTimer");
		cooldownTimer.WaitTime = 3;
		GbEvents.DamageDone += RestartCooldownTimer;
	}
	
	private void _on_cooldown_timer_timeout(){
		int randomTime = new Random().Next(lowerBound, upperBound);
		cooldownTimer.WaitTime = randomTime;
		GD.Print("Cooldown Timer Ended");
		GbEvents.TimerDone?.Invoke();
		
	}

	private void RestartCooldownTimer()
	{
		GD.Print("Damage Done, Restart Cooldown Timer");
		cooldownTimer.Start();
	}

}
