using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool aCarte1 = false;
    public bool aCarte2 = false;
    public bool aCarte3 = false;
    public bool aCarte4 = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (aCarte1 == true)
        {
            print("vous avez la carte 1");
        }
        
    }
}
