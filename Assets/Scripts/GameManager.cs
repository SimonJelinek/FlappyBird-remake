using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    public Transform parent;

    void Start()
    {
        App.gameManager = this;
        App.screenManager.Show<MenuScreen>();
        App.screenManager.Hide<InGameScreen>();
        App.screenManager.Hide<FailScreen>();
    }

    public void InstantiateMap()
    {
        Instantiate(player, new Vector3(), Quaternion.identity, parent);
    }
}
