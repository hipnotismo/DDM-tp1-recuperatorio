using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuControl : MonoBehaviour
{

    public void Start()
    {

    }

    public void Play()
    {

        UnityEngine.SceneManagement.SceneManager.LoadScene("conduccion9");

    }

    public void Credits()
    {

    }

    public void Back()
    {

        UnityEngine.SceneManagement.SceneManager.LoadScene("menu");

    }

    public void Quit()
    {

        Application.Quit();
    }
}