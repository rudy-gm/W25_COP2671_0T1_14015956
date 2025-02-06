using UnityEngine;

public class SelectState : State
{
    public SelectState(StateObject _stateObject) : base(_stateObject) { }

    public override void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hit, Mathf.Infinity, stateObject.gameBoardLayer))
        {
            if (hit.collider.TryGetComponent(out GameBoardPiece gameboardpiece))
            {
                gameboardpiece.HighlightOn();
                if (Input.GetMouseButtonDown(0))
                {
                    nextState = new ChoiceState(stateObject, gameboardpiece);
                    stage = EVENT.EXIT;                    
                }
            }
            if (gameboardpiece != null)
                gameboardpiece.HighlightOff();
        }
    }
}
