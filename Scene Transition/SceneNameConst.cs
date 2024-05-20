public class SceneNameConst
{
    public const string FirstScene = "res://Test Scenes//FirstScene.tscn";
    public const string SecondScene = "res://Test Scenes//SecondScene.tscn";

    public enum SceneName {
        FirstScene = 0,
        SecondScene = 1,
    }

    public static string EnumToString(SceneName name) {
        switch (name) {
            case SceneName.FirstScene:
                return SceneNameConst.FirstScene;
            case SceneName.SecondScene:
                return SceneNameConst.SecondScene;
            default:
                return SceneNameConst.FirstScene;
        }
    }
}

