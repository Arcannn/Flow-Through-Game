using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Bobbing : MonoBehaviour
{
    public Rigidbody2D myRigid;
    public float strength;
    Vector3 vecY;
    float originY;

    // Start is called before the first frame update
    void Start()
    {
        myRigid = this.GetComponent<Rigidbody2D>();
        this.originY = this.transform.position.y;

    }

    // Update is called once per frame
    void Update()
        {
            transform.position = new Vector3(transform.position.x,
                originY + ((float)Math.Sin(Time.time) * strength),
                transform.position.z);
        }
}
