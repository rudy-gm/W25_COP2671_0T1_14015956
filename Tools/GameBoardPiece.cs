using System.Collections;
using UnityEngine;

public class GameBoardPiece : MonoBehaviour
{
    [SerializeField] LayerMask layer;
    [SerializeField] Color oddColor = Color.black;
    [SerializeField] Color evenColor = Color.white;
    [SerializeField] Color hightlightColor = Color.cyan;
    [SerializeField] Texture highlightTexture;
    [SerializeField] float fadeSpeed = 0.5f;

    [SerializeField] PlayerPiece playerPiece;

    [SerializeField] bool flipColors;
    bool isHighlighted = false;
    public int gridX;
    public int gridZ;
    GameBoard gameBoard;
    MeshRenderer _renderer;

    private void Awake()
    {
        _renderer = gameObject.GetComponent<MeshRenderer>();
        _renderer.material.SetColor("_OutlineColor", hightlightColor);

        flipColors = Mathf.Abs(transform.position.z) % 2 == 0;

        var index = transform.position.x;
        if (Mathf.Abs(index) % 2 == (flipColors ? 1 : 0))
            _renderer.material.color = evenColor;
        else
            _renderer.material.color = oddColor;
    }
    private void OnCollisionEnter(Collision collision)
    {        
        if (collision.collider.TryGetComponent(out PlayerPiece playerPiece))
        {
            this.playerPiece = playerPiece;
            playerPiece.GameBoard = gameBoard;
        }
    }
    public void RegisterGamePiece(int x, int z, GameBoard board)
    {
        gridX = x;
        gridZ = z;
        gameBoard = board;
    }
    public void HighlightOn()
    {
        _renderer.material.SetTexture("_MainTex", highlightTexture);
        isHighlighted = true;
    }
    public void HighlightOff()
    {
        if (isHighlighted)
        {
            StartCoroutine(HighlightOffCo(fadeSpeed));
        }
    }
    public IEnumerator HighlightOffCo(float delay)
    {
        yield return new WaitForSeconds(delay);
        _renderer.material.SetTexture("_MainTex", null);
        isHighlighted = false;
    }
}
