using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetData : MonoBehaviour
{
    [SerializeField] Text currentScoreView;
   int resetScore = 0;
    public void Reset()
    {
     int highScore = PlayerPrefs.GetInt("HighScore");
       if (highScore > 0)
        {
            highScore = 0;
            currentScoreView.text = "0";
            PlayerPrefs.SetInt("HighScore", resetScore);
            Debug.Log("New high score: " + resetScore);
        }
    }
}
