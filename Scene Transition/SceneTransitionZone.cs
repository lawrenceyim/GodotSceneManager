using Godot;
using Godot.Collections;

public partial class SceneTransitionZone : Area2D
{
	[Export] private SceneNameConst.SceneName name;
	private SceneManager sceneManager;
	
	public override void _Ready()
	{
		BodyEntered += LoadScene;
		sceneManager = SceneManager.GetInstance();
	}

	// Overloaded method that is called after a delay to avoid crashes caused by
	// removing objects during a physics calculations
	private void LoadScene() {
		sceneManager.LoadSceneByName(SceneNameConst.EnumToString(name));
	}

	public void LoadScene(Node2D body) {
		if (body is Player) {
			CallDeferred("LoadScene");
		}
	}

}
