    ﻿using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.UI;
    using UnityEngine.SceneManagement;

    public class Timer : MonoBehaviour
    {
      public float timeStart;
      public Text textBox;
      public bool TimerOn;
      Rigidbody2D myRigid;
      public float score;


        // Start is called before the first frame update
        void Start()
        {
          myRigid = this.GetComponent<Rigidbody2D>();
          TimerOn = false;
          textBox.text = timeStart.ToString("F2");
          score = 0;

        }

        // Update is called once per frame
        void Update()
        {
          if(myRigid.isKinematic == false){

                      timeStart += Time.deltaTime;
                      textBox.text = timeStart.ToString("F2");
          }
          else{ // this will run when the player collided/dies.
            TimerOn = true;

            score = timeStart;
            Scene activeScene = SceneManager.GetActiveScene();
            // print(activeScene.name);
            float hiScore = 0.00F;
            string level = "";

            if(activeScene.name == "game") {
              level = "gameHiScore";
            }
            else if(activeScene.name == "Level2"){
              level = "Level2HiScore";
            }
            else if(activeScene.name == "Level3"){
              level = "Level3HiScore";
            }


            hiScore = PlayerPrefs.GetFloat(level, 0);

            if(score > hiScore){
              PlayerPrefs.SetFloat(level, score);
            }


                    //  GameObject score = GameObject.Find("StoreScore");
        //    StoreScore scoreScript = score.GetComponent<StoreScore>();

          }
        }
      }
