using Godot;
using System;
using System.Threading.Tasks;

public partial class GlobalEnemy : Node2D
{
	public Timer timer;
	[Export] public int lowerBound = 4;
	[Export] public int upperBound = 7;
	public override void _Ready()
	{
		GbEvents.TimerDone += StartDamageSequence;
		timer = this.GetNode<Timer>("DamageTimer");
		timer.WaitTime = lowerBound;
	}


	private async void StartDamageSequence()
	{
		GD.Print("Damage Sequence Started");
		await Task.Delay(3000);
		DoDamage();
	}

	private void DoDamage()
	{
		GD.Print("Doing Damage");
		timer.Start();
	}

	private void _on_damage_timer_timeout()
	{
		EndDamageSequence();
		int randomInt = new Random().Next(lowerBound, upperBound);
		timer.WaitTime = randomInt;
	}

	private void EndDamageSequence()
	{
		GD.Print("Damage Sequence ended");
		GbEvents.DamageDone?.Invoke();
	}


}
