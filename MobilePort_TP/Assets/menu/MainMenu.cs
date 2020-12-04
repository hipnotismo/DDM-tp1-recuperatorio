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

  

    // Start is called before the first frame update
    void Start()
    {
        firstButton.Select();
    }

    public void PlayButton()
    {
        if (player1.isOn)
        {
            if (easy.isOn)
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
            }
        }
        else if (player2.isOn)
        {
            if (easy.isOn)
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
