using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    public StateEnum StartingState;
    [SerializeField] StateEvent stateEvent;
    State currentState;

    private void Awake()
    {
        currentState = GetState(StartingState);
    }
    private void Update()
    {        
        currentState = currentState.Process();
        stateEvent = currentState.Event;
    }
    private State GetState(StateEnum state)
    {
        if (state == StateEnum.COLOR) { return new ColorState(gameObject); } 
        
        return new ColorState(gameObject);
    }
}
