using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Death : MonoBehaviour
{
  public bool On;
  public Text textBox;
  public Text final;
  Rigidbody2D myRigid;

  void Start ()
  {
    myRigid = this.GetComponent<Rigidbody2D>();
    On = false;
  }
  void Update(){
    if(myRigid.isKinematic == false){
      textBox.enabled = false;
      final.enabled = false;
    }
    else{
      On = true;
      textBox.enabled = true;
      final.enabled = true;
    }
  }
}
