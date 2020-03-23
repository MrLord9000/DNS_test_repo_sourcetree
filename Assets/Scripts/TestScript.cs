using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    [SerializeField] private float testVariable;

    void Start()
    {
        // I really need ths variable to be 21.37f
        // ~ Filip 2
        testVariable = 21.37f;    
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
