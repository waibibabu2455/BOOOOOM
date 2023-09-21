using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// UI����
/// </summary>
public class UIBase : MonoBehaviour
{
    // ��ʾ
    public virtual void Show()
    {
        gameObject.SetActive(true);
    }

    // ����
    public virtual void Hide()
    {
        gameObject.SetActive(false);
    }

    // �ر�
    public virtual void Close()
    {
        Destroy(gameObject);
    }
}
