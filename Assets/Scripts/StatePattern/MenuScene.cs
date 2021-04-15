using UnityEngine.SceneManagement;

public class MenuScene : IGameScene
{
    private readonly string sceneName = "MenuScene";

    public void SetScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
