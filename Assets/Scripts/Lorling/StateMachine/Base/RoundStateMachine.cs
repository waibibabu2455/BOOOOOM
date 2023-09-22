using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundStateMachine : StateMachine
{
    [SerializeField] RoundState[] states;

    private void Awake()
    {
        stateTable = new Dictionary<System.Type, IState> (states.Length);

        foreach (var state in states)
        {
            state.Initialize(this);
            stateTable.Add(state.GetType(), state);
        }
    }

    private void Start()
    {
        SwitchOn(stateTable[typeof(RoundState_Initial)]);
    }

    public void NextRound()
    {
        currentState.Exit();
    }

    private void OnGUI()
    {
        GUI.Box(new Rect(400, 10, 250, 30), currentState.ToString());
    }
}
