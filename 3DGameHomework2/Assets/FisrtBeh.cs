using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FisrtBeh : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Debug.Log("This Start!");
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("This Update!");	
    }

    void OnEnable()
    {
        Debug.Log("This Enabled!");
    }

    void OnDisable()
    {
        Debug.Log("This Disabled!");
    }
}