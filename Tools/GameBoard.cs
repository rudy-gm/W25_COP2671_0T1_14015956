using UnityEngine;

public class GameBoard : MonoBehaviour
{
    [SerializeField] GameBoardPiece gameBoardPrefab;
    [SerializeField] LayerMask gameBoardPieceLayer;
    [SerializeField] int gameBoardSize = 5;

    GameBoardPiece[,] gameBoard;
    public PlayerPiece selectedPlayerPiece;

    private void Awake()
    {
        gameBoard = new GameBoardPiece[gameBoardSize, gameBoardSize];
        DrawGameBoard();
    }
    private void DrawGameBoard()
    {
        for (int x = 0; x < gameBoardSize; x++)
        {
            for (int z = 0; z < gameBoardSize; z++)
            {
                var gamePiece = Instantiate(gameBoardPrefab, new Vector3(x, -0.5f, z), Quaternion.identity, transform);
                gamePiece.name = $"GameBoardPiece [{x},{z}]";
                gamePiece.gridX = x;
                gamePiece.gridZ = z;

                gameBoard[x, z] = gamePiece;
                gamePiece.RegisterGamePiece(x, z, this);
            }
        }
    }    
}
