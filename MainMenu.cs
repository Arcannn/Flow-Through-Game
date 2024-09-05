using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
  public Text text1;
  public Text text2;
  public Text text3;

  public void PlayGame () {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +2);
  }
  public void PlayLevel2 () {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +3);
  }
  public void PlayLevel3 () {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +4);
  }
  public void PlayBonusChristmas () {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +5);
  }

  public void QuitGame () {
    Debug.Log ("QUIT!");
    Application.Quit();
  }
      public void PlayBack () {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1);
  }
  void Start(){
    text1 = GameObject.FindWithTag("Level1Score").GetComponent<Text>();
    text1.text = (PlayerPrefs.GetFloat("gameHiScore")).ToString("F2");

    text2 = GameObject.FindWithTag("Level2Score").GetComponent<Text>();
    text2.text = (PlayerPrefs.GetFloat("Level2HiScore")).ToString("F2");

    text3 = GameObject.FindWithTag("Level3Score").GetComponent<Text>();
    text3.text = (PlayerPrefs.GetFloat("Level3HiScore")).ToString("F2");

  }

}
