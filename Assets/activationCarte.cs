using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class activationCarte : MonoBehaviour
{
    float compteur = 8;
    bool danslazone = false;
    

    


    // Start is called before the first frame update
    void Start()
    {
        
        

    }

    // Update is called once per frame
    void Update()
    {
       
        if (danslazone == true && GameObject.Find("Player").GetComponent<Player>().aCarte1 == true && GameObject.Find("refEnigme1").GetComponent<objetVisible>().objetvu == true)
        {
            compteur -= 1 * Time.deltaTime;
            print(compteur);
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

        if (GameObject.Find("refEnigme1").GetComponent<objetVisible>().objetvu == false)
        {
            compteur = 8;
        }




    }

    private void OnTriggerEnter(Collider collision)
    {
        danslazone = true;
        
    }

    
}
