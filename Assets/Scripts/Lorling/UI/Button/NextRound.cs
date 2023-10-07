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
        if (GameObject.FindObjectsOfType<OrganButtonSRC>() != null)
        {
            foreach (OrganButtonSRC o in GameObject.FindObjectsOfType<OrganButtonSRC>())
            {
                o.gameObject.SetActive(false);
            }
        }
        stateManager.GetComponent<RoundStateMachine>().NextRound();
    }
}
