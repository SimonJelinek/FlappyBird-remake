﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        App.gameManager = this;
        App.screenManager.Show<MenuScreen>();
        App.screenManager.Hide<InGameScreen>();
        App.screenManager.Hide<FailScreen>();
    }
}
