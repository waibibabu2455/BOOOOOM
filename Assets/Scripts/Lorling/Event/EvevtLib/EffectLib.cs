using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectLib
{
    RoundStateMachine RoundStateMachine;
    public EffectLib(RoundStateMachine roundStateMachine) { 
        this.RoundStateMachine = roundStateMachine;
    }
    // Start is called before the first frame update
    public virtual void effect(int id) { 
    }
}
