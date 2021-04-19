using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SettingsScreen : ScreenBase
{
    public TMP_Text highscoreTxt;
    bool opened = false;

    public void OnSettingClick()
    {
        opened = !opened;

        if (!opened)
        {
            App.screenManager.Show<SettingsScreen>();
        }
        else
        {
            App.screenManager.Hide<SettingsScreen>();
        }

        UpdateTxt();
    }

    void UpdateTxt()
    {
        highscoreTxt.text = PlayerPrefs.GetInt("highscore").ToString();
    }
}
