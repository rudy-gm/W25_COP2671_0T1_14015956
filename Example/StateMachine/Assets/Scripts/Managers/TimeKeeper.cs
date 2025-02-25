using UnityEditor;
using UnityEngine;
using UnityEngine.Events;

public class TimeKeeper : SingletonMonoBehaviour<TimeKeeper>
{
    public UnityEvent OnStart;
    public UnityEvent OnStop;
    public UnityEvent OnPause;
    public UnityEvent OnResume;
    public UnityEvent OnCountdownStart;
    public UnityEvent OnCountdownEnd;
    public UnityEvent<float> OnChange;
    public UnityEvent OnQuit;


    [SerializeField] float countTimeRemaining;
    float elaspedTime = 0f;
    float countdownElapsedTime = 0;
    bool isRunning
    {
        get { return Time.timeScale == 1f; }
    }

    private void Start()
    {
        Time.timeScale = 0f;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {            
            if (isRunning)
            {
                TimerPause();
            }            
        }
    }

    public void TimerStart() 
    {
        OnStart.Invoke();
        Time.timeScale = 1f;
    }
    public void TimerStop()
    {
        Time.timeScale = 0f;
        OnStop.Invoke();
    }
    public void TimerPause()
    {
        OnPause.Invoke();
        Time.timeScale = 0f;
    }
    public void TimerResume()
    {
        Time.timeScale = 1f;
        OnResume.Invoke();
    }
    public void TimerQuit()
    {
        TimerStop();
        OnQuit.Invoke();

        EditorApplication.ExitPlaymode();
        Application.Quit();
    }
}
