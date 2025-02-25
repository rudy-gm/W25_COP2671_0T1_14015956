using UnityEngine;

public class MenuLoader : MonoBehaviour
{
    [SerializeField] MenuItem OpenMenu;
    [SerializeField] MenuItem PauseMenu;
    [SerializeField] MenuItem GameOverMenu;

    private void Start()
    {
        PauseMenu.gameObject.SetActive(false);
        GameOverMenu.gameObject.SetActive(false);
        OpenMenu.gameObject.SetActive(true);
    }
}
