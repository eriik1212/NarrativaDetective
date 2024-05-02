using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MurdererElectionLogic : MonoBehaviour
{
    public GameObject winPanel;
    public GameObject losePanel;

    private void Start()
    {
        winPanel.SetActive(false);
        losePanel.SetActive(false);
    }

    public void SuspectChosed(TextMeshProUGUI suspect)
    {
        switch (suspect.text)
        {
            case "Sra. Devereux":
                Debug.Log("Has elegido a: " + suspect.text + " como la principal sospechosa");

                winPanel.SetActive(false);
                losePanel.SetActive(true);

                break;
            case "Remy (cocinero)":
                Debug.Log("Has elegido a: " + suspect.text + " como el principal sospechoso");

                winPanel.SetActive(false);
                losePanel.SetActive(true);

                break;  
            case "Luc (hijo)":
                Debug.Log("Has elegido a: " + suspect.text + " como el principal sospechoso");

                winPanel.SetActive(false);
                losePanel.SetActive(true);

                break;
            case "Joseph (mayordomo)":
                Debug.Log("Has elegido a: " + suspect.text + " como el principal sospechoso");

                winPanel.SetActive(false);
                losePanel.SetActive(true);

                break;
            case "Léa (jardinera)":
                Debug.Log("Has elegido a: " + suspect.text + " como la principal sospechosa");

                winPanel.SetActive(true);
                losePanel.SetActive(false);

                break;
        }
    }
}
