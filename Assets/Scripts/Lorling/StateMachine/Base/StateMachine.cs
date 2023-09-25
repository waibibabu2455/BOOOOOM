using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    protected RoundState currentState;

    protected Dictionary<System.Type, RoundState> stateTable;

    private void Update()
    {
        currentState.Update();
    }

    protected void SwitchOn(RoundState newState)
    {
        currentState = newState;
        currentState.Enter();
    }

    protected void SwitchState(RoundState newState)
    {
        SwitchOn(newState);
    }

    public void SwitchState(System.Type newState)
    {
        SwitchState(stateTable[newState]);
    }
}
