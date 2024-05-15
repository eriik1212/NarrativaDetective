using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestifyLogic : MonoBehaviour
{
    public GameObject testifyPanel;
    public GameObject playerUI;

    private bool testifyPanelVisibility = false;

    private void Start()
    {
        testifyPanelVisibility = false;

        //LockCursor();

        testifyPanel.SetActive(testifyPanelVisibility);
        playerUI.SetActive(!testifyPanelVisibility); 
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.F1))
        {
            testifyPanelVisibility = !testifyPanelVisibility;

            testifyPanel.SetActive(testifyPanelVisibility);
            playerUI.SetActive(!testifyPanelVisibility);
        }

        if(testifyPanel.activeInHierarchy)
        {
            Time.timeScale = 0.0f;
            UnlockCursor();

        }
        else
        {
            Time.timeScale = 1.0f;
            //LockCursor();

        }

    }

    private static void LockCursor()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private static void UnlockCursor()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
