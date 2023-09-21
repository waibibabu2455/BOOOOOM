using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundStateMachine : StateMachine
{
    [SerializeField] RoundState[] states;

    private void Awake()
    {
        foreach (var state in states)
        {
            state.Initialize();
            stateTable.Add(state.GetType(), state);
        }
    }

    private void Start()
    {
        //SwitchOn();
    }
}
