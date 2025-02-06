using System.Collections;
using UnityEngine;

public class PlayerPiece : MonoBehaviour
{
    enum PlayerType
    {
        None, King, Queen, Rook, Bishop, Pawn
    }    
    [SerializeField] PlayerType playerType;
    [SerializeField] StateObject stateObject;    
    [SerializeField] private Material outlineMaterial;
    [SerializeField] private Renderer renderer;
    [SerializeField] bool isHovered;

    public Movable MoveAction;

    State state;
    public GameBoard GameBoard;
    private Material originalMaterial;
    private void Awake()
    {
        renderer = GetComponentInChildren<MeshRenderer>();
        originalMaterial = renderer.material;
        stateObject.player = this;

        state = new IdleState(stateObject);
        MoveAction = GetComponent<Movable>();
        
    }
    private void Update()
    {
        state = state.Process();
    }
    public void HighlightOn()
    {
        if (!isHovered)
        {
            if (outlineMaterial != null)
            {
                renderer.material = outlineMaterial;
            }
            isHovered = true;            
        }
    }
    public void HighlightOff()
    {
        if (isHovered)
        {
            if (originalMaterial != null)
            {
                renderer.material = originalMaterial;                
            }
            isHovered = false;
        }
    }
}
