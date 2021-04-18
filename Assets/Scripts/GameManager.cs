using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject obstacle;
    public GameObject player;

    void Start()
    {
        App.gameManager = this;
        App.screenManager.Show<MenuScreen>();
        App.screenManager.Hide<InGameScreen>();
        App.screenManager.Hide<FailScreen>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PickRandomObstacle(Random.Range(-2.15f, 0f));
        }
    }

    public void InstantiateMap()
    {
        Instantiate(player, new Vector3(0,0,0), Quaternion.identity);
    }

    public void PickRandomObstacle( float yPos)
    {
        Instantiate(obstacle, new Vector3(5, yPos, 0), Quaternion.identity);
    }
}
