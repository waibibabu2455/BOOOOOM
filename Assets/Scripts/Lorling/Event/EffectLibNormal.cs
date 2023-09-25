using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectLibNormal : EffectLib
{
    // Start is called before the first frame update
    public override void effect(int id)
    {
        switch (id)
        {

            case 0:
                return;
            case 1:
                Debug.Log("case1normal");
                return;
            case 2:
                Debug.Log("case2normal");
                return;
            case 3:
                Debug.Log("case3normal");
                return;
            case 4:
                Debug.Log("case4normal");
                return;
        }
    }
}
