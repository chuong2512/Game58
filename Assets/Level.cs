using System.Collections;
using System.Collections.Generic;
using Game58;
using UnityEngine;

public class Level : Singleton<Level>
{
    public GameObject hide;
    void Start()
    {
        hide.SetActive(false);
    }
    
    
}