using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuControls : MonoBehaviour
{
    [SerializeField] Text highScoreText;
    [SerializeField] AudioClip startingSong;
    private void Start()
    {
        int highScore = PlayerPrefs.GetInt("HighScore");
        highScoreText.text = highScore.ToString();
        if(startingSong != null)
        {
            AudioManagement.Instance.PlaySong(startingSong);
        }
    }
}
