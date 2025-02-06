public class ChoiceState : State
{
    private readonly GameBoardPiece boardPiece;

    public ChoiceState(StateObject _stateObject, GameBoardPiece _boardPiece) : base(_stateObject)
    {
        boardPiece = _boardPiece;
    }

    public override void Enter()
    {
        stateObject.player.MoveAction.MoveToPosition(boardPiece.transform.position);
        nextState = new IdleState(stateObject);
        stage = EVENT.EXIT;
    }    
}
