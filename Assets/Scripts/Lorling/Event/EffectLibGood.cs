using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectLibGood : EffectLib
{
    // Start is called before the first frame update
    public void effect(int id)
    {
        switch (id)
        {

            case 0:
                return;
            case 1:
                Debug.Log("case1");
                return;
            case 2:
                Debug.Log("case2");
                return;
            case 3:
                Debug.Log("case3");
                return;
            case 4:
                Debug.Log("case4");
                return;
        }
    }
}
