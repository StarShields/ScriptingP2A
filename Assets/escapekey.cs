using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class escapekey : MonoBehaviour
{
    public static bool pausedGame;
    public GameObject PauseMenuUI;
   void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            PauseMenuUI.SetActive(true);
        }
    
        }
    public  void CursorState()
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
    }

