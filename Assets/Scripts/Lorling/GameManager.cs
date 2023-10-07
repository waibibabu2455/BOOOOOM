using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private void Update()
    {
        // 失败
        if(PlayerAttribute.Instance.number <= 0 || PlayerAttribute.Instance.score < 0)
        {
            SceneManager.LoadScene(2);
        }

        // 胜利
        if(PlayerAttribute.Instance.number > 40 || PlayerAttribute.Instance.evolutionCount >= 4)
        {
            SceneManager.LoadScene(3);
        }
    }
}
