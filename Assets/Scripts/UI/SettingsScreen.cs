using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SettingsScreen : ScreenBase
{
    public TMP_Text highscoreTxt;
    public Button soundButton;
    public Sprite[] soundSprites;

    bool opened = false;
    bool sound = true;

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

        soundButton.image.sprite = soundSprites[PlayerPrefs.GetInt("soundSet")];
    }

    public void OnSoundClick()
    {
        sound = !sound;

        if (sound)
        {
            PlayerPrefs.SetInt("soundSet", 1);
        }
        else
        {
            PlayerPrefs.SetInt("soundSet", 0);
        }

        soundButton.image.sprite = soundSprites[PlayerPrefs.GetInt("soundSet")];
    }

    void UpdateTxt()
    {
        highscoreTxt.text = PlayerPrefs.GetInt("highscore").ToString();
    }
}
