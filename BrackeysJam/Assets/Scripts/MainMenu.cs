using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    void PlayGame()
    {
        SceneManager.LoadScene("put scene here");
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E)) 
        {
            Application.OpenURL("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
        }
    }
}
