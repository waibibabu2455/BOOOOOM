using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnterGame : ButtonUIBase
{
    [SerializeField] InputField inputField;

    public override void Click()
    {
        if(inputField.text.Length != 0) PlayerAttribute.Instance.raceName = inputField.text;
        //Debug.Log(PlayerAttribute.Instance.raceName.Length);
        SceneManager.LoadScene(1);
    }
}
