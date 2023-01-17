using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activationCarte : MonoBehaviour
{
    float compteur = 6;
    bool danslazone = false;
    public Transform target;
    Camera cam;


    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();

    }

    // Update is called once per frame
    void Update()
    {
        if (danslazone == true && GameObject.Find("Player").GetComponent<Player>().aCarte1 == true)
        {
            compteur -= 1 * Time.deltaTime;
            if (compteur <= 3)
            {
                GameObject.Find("refEnigme1").GetComponent<MeshRenderer>().enabled = false;
                GameObject.Find("refEnigme1").GetComponent<SphereCollider>().enabled = false;
            }
            if (compteur <= 0)
            {
                GameObject.Find("resultatEnigme1").GetComponent<MeshRenderer>().enabled = true;
                GameObject.Find("resultatEnigme1").GetComponent<SphereCollider>().enabled = true;
            }

        }

     
    }

    private void OnTriggerEnter(Collider collision)
    {
        danslazone = true;
        
    }

    
}
