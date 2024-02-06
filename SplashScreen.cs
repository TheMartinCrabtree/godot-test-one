using Godot;
using System;

public partial class SplashScreen : ColorRect
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		// get instance of timer class, add callback to timeout fn
		// get scene_loader from auto loader, change to main menu
		GetNode<Timer>("Timer").Timeout += 
			() => GetNode<scene_loader>("/root/SceneLoader").ChangetoScene("main_menu.tscn");
	}
}
