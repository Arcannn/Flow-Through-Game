﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
  private float length, startpos; // the length and start position of sprite.
  public GameObject cam;
  public float parallaxEffect; // set it in the editor.
    // Start is called before the first frame update
    void Start()
    {
        startpos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;

    }

    // Update is called once per frame
    void Update()
    {
        float dist = (cam.transform.position.x * parallaxEffect);
        float temp = (cam.transform.position.x * (1 - parallaxEffect));

        transform.position = new  Vector3(startpos + dist, transform.position.y, transform.position.z);

        if(temp > startpos + length){
           startpos += length;
          }
        else if (temp < startpos - length){
          startpos -= length;
          }
    }
}
