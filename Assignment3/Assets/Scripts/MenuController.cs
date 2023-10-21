using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public string newGameLevel;

    public void NewGameDialogYes()
    {
        SceneManager.LoadScene(newGameLevel);
    }

    public void ExitButton()
    {
        Application.Quit();
    }
}
