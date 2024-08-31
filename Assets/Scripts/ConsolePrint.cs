using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsolePrint : MonoBehaviour

{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    int i = 3;
    void Update()
    {
        i++;
        Debug.Log(gameObject.name + ":" + i);
        
    }
}
