using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectLib
{
    // Start is called before the first frame update
    public virtual void effect(int id) { 
        switch (id) { 
        
        case 0:
                return;
        case 1:
                Debug.Log("case1");
                return;
        case 2:
                Debug.Log("case2");
                return;
        }
    }
}
