using UnityEngine;
using UnityEngine.SceneManagement;

public class InGame : MonoBehaviour
{
    public GameObject Canvas_0;
    public GameObject Canvas_1;
    public GameObject Canvas_2;

    private void Start()
    {
        Canvas_0.SetActive(true);   
        Canvas_1.SetActive(false); 
        Canvas_2.SetActive(false); 
    }

    public void ShowPauseMenu()
    {
        Canvas_0.SetActive(false);
        Canvas_1.SetActive(true);
        Time.timeScale = 0f; 
    }

    public void ResumeGame()
    {
        Canvas_1.SetActive(false);
        Canvas_0.SetActive(true);
        Time.timeScale = 1f; 
    }

    public void ShowSettingsMenu()
    {
        Canvas_1.SetActive(false);
        Canvas_2.SetActive(true);
    }

    public void CloseSettingsMenu()
    {
        Canvas_2.SetActive(false);
        Canvas_1.SetActive(true);
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
}