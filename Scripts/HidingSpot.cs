using Godot;
using System;

public partial class HidingSpot : Area2D
{
	public bool playerCanHide = false;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if(Input.IsActionJustPressed("Hide") && playerCanHide){
			Player player = GetTree().Root.GetNode<Player>("Player");
			player.isHiding = true;
		}
	}
	
	void _on_body_entered(Node2D body){
		if(body is Player player){
			playerCanHide = true;
		}
	}
	
	void _on_body_exited(Node2D body){
		if(body is Player player){
			playerCanHide = false;
		}
	}
}
