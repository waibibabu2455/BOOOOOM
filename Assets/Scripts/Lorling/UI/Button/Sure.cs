using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Sure : ButtonUIBase
{
    Action action;

    public override void Click()
    {
        if(action != null)
        {
            action();
            action = null;
        }
    }

    public void SetAction(Action action)
    {
        this.action = action;
    }
}
