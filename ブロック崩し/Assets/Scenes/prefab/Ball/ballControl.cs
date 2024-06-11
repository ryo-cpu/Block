using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class ballControl : MonoBehaviour
{
    public float speed = 5;    // Start is called before the first frame update
    Rigidbody myrigbodoy;
    void Start()
    {
        myrigbodoy = GetComponent<Rigidbody>();
        myrigbodoy.velocity =new Vector3(speed,speed,0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
