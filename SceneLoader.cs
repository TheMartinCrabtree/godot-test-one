using Godot;
using System;

// just a quick and dirty scene change
public partial class scene_loader : Node
{
	[Export] private string _sceneFolder;
	public void ChangetoScene(string sceneName){
		string f = _sceneFolder == "" ? "" : $"{_sceneFolder}/";
		GetTree().ChangeSceneToFile($"res://{f}{sceneName}");
	}
}
