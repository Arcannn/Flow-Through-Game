  ﻿using System.Collections;
  using System.Collections.Generic;
  using UnityEngine;
  using UnityEngine.SceneManagement;

  public class player : MonoBehaviour
  {
    public string left;
    public string right;
    public string up;
    GameObject player1;
    Rigidbody2D myRigid;
    public bool GameOver = false;
      // Start is called before the first frame update
      void Start()
      {
          myRigid = this.GetComponent<Rigidbody2D>();
      }

      // Update is called once per frame
      void Update()
      {
          if (Input.GetKey(left))
          {
              this.transform.Rotate(new Vector3(0f, 0f, 50f)
  * Time.deltaTime);
          }

          if (Input.GetKey(right))
          {
              this.transform.Rotate(new Vector3(0f, 0f,
  -50f) * Time.deltaTime);
          }
      }


        void FixedUpdate()
        {
          if (GameOver) {
            if (Input.anyKey) {
              SceneManager.LoadScene ("Menu");
            }
            return;
          }
            if (Input.GetKey(up))
            {
                myRigid.AddForce(this.transform.up * 150);
            }
             else if (Input.GetKey(up)){
             myRigid.velocity *= 0.2f;
           }
         }
         // below is a "on collision end the game" script. It freezes the player once they collide with an Object.
          // void onTriggerEnter(Collision2D collision) {
          //   GameOver = true;
          //   myRigid.isKinematic = true;
        // }

          private void OnCollisionEnter2D(Collision2D collision) {

            if(collision.collider.gameObject.tag == "Collect"){


              GameObject player = GameObject.Find("player1");
              ScoreTrack scoreScript = player.GetComponent<ScoreTrack>();
              scoreScript.score += 1;

              collision.collider.gameObject.SetActive(false);

            }
            else{
              GameOver = true;
              myRigid.isKinematic = true;
            }
          }

            }
