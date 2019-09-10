using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testMono : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("It is an awake!");
    }
    void Start()
    {
        Debug.Log("It is a start!");
    }
    void Update()
    {
        Debug.Log("It is an update!");
    }
    private void FixedUpdate()
    {
        Debug.Log("It is a fixedupdate!");
    }
    private void OnGUI()
    {
        Debug.Log("It is ONGUI!");
    }
    private void OnDisable()
    {
        Debug.Log("It is OnDisable!");
    }
    private void OnEnable()
    {
        Debug.Log("It is OnEnable!");
    }
}