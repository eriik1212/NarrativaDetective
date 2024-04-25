using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MurdererElectionLogic : MonoBehaviour
{
    public void SuspectChosed(TextMeshProUGUI suspect)
    {
        switch (suspect.text)
        {
            case "Sra. Devereux":
                Debug.Log("Has elegido a: " + suspect.text + " como la principal sospechosa");
                break;
            case "Remy (cocinero)":
                Debug.Log("Has elegido a: " + suspect.text + " como el principal sospechoso");
                break;
            case "Luc (hijo)":
                Debug.Log("Has elegido a: " + suspect.text + " como el principal sospechoso");
                break;
            case "Joseph (mayordomo)":
                Debug.Log("Has elegido a: " + suspect.text + " como el principal sospechoso");
                break;
            case "Léa (jardinera)":
                Debug.Log("Has elegido a: " + suspect.text + " como la principal sospechosa");
                break;
        }
    }
}
