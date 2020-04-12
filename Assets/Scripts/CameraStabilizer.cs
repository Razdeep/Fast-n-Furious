using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraStabilizer : MonoBehaviour
{

    public GameObject car;
    
    void Update()
    {
        float y = car.transform.rotation.eulerAngles.y;
        transform.eulerAngles = new Vector3(0, y, 0);
    }
}
