using Godot;
using System;

public partial class GameOver : CanvasLayer
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}
	public void OnRetryPressed(){
	GetTree().ChangeSceneToFile("res://Levels/testlevel.tscn");		
		
	} 
	public void OnQuitPressed(){
		GetTree().Quit();
	}
		
	
	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
