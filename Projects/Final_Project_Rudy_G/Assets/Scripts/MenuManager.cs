using UnityEngine;
using UnityEngine.Rendering;

public class MenuManager : MonoBehaviour
{

    public GameObject menuPanel; // Reference to the menu panel GameObject
    public GameObject instructionsPanel; // Reference to the instructions panel GameObject
    public GameObject pauseMenuPanel; // Reference to the pause menu panel GameObject
    public GameObject pauseButton; // Reference to the pause button GameObject
    private GameManager gameManager; // Reference to the GameManager script
    private bool isPaused = false; // Flag to check if the game is paused

    void Start()
    {
        gameManager = FindFirstObjectByType<GameManager>();
        menuPanel.SetActive(true); // Show the menu panel at the start
        instructionsPanel.SetActive(false); // Hide the instructions panel at the start
        pauseMenuPanel.SetActive(false); // Hide the pause menu panel at the start
        pauseButton.SetActive(false); // Hide the pause button at the start
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && gameManager.isGameRunning)
        {
            TogglePause(); // Toggle pause when the Escape key is pressed
        }
    }

    public void StartGame()
    {
        Debug.Log("Game Started!");

        menuPanel.SetActive(false); 
        pauseButton.SetActive(true); // Show the pause button when the game starts

        gameManager.isGameRunning = true; 
        Time.timeScale = 1;
        gameManager.obstacleSpawner.enabled = true;
    }

    public void ShowInstructions()
    {
        Debug.Log("Showing instructions...");
        menuPanel.SetActive(false); // Hide the menu panel
        instructionsPanel.SetActive(true); // Show the instructions panel
    }

    public void GoBackToMenu()
    {

        Debug.Log("Going back to menu...");
        instructionsPanel.SetActive(false); // Hide the instructions panel
        menuPanel.SetActive(true); // Show the menu panel
    }

    public void TogglePause(){
        isPaused = !isPaused; // Toggle the pause state

        if(isPaused){
            PauseGame();
        }
        else{
            ResumeGame();
        }
    }

    public void PauseGame()
    {
        Debug.Log("Game Paused!");
        Time.timeScale = 0; // Pause the game
        pauseMenuPanel.SetActive(true); // Show the pause menu panel
    }

    public void ResumeGame()
    {
        Debug.Log("Game Resumed!");
        Time.timeScale = 1; // Resume the game
        pauseMenuPanel.SetActive(false); // Hide the pause menu panel
    }

    public void RestartGame()
    {
        Debug.Log("Restarting game...");
        // Reset the game state and reload the scene
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainScene");
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
