using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        if (Time.time >= TimeCounter && i <= textList.Count)
        {
            textList[i].SetActive(true);
            TimeCounter = Time.time + TimeBetweenText;
            i++;
        }
    }
}
