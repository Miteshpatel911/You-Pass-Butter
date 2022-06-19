using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinHandler : MonoBehaviour
{
    [SerializeField] Canvas WinUI;

    void Start()
    {
        WinUI.enabled = false;
        Time.timeScale = 1;
    }

   
    public void WinProcess()
    {
        WinUI.enabled = true;
        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
