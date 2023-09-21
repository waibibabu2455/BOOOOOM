using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextUIBase : UIBase
{
    protected Text text;

    protected virtual void Awake()
    {
        text = GetComponent<Text>();
    }

    protected virtual void Update()
    {
        DateUpdate();
    }

    protected virtual void DateUpdate()
    {
        
    }
}
