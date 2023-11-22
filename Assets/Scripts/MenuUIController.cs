using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUIController : MonoBehaviour
{
    private AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        audio = GameObject.FindGameObjectWithTag("ClickSound").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ExitGame()
    {
        print("ExitGame");
        Application.Quit();
    }

    public void StartGame()
    {
        audio.Play();
        SceneManager.LoadScene("Game");
    }


}
