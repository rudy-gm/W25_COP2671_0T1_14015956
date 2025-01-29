using UnityEngine;

public class ChaseMode : State
{
    [SerializeField] Transform objectToChase;

    private void Awake()
    {
        base.state = StateMachine.StateEnum.Chase;
    }

    private void Update()
    {
        transform.position = objectToChase.position;
    }
}
