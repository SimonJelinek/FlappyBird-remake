using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FailScreen : ScreenBase
{
    public void ReturnToMenu()
    {
        App.screenManager.Hide<FailScreen>();
        App.screenManager.Hide<InGameScreen>();
        App.screenManager.Show<MenuScreen>();
    }

    public void RestartGame()
    {
        App.gameManager.RestartStartGame();
    }
}
