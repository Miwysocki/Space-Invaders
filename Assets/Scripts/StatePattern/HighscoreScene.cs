using UnityEngine.SceneManagement;

public class HighscoreScene : IGameScene
{
    private readonly string sceneName = "HighscoreScene";

    public void SetScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
