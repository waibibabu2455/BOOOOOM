using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonUIBase : UIBase
{
    protected Button button;

    protected virtual void Awake()
    {
        button = GetComponent<Button>();
    }

    public virtual void Click()
    {

    }
}
