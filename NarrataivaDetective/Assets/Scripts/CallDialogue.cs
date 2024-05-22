using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CallDialogue : MonoBehaviour
{
    [SerializeField] List<GameObject> textList;
    [SerializeField] float TimeBetweenText;
    float TimeCounter;

    int i = 0;

    // Start is called before the first frame update
    void Start()
    {
        TimeCounter = Time.time + TimeBetweenText;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && i < textList.Count)
        {

            textList[i].SetActive(true);
            TimeCounter = Time.time + TimeBetweenText;
            i++;
        }

        if (Time.time >= TimeCounter && i < textList.Count)
        {
            textList[i].SetActive(true);
            TimeCounter = Time.time + TimeBetweenText;
            i++;
        }
    }
}
