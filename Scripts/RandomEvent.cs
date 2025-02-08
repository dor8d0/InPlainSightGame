using Godot;
using System;

public partial class RandomEvent : Node2D
{
	public Timer QTEtimer;
	public Timer cooldownTimer;
	[Export] public int lowerBound = 5;
	[Export] public int upperBound = 15;
	public bool isActive = false;
	Player player;
	
	public override void _Ready()
	{
		player = GetParent().GetNode<Player>("Player");
		QTEtimer = this.GetNode<Timer>("QTE_Timer");
		cooldownTimer = this.GetNode<Timer>("CooldownTimer");
		cooldownTimer.WaitTime = 8;
		cooldownTimer.Start();
	}
	
	void _on_QTEtimer_timeout(){
		isActive = false;
		int randomTime = new Random().Next(3, 9);
		cooldownTimer.WaitTime = randomTime;
		GD.Print("Cooldown Timer started");
		cooldownTimer.Start();
	}
	void _on_cooldown_timer_timeout(){
		isActive = true;
		int randomTime = new Random().Next(3, 9);
		QTEtimer.WaitTime = randomTime;
		GD.Print("QTE Timer Started");
		QTEtimer.Start();
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if(isActive && !player.isHiding){
			GD.Print("QTE spotted player");
		}
	}
}
