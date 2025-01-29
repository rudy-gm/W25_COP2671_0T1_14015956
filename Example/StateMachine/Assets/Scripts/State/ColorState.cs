using UnityEngine;

public class ColorState : State
{
    public ColorState(GameObject gameObject) : base(gameObject) { }

    MeshRenderer colorBlock;
    float changeColorTime = 0.5f;
    float currentTime;

    public override void Enter()
    {
        name = StateEnum.COLOR;
        colorBlock = transform.GetComponent<MeshRenderer>();
        colorBlock.material.SetColor("_BaseColor", Color.white);
        currentTime = changeColorTime;

        base.Enter();
    }
    public override void Update()
    {
        currentTime = currentTime - Time.deltaTime;
        if (currentTime <= 0f)
        {   
            var color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 1f);            
            colorBlock.material.SetColor("_BaseColor", color);
            currentTime = changeColorTime;
        }
        base.Update();
    }
    public override void Exit()
    {
        colorBlock.material.SetColor("_BaseColor", Color.gray);        
        base.Exit();
    }



}
