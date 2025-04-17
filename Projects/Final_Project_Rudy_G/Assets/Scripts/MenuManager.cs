using UnityEngine;

public class MenuManager : MonoBehaviour
{

    public GameObject menuPanel; // Reference to the menu panel GameObject
    private GameManager gameManager; // Reference to the GameManager script

    void Start()
    {
        gameManager = FindFirstObjectByType<GameManager>();
    }

    public void StartGame()
    {
        Debug.Log("Game Started!");

        menuPanel.SetActive(false); 

        gameManager.isGameRunning = true; 
        Time.timeScale = 1;
        gameManager.obstacleSpawner.enabled = true;
    }

    public void ShowInstructions()
    {
        // Load the instructions scene (assuming it's named "InstructionsScene")
        UnityEngine.SceneManagement.SceneManager.LoadScene("InstructionsScene");
    }

    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        // Quit the application
        Application.Quit();

        // If running in the editor, stop playing the scene
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
}
