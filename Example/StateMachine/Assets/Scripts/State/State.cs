using System.Collections.Generic;
using UnityEngine;

public class State
{
    protected StateEnum name;
    protected State nextState;
    protected StateEvent stage;
    protected Transform transform;
    public StateEvent Event => stage;


    public State(GameObject gameObject)
    {
        transform = gameObject.transform;
        stage = StateEvent.ENTER;
    }

    public virtual void Enter()
    {
        Debug.Log("Enter");

        if (Input.GetKeyDown(KeyCode.A))
            stage = StateEvent.UPDATE;
    }
    public virtual void Update()
    {
        Debug.Log("Update");
        if (Input.GetKeyDown(KeyCode.B))
            stage = StateEvent.EXIT;
        else
            stage = StateEvent.UPDATE;
    }
    public virtual void Exit()
    {
        Debug.Log("Exit");

        if (Input.GetKeyDown(KeyCode.C))
            stage = StateEvent.ENTER;
        else
            stage = StateEvent.EXIT;
    }

    public State Process()
    {
        if (stage == StateEvent.ENTER) Enter();
        if (stage == StateEvent.UPDATE) Update();
        if (stage == StateEvent.EXIT)
        {
            Exit();  
            if (nextState != null) 
                return nextState;
        }
        return this;
    }
}
public enum StateEnum
{
    COLOR
}
public enum StateEvent
{
    ENTER, UPDATE, EXIT
}
