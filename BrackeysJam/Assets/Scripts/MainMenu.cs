using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(sceneName: ("Yourmom"));
        Application.OpenURL("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E)) 
        {
            Application.OpenURL("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
        }
    }
}
