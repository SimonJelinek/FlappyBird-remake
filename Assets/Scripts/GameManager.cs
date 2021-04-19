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
    public TMP_Text failScoreTxt;
    public TMP_Text failHighScoreTxt;
    public AudioSource[] sounds;

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

            if (time > 1.5f)
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
        scoreTxt.text = "";
        canspawn = false;
        App.screenManager.Show<FailScreen>();
        failScoreTxt.text = score.ToString();

        int highscore = PlayerPrefs.GetInt("highscore");

        if (score > highscore)
        {
            PlayerPrefs.SetInt("highscore", (int)score);
        }
        failHighScoreTxt.text = PlayerPrefs.GetInt("highscore").ToString();
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
        PlaySound(0);
    }

    public void PlaySound(int index)
    {
        if (PlayerPrefs.GetInt("soundSet")==1)
        {
            sounds[index].Play();
        }
    }
}
