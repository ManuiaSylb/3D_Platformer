using UnityEngine;
using UnityEngine.SceneManagement;

public class InGame : MonoBehaviour
{
    public GameObject Canvas_0;
    public GameObject Canvas_1;
    public GameObject Canvas_2;
    public AudioSource ClickSound;

    private float chrono;

    private void Start()
    {
        ClickSound.Play();
        Time.timeScale = 1f;
        Canvas_0.SetActive(true);
        Canvas_1.SetActive(false);
        Canvas_2.SetActive(false);
        chrono = 0f;
    }

    private void Update()
    {
        if (Time.timeScale > 0f)
        {   
            chrono += Time.deltaTime;
        }
    }

    public void ShowPauseMenu()
    {
        Canvas_0.SetActive(false);
        Canvas_1.SetActive(true);
        Time.timeScale = 0f;
        ClickSound.Play();
    }

    public void ResumeGame()
    {
        Canvas_1.SetActive(false);
        Canvas_0.SetActive(true);
        Time.timeScale = 1f;
        ClickSound.Play();
    }

    public void ShowSettingsMenu()
    {
        Canvas_1.SetActive(false);
        Canvas_2.SetActive(true);
        ClickSound.Play();
    }

    public void CloseSettingsMenu()
    {
        Canvas_2.SetActive(false);
        Canvas_1.SetActive(true);
        ClickSound.Play();
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void GoToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }

    public void Next()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);  
    }

    public void LevelsMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(1);
    }

    public float GetElapsedTime()
    {
        return chrono;
    }
}