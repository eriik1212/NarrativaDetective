using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomWeapon : MonoBehaviour
{
    int minRange = 1;
    int maxRange = 3;
    int randomInt = 0;

    public List<GameObject> gameObjectList;
    // Start is called before the first frame update
    void Start()
    {        
        HideObject();
        RandomNumber();
    }

    void RandomNumber()
    {
        randomInt = Random.Range(minRange, maxRange + 1);
        ShowObject();
    }

    void HideObject()
    {
        foreach (GameObject obj in gameObjectList)
        {
            obj.SetActive(false);
        }
    }

    void ShowObject()
    {
        switch (randomInt)
        {
            case 1:
                gameObjectList[0].SetActive(true);
                break;
            case 2:
                gameObjectList[1].SetActive(true);
                break;
            case 3:
                gameObjectList[2].SetActive(true);
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            HideObject();
            RandomNumber();
        }
    }
}
