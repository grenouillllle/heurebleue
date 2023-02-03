using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class activationCarte : MonoBehaviour
{
    float compteur = 5;
    bool danslazone = false;
    public bool transformationDemarre = false;
    


    // Start is called before the first frame update
    void Start()
    {
        
        

    }

    // Update is called once per frame
    void Update()
    {
       
        if (danslazone == true && GameObject.Find("refEnigme1").GetComponent<objetVisible>().objetvu == true && GameObject.Find("Player").GetComponent<Player>().cartepostale[GameObject.Find("Player").GetComponent<Player>().compteurlist].name == "Carte1" && transformationDemarre==false)
        {
            compteur -= 1 * Time.deltaTime;
            print(compteur);
            if (compteur <= 2)
            {
                GameObject.Find("refEnigme1").GetComponent<MeshRenderer>().enabled = false;
                GameObject.Find("refEnigme1").GetComponent<SphereCollider>().enabled = false;
                transformationDemarre = true;
                print(transformationDemarre);
                GameObject.Find("SonCarte1").GetComponent<creersons>().lancemusique();
            }

       
               
        }

        if (GameObject.Find("refEnigme1").GetComponent<objetVisible>().objetvu == false && transformationDemarre == false)
        {
            compteur = 5;
        }

        if (transformationDemarre == true)
        {
            compteur -= 1 * Time.deltaTime;
            if (compteur <= 0)
            {
                GameObject.Find("resultatEnigme1").GetComponent<MeshRenderer>().enabled = true;
                GameObject.Find("resultatEnigme1").GetComponent<SphereCollider>().enabled = true;
                GameObject.Find("Player").GetComponent<Player>().cartepostale[0].SetActive(false);
            }
        }


    }

    private void OnTriggerEnter(Collider collision)
    {
        danslazone = true;
        
    }

    private void OnTriggerExit(Collider other)
    {
        danslazone = false;
    }



}
