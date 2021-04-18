using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject obstacle;
    public GameObject player;

    float time = 0;
    public bool canspawn = true;

    void Awake()
    {
        App.gameManager = this;
    }

    private void Update()
    {
        if (canspawn)
        {
            time += Time.deltaTime;

            if (time > 0.75f)
            {
                PickRandomObstacle(Random.Range(-2.15f, 0f));
                time = 0;
            }
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

    public void GameOver()
    {
        canspawn = false;
        App.screenManager.Show<FailScreen>();
    }
}
