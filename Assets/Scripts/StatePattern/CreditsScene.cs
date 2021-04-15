using UnityEngine.SceneManagement;

public class CreditsScene : IGameScene
{
    private readonly string sceneName = "CreditsScene";

    public void SetScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
