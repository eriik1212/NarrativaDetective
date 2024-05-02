using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalPanelManagement : MonoBehaviour
{
    public ScenesManagement scenesManager;
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            scenesManager.GoToScene("MainMenu");
        }
    }
}
