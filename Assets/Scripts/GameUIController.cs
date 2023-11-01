using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameUIController : MonoBehaviour
{
    public GameObject text;
    public GameObject pausePanel;
    void Start()
    {
    }

    void Update()
    {
        if (text.activeSelf == true && Input.GetKeyDown(KeyCode.Space))
        {
            text.SetActive(false);
        }

        if(Input.GetKeyDown(KeyCode.Escape) && pausePanel.activeSelf == false)
        {
            pausePanel.SetActive(true);
        }
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Continue()
    {
        pausePanel.SetActive(false);
    }
}
