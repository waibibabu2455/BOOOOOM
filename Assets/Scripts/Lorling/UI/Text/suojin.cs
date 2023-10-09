using UnityEngine;
using UnityEngine.UI;

public class suojin : MonoBehaviour
{
    Text text;
    private void Awake()
    {
        text = GetComponent<Text>();
        string s = text.text;
        text.text = "\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0\u00A0" + s;
    }
}
