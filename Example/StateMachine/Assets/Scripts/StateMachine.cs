using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    [SerializeField] List<State> states;
    [SerializeField] State runningState;
    int index = 0;

    private void Awake()
    {
        //states = new List<State>(FindObjectsByType<State>(FindObjectsSortMode.None));
    }
    private void Update()
    {   
        runningState = states[index].Process();
        if (runningState.Event == StateEvent.EXIT)
        {
            //index = ++index % states.Count;

            index = index + 1;
            if (index >= states.Count)
            {
                index = 0;
            }
            runningState = states[index];
        }
    }
}
