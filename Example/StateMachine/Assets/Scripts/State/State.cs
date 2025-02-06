using UnityEngine;

public class State : MonoBehaviour
{
    protected new StateEnum name;
    protected State nextState;
    protected StateEvent stage = StateEvent.ENTER;
    public StateEvent Event => stage;

    public virtual void Enter()
    {
        Debug.Log("Enter");

        if (Input.GetKeyDown(KeyCode.A))
            stage = StateEvent.UPDATE;
    }
    public virtual void DoWork()
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
        if (stage == StateEvent.UPDATE) DoWork();
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
    COLOR, SCALE
}
public enum StateEvent
{
    ENTER, UPDATE, EXIT
}
