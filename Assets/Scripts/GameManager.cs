using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{   
    [Header("Objects")]
    public GameObject obstacle;
    public GameObject player;

    [Header("UI")]
    public TMP_Text scoreTxt;

    [Header("Numbers")]
    float time = 0;
    public bool canspawn = true;
    float score = 0;

    void Awake()
    {
        App.gameManager = this;
        RestartStartGame();
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

    public void RestartStartGame()
    {
        App.screenManager.Hide<FailScreen>();
        score = 0;
        scoreTxt.text = score.ToString();
        canspawn = true;
        InstantiateMap();
    }

    public void AddScore(float count)
    {
        score += count;
        scoreTxt.text = score.ToString();
    }
}
