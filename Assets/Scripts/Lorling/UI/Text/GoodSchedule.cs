using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class GoodSchedule : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    Image image;
    [SerializeField] Text text;

    private void Awake()
    {
        image = GetComponent<Image>();
    }

    private void Update()
    {
        image.fillAmount = (float)PlayerAttribute.Instance.goodSchedule / 10;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        text.gameObject.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        text.gameObject.SetActive(false);
    }
}
