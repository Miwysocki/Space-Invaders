using UnityEngine.SceneManagement;

public class GameplayScene : IGameScene
{
    private readonly string sceneName = "GameplayScene";

    public void SetScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
