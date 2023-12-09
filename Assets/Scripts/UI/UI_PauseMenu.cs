using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    private static int money;
    private static int score;


    private void LateUpdate()
    {
        money = PlayerPrefs.GetInt("TotalMoney");
        score = PlayerPrefs.GetInt("Score");
    }
    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }
    public void Home()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }
    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }
    public void Restart()
    {
        PlayerPrefs.SetInt("TotalMoney", money);
        PlayerPrefs.SetInt("Score", score);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }
}
