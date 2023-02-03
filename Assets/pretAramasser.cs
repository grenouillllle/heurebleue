using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pretAramasser : MonoBehaviour
{
    public string nomObjet;
    public GameObject carteAajouter;
    bool pretRamasser = false;
    bool activemusique = false;
    float compteurmusique = 4;
    


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (pretRamasser == true && Input.GetKeyDown(KeyCode.Space) && nomObjet == "carte1")
        {
            GameObject.Find("Player").GetComponent<Player>().aCarte1 = true;
            GameObject.Find("Carte1").GetComponent<SpriteRenderer>().enabled = false;
            GameObject.Find("Player").GetComponent<Player>().cartepostale.Add(carteAajouter);
            GameObject.Find("SonCarte1").GetComponent<AudioSource>().Play();
            activemusique = true;

        }

        else if (pretRamasser == true && Input.GetKeyDown(KeyCode.Space) && nomObjet == "carte2")
        {
            GameObject.Find("Player").GetComponent<Player>().aCarte2 = true;
            Destroy(gameObject);
        }
        else if (pretRamasser == true && Input.GetKeyDown(KeyCode.Space) && nomObjet == "carte3")
        {
            GameObject.Find("Player").GetComponent<Player>().aCarte3 = true;
            Destroy(gameObject);
        }

        if (pretRamasser == true)
        {
            print("Vous pouvez ramasser");
        }

        if (activemusique == true)
        {
            compteurmusique -= 1 * Time.deltaTime;
            print(compteurmusique);
            if (compteurmusique <= 0)
            {
                GameObject.Find("SonCarte1").GetComponent<AudioSource>().Stop();
                Destroy(gameObject);
            }
        }



   
        

    }

    private void OnTriggerEnter(Collider collision)

    {
        pretRamasser = true;
    }

    private void OnTriggerExit(Collider other)
    {
        pretRamasser = false;
    }

}
