using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    public enum StateEnum
    {
        None,
        Chase,
        Guard,
        Patrol
    }

    private StateEnum state;

    List<State> _stateObjects;

    private void Start()
    {
        var t = FindObjectsByType<State>(FindObjectsSortMode.None);
        _stateObjects = new List<State>(t);
    }


}
