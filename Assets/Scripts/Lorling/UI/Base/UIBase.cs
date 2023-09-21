using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// UI基类
/// </summary>
public class UIBase : MonoBehaviour
{
    // 显示
    public virtual void Show()
    {
        gameObject.SetActive(true);
    }

    // 隐藏
    public virtual void Hide()
    {
        gameObject.SetActive(false);
    }

    // 关闭
    public virtual void Close()
    {
        Destroy(gameObject);
    }
}
