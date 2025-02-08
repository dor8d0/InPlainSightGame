using Godot;
using System;

public partial class DetectPlayer : Area2D
{
	public bool touchingPlayer = false;
	public Player player;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		player = GetParent().GetParent().GetNode<Player>("Player");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (touchingPlayer && !player.isHiding){
			//GD.Print("player spotted");
		}
	}
	
	public void _on_body_entered(Node2D body){
		if (body is Player){
			//GD.Print("touching player");
			touchingPlayer = true;
		}
	}
	public void _on_body_exited(Node2D body){
		if (body is Player){
			//GD.Print("no longer touching player");
			touchingPlayer = false;
		}
	}
}
