using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LEVEL01CONTROLLER : MonoBehaviour
{
    [SerializeField] Text currentScoreView;
    int currentScore;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            ExitLevel();
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            IncreaseScore(5);
        }

    }
    public void ExitLevel()
    {
        int highScore = PlayerPrefs.GetInt("HighScore");
        if(currentScore> highScore)
        {
            PlayerPrefs.SetInt("HighScore", currentScore);
            Debug.Log("New high score: " + currentScore);
        }
        SceneManager.LoadScene("MainMenu");
    }

   public void IncreaseScore(int scoreIncrease)
    {
        currentScore += scoreIncrease;
        currentScoreView.text = "Score: " + currentScore.ToString();
    }


    }


