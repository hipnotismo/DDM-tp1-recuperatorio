using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] Button firstButton = null;
    [SerializeField] Toggle player1 = null;
    [SerializeField] Toggle player2 = null;
    [SerializeField] Toggle easy = null;
    [SerializeField] Toggle medium = null;
    [SerializeField] Toggle hard = null;

    bool easy2 = false;
    bool medium2 = false;
    bool hard2 = false;

    // Start is called before the first frame update
    void Start()
    {
        firstButton.Select();
       
    }

    public void Easy()
    {
        easy2 = true;
        medium2 = false;
        hard2 = false;
    }
    public void Medium()
    {
        easy2 = false;
        medium2 = true;
        hard2 = false;
    }
    public void Hard()
    {
        easy2 = false;
        medium2 = false;
        hard2 = true;
    }

    public void PlayButton()
    {
        if (player1.isOn)
        {
            Debug.Log("Play with 1 player ");

            /*if (easy.isOn )
            {
                Debug.Log("Play with 1 player on easy");
                GameManager.SinglePlayer = true;
                UnityEngine.SceneManagement.SceneManager.LoadScene("conduccion9");
            }
            if (medium.isOn)
            {
                Debug.Log("Play with 1 player on medium");
                GameManager.SinglePlayer = true;
                UnityEngine.SceneManagement.SceneManager.LoadScene("conduccion10");
            }
            if (hard.isOn)
            {
                Debug.Log("Play with 1 player on hard");
                GameManager.SinglePlayer = true;
                UnityEngine.SceneManagement.SceneManager.LoadScene("conduccion11");
            }*/

            if (easy2 == true)
            {
                Debug.Log("Play with 1 player on easy");
                GameManager.SinglePlayer = true;
                UnityEngine.SceneManagement.SceneManager.LoadScene("conduccion9");
            }
            if (medium2 == true)
            {
                Debug.Log("Play with 1 player on medium");
                GameManager.SinglePlayer = true;
                UnityEngine.SceneManagement.SceneManager.LoadScene("conduccion10");
            }
            if (hard2 == true)
            {
                Debug.Log("Play with 1 player on hard");
                GameManager.SinglePlayer = true;
                UnityEngine.SceneManagement.SceneManager.LoadScene("conduccion11");
            }
            
        }
        else if (player2.isOn)
        {
            /* if (easy.isOn)
             {
                 Debug.Log("Play with 2 player on easy");
                 GameManager.SinglePlayer = false;
                 UnityEngine.SceneManagement.SceneManager.LoadScene("conduccion9");
             }
             if (medium.isOn)
             {
                 Debug.Log("Play with 2 player on medium");
                 GameManager.SinglePlayer = false;
                 UnityEngine.SceneManagement.SceneManager.LoadScene("conduccion10");
             }
             if (hard.isOn)
             {
                 Debug.Log("Play with 2 player on hard");
                 GameManager.SinglePlayer = false;
                 UnityEngine.SceneManagement.SceneManager.LoadScene("conduccion11");
             }*/

            Debug.Log("Play with 2 player ");


            if (easy2 == true)
            {
                Debug.Log("Play with 2 player on easy");
                GameManager.SinglePlayer = false;
                UnityEngine.SceneManagement.SceneManager.LoadScene("conduccion9");
            }
            if (medium2 == true)
            {
                Debug.Log("Play with 2 player on medium");
                GameManager.SinglePlayer = false;
                UnityEngine.SceneManagement.SceneManager.LoadScene("conduccion10");
            }
            if (hard2 == true)
            {
                Debug.Log("Play with 2 player on hard");
                GameManager.SinglePlayer = false;
                UnityEngine.SceneManagement.SceneManager.LoadScene("conduccion11");
            }
            
        }
        else
        {
            Debug.Log("Plz select a game mode");
        }
    }

    public void GoToCredits() {
         UnityEngine.SceneManagement.SceneManager.LoadScene("Credits");
    }


    public void OnExitButton() {
        Debug.Log("Exit");
    }
}
