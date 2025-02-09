using Godot;
using System;

public partial class LeftWall : RigidBody2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	
	void _on_body_entered(Node body){
		if(body is Enemy enemy){
			enemy.QueueFree();
		}
	}
}
