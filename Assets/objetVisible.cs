using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objetVisible : MonoBehaviour
{
    Camera camera;
    MeshRenderer renderer;
    Plane[] cameraFrustum;
    Collider collider;
    public bool objetvu=false;

    // Start is called before the first frame update
    void Start()
    {
        camera = Camera.main;
        collider = GetComponent<Collider>();

    }

    // Update is called once per frame
    void Update()
    {
        var bounds = collider.bounds;
        cameraFrustum = GeometryUtility.CalculateFrustumPlanes(camera);

        if (GeometryUtility.TestPlanesAABB(cameraFrustum, bounds))
        {
            objetvu = true;
            print("objet est vu");
        }
        else
        {
            objetvu = false;
            print("objet est caché");

        }

        

    }
}
