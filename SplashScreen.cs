using Godot;
using System;

public partial class SplashScreen : ColorRect
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		GetNode<Timer>("Timer").Timeout += 
			() => GetNode<scene_loader>("/root/SceneLoader").ChangetoScene("main_menu.tscn");
	}
}
