using Godot;
using System;

public partial class MainMenu : CanvasLayer
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}
	public void OnPlayPressed(){
			GetTree().ChangeSceneToFile("res://Levels/testlevel.tscn");		
	}
	public void OnExitPressed(){
		GetTree().Quit();
	}
	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta){
	if(Input.IsActionJustPressed("ui_cancel")){
			Visible = true; 
			GetTree().Paused = true;
			GetTree().ChangeSceneToFile("res://MainMenu.cs");	
			}
	}
}
