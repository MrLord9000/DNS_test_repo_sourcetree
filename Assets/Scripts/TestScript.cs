using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    [SerializeField] private float testVariable;

    void Start()
    {
        // I really need this variable to be 1.0f
        // ~ Filip 1
        testVariable = 1.0f;    
    }

    void Update()
    {
        DoSomething();
    }

    private void DoSomething()
    {
        Debug.Log("Did something!");
    }
}
