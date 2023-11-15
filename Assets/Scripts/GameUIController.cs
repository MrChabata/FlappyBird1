using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameUIController : MonoBehaviour
{
    public GameObject text;
    public GameObject pausePanel;
    public GameObject deathScreen;
    void Start()
    {
        Global.isPause = false;
        Global.isAlive = true;
    }

    void Update()
    {
        if (Global.isPause) return;
        if (!Global.isAlive)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                print("wow");
            }
            return;
        }

        if (text.activeSelf == true && Input.GetKeyDown(KeyCode.Space))
        {
            text.SetActive(false);
        }

        if(Input.GetKeyDown(KeyCode.Escape) && pausePanel.activeSelf == false)
        {
            Global.isPause = true;
            pausePanel.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1;
        Global.isPause = false;
    }

    public void Continue()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1;
        Global.isPause = false;
    }
}
