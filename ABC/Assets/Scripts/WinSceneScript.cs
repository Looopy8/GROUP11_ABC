using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinSceneScript : MonoBehaviour
{
    public void OnClickPlayAgainBtn()
    {
        SceneManager.LoadScene("FirstStage");
    }

    public void OnClickMainMenuBtn()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void OnQuitBtnClick()
    {
        Application.Quit();
    }
}
