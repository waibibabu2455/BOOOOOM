using UnityEngine.SceneManagement;

public class GameRestart : ButtonUIBase
{
    public override void Click()
    {
        SceneManager.LoadScene(0);
        PlayerAttribute.Instance.Reset();
    }
}
