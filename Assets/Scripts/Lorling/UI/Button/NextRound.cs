using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextRound : ButtonUIBase
{
    GameObject stateManager;

    protected override void Awake()
    {
        base.Awake();
        stateManager = GameObject.Find("RoundManager");
    }

    public override void Click()
    {
        stateManager.GetComponent<RoundStateMachine>().NextRound();
    }
}
