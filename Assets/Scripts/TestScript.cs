using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    [SerializeField] private float testVariable;

    void Start()
    {
        testVariable = 0.0f;    
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
