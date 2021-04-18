using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScreen : ScreenBase
{
    public void OnPlayClick()
    {
        App.screenManager.Show<InGameScreen>();
        Hide();
        App.gameManager.RestartStartGame();
    }
}
