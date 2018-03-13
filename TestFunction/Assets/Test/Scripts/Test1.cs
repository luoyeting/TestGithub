using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Test1 : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Action<int> act =  this.TestCreateActionInstance();
        act(10);
        act(100);
        act(1000);
    }

    private Action<int> TestCreateActionInstance()
    {
        int count = 0;
        Action<int> action = delegate (int number) {
            count += number;
            Debug.Log(count);
        };
        action(1);
        return action;
    }

    //输出结果 1 11  111  1111
}