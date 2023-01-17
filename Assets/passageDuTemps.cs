using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class passageDuTemps : MonoBehaviour
{
    float tempslong = 3500;

    // Start is called before the first frame update
    void Start()
    {
        


    }
    // Update is called once per frame
    void Update()
    {
        tempslong -= 1 * Time.deltaTime;

        if (tempslong <= 3490)
        {
            GameObject.Find("immeubleNouveau1").GetComponent<MeshRenderer>().enabled = true;
            GameObject.Find("immeubleNouveau1").GetComponent<SphereCollider>().enabled = true;


        }

    }
}
