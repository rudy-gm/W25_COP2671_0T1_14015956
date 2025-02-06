using UnityEngine;

public class ScaleState : State
{
    [SerializeField] float changeScaleTime = 0.5f;
    float currentTime;

    public override void Enter()
    {
        currentTime = changeScaleTime;
        transform.localScale = new Vector3(3, 3, 3);
        base.Enter();
    }
    public override void DoWork()
    {
        currentTime = currentTime - Time.deltaTime;
        if (currentTime <= 0f)
        {
            var scale = new Vector3(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
            transform.localScale = Vector3.one + scale;
            currentTime = changeScaleTime;
        }
        base.DoWork();
    }
    public override void Exit()
    {
        transform.localScale = Vector3.one;
        base.Exit();
    }
}
