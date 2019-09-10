using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Find : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject find1 = GameObject.Find("Cube 1");
        if (find1 == null)
        {
            Debug.Log("no cube1");
        }
        else
        {
            Debug.Log("find cube1 success");
        }
        GameObject find2 = GameObject.Find("Cube 3");
        if (find2 == null)
        {
            Debug.Log("no cube3");
        }
        else
        {
            Debug.Log("find cube1 success");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

