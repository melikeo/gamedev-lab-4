using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour

{
    public Renderer rend;
    private int i = 3;
    private int randomValue;
    
    // Start is called before the first frame update
    void Start()
    {
        randomValue = Random.Range(150, 251);
                
    }

    // Update is called once per frame
        void Update()
    {
        i++;
        Debug.Log(gameObject.name + ":" + i);

        if (gameObject.tag == "Red" && i == 100) 
        {
            gameObject.SetActive(false);
        };

        if (gameObject.tag == "Blue" && i == randomValue) 
        {
            rend.enabled = false;
     
        };
        
    }
}
