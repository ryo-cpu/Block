using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarControl : MonoBehaviour
{
    public float Speed = 10.0f;
    Rigidbody myRigdobay;
    // Start is called before the first frame update
    void Start()
    {
        myRigdobay = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        myRigdobay.velocity=new Vector3(Input.GetAxis("Horizontal")*Speed,0,0);
    }
}
