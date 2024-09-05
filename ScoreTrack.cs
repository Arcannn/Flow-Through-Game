using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTrack : MonoBehaviour
{
  public Text textBox;
  public bool scoreOn;
  Rigidbody2D myRigid;
  public int score;
    // Start is called before the first frame update
    void Start()
    {
      myRigid = this.GetComponent<Rigidbody2D>();
      scoreOn = false;
      score = 0;
      textBox.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
      if(myRigid.isKinematic == false){
        textBox.text = score.ToString();
      }
      else{
        scoreOn = true;
      }


    }
}
