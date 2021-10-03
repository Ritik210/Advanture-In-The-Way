using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LoadScene()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
    public void LoadGame()
    {
        SceneManager.LoadScene(2);
        Time.timeScale = 1;
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }
    public void QuitGame()
    {
        Application.Quit();
        
    }
}
