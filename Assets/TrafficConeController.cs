using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficConeController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //‰Û‘è
        if (this.transform.position.z < Camera.main.transform.position.z)
        {
            Destroy(this.gameObject);
        }
    }
}
