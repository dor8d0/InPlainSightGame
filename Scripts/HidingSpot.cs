using Godot;
using System;

public partial class HidingSpot : Area2D
{
	public bool playerCanHide = false;
	public Player player;
	Sprite2D awaitingHide;
	Sprite2D hiding;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		player = GetParent().GetNode<Player>("Player");
		awaitingHide = this.GetNode<Sprite2D>("AwaitingHide");
		hiding = this.GetNode<Sprite2D>("Hiding");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if(Input.IsActionJustPressed("Hide") && playerCanHide){
			if(!player.isHiding){
				player.isHiding = true;
				player.GetNode<Node2D>("Sprite2D").Visible = false;
				hiding.Visible = true;
				awaitingHide.Visible = false;
			}
			else{
				player.isHiding = false;
				player.GetNode<Node2D>("Sprite2D").Visible = true;
				hiding.Visible = false;
				awaitingHide.Visible = true;
			}
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
