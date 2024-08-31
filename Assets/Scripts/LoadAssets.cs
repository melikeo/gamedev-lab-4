using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAssets : MonoBehaviour

{
    public GameObject redObj;
    [SerializeField]
    private GameObject blueObj;

    // Start is called before the first frame update
    void Start()
    {
        // Limit framerate to 60fps
        Application.targetFrameRate = 60;

        //creates redobj
        Instantiate(redObj, new Vector3 (2, 0, 0), Quaternion.identity);
        //creates blueobj
        Instantiate(blueObj, new Vector3 (-2, 0, 0), Quaternion.identity);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
