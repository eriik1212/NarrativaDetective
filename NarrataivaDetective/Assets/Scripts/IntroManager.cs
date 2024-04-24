using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroManager : MonoBehaviour
{
    public GameObject background;
    public GameObject[] introText;

    private void Start()
    {
        background.SetActive(true);

        for(int i = 0; i < introText.Length; i++)
            introText[i].SetActive(true);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            background.SetActive(false);

            for (int i = 0; i < introText.Length; i++)
                introText[i].SetActive(false);
        }
    }
}
