using System.Collections;
using UnityEngine;

public class IdleState : State
{   
    bool isHover = false;

    public IdleState(StateObject _stateObject) : base(_stateObject) { }
        
    public override void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hit, Mathf.Infinity, stateObject.playerLayer))
        {
            if (hit.collider.name == stateObject.player.name)
            {
                stateObject.player.HighlightOn();

                if (Input.GetMouseButtonDown(0))
                {                    
                    nextState = new SelectState(stateObject);
                    stage = EVENT.EXIT;
                }
            }
        }
        else
        {
            stateObject.player.HighlightOff();
        }        
    }
    public override void Exit()
    {
        stateObject.player.HighlightOff();
        base.Exit();
    }
    //public IEnumerator DeselectPlayerPiece(float delay = 0f)
    //{
    //    if (isHover)
    //    {
    //        yield return new WaitForSeconds(delay);
    //        if (stateObject.originalMaterial != null)
    //        {
    //            stateObject.renderer.material = stateObject.originalMaterial;
    //        }
    //        isHover = false;
    //    }
    //    yield return null;
    //}
}
