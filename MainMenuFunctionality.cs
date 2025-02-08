using Godot;
using System;

public partial class MainMenu : Control
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready(){
	
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	//Basically says that everytime the ui_cancel input is pressed, which the key for is escape(esc),
	//set the visibility of the main menu screen to true, as well as call the GetTree.Paused to pause the game completely when esc is pressed.
	public override void _Process(double delta){
		if(Input.IsActionJustPressed("ui_cancel")){
			Visible = true; 
			GetTree().Paused = true;
			
		}
	}
	//Creates the functionality of the start button when pressed
	public void OnStartPressed(){
		GD.Print("Play Button Pressed");
		
		Visible = false;
		GetTree().Paused = false;
		
		var mainChildren = GetParent().GetChildren();
		
		foreach(var child in mainChildren){
			//If statement is so whenever the start button is pressed, it doesn't continously create a new node of scene2
			if(child.Name == "scene2")
				return;
		}
		
		//Once the button is clicked, it moves the current scene (main menu) to scene2(new current scene
		var gameScene = GD.Load<PackedScene>("res://scene2.tscn");
		var gameSceneNode = gameScene.Instantiate();
		GetParent().AddChild(gameSceneNode);
		
	}
	public void OnOptionsPressed(){
		Visible = false; 
		GetNode<Control>("res://Main/Options").Visible = true;
	}
	public void OnExitPressed(){
		GetTree().Quit();
	}
}
