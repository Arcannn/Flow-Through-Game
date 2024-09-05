  ﻿using System.Collections;
  using System.Collections.Generic;
  using UnityEngine;

  public class rotation : MonoBehaviour {
  public int rotz;
  public int mx, my;
  public Rigidbody2D myRigid;

  // Use this for initialization
  void Start () {
      myRigid = this.GetComponent<Rigidbody2D>();

  }

  // Update is called once per frame
  void Update () {
      this.transform.Rotate(new Vector3(0, 0, rotz));

      myRigid.AddForce(this.transform.up * mx);
      myRigid.AddForce(this.transform.right * mx);
  }
  }
