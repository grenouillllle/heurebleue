using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool aCarte1 = false;
    public bool aCarte2 = false;
    public bool aCarte3 = false;
    public bool aCarte4 = false;

    public List<GameObject> cartepostale;
    public int compteurlist = 0;


    // Start is called before the first frame update
    void Start()
    {
        cartepostale = new List<GameObject>();


    }

    // Update is called once per frame
    void Update()
    {
        if (aCarte1 == true)
        {
            print("vous avez la carte 1");
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            print(cartepostale[0]);
            cartepostale[0].SetActive(true);
            compteurlist = +1;
            if (compteurlist>0)
            {
                compteurlist = 0;
            }
        }

      



    }
}
