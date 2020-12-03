using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Back : MonoBehaviour
{
    public void BackTo()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Menu");
    }
}
