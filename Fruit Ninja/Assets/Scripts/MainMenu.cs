using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void ExitButton()
    {
        Application.Quit();
        Debug.Log("Gmae Quit");
    }

    public void StartGame()
    {
        SceneManager.LoadScene("FruitNinja");
    }
}
