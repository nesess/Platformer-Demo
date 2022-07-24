using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public void SwitchLevel1()
    {
        SceneManager.LoadScene(1);
    }

    public void SwitchLevel2()
    {
        SceneManager.LoadScene(2);
    }

    public void SwitchMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
