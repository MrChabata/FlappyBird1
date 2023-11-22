using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameUIController : MonoBehaviour
{
    public GameObject text;
    public GameObject pausePanel;
    public GameObject deathScreen;
    private AudioSource audio;
    void Start()
    {
        Global.isPause = false;
        Global.isAlive = true;
        audio = GameObject.FindGameObjectWithTag("ClickSound").GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Global.isPause) return;
        if (!Global.isAlive)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }

            if (Input.GetKeyDown(KeyCode.Escape))
            {
                BackToMenu();
            }
            return;
        }

        if (text.activeSelf == true && Input.GetKeyDown(KeyCode.Space))
        {
            audio.Play();
            text.SetActive(false);
        }

        if(Input.GetKeyDown(KeyCode.Escape) && pausePanel.activeSelf == false)
        {
            audio.Play();
            Global.isPause = true;
            pausePanel.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void BackToMenu()
    {
        audio.Play();
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1;
        Global.isPause = false;
    }

    public void Continue()
    {
        audio.Play();
        pausePanel.SetActive(false);
        Time.timeScale = 1;
        Global.isPause = false;
    }
}
