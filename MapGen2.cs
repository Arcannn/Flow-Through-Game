using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// This is a duplicate of MapGen. Changing within this script will be the Objects and further will allow for more shapes to be generated within Level3.
public class MapGen2 : MonoBehaviour
{
  public GameObject ceiling1;
  public GameObject floor1;
  public GameObject ceiling;
  public GameObject floor;
  public GameObject lavabackf;
  public GameObject lavabackf1;
  public GameObject lavabackc;
  public GameObject lavabackc1;

  public GameObject player1;

  public GameObject Object1;
  public GameObject Object2;
  public GameObject Object3;
  public GameObject Object4;
  public GameObject Object5;
  public GameObject Object6;
  public GameObject Object7;
  public GameObject Object8;
  public GameObject Object9;
  public GameObject Object10;

  public GameObject GenObject2;
  // Object game objects are there for the Gen Object to clone. Generation Object (GenObject) is a Prefab that is assigned to the script. This will clone all objects once the game begins and it will spawn them in.
  public float minObjectSpacing;
  public float maxObjectSpacing;
  public float maxObjectVertically;
  public float minObjectVertically;
  public float maxObjectScaleVertically;
  public float minObjectScaleVertically;
  // each float allows for a number to be added on to the object.

  // Start is called before the first frame update
  void Start()
  {
    Object1 = GenerateObject(player1.transform.position.x + 60);
    Object2 = GenerateObject(Object1.transform.position.x);
    Object3 = GenerateObject(Object2.transform.position.x);
    Object4 = GenerateObject(Object2.transform.position.x);
    Object5 = GenerateObject(Object2.transform.position.x);
    Object6 = GenerateObject(Object2.transform.position.x);
    Object7 = GenerateObject(Object2.transform.position.x);
    Object8 = GenerateObject(Object2.transform.position.x);
    Object9 = GenerateObject(Object2.transform.position.x);
    Object10 = GenerateObject(Object2.transform.position.x);
    // Object1 is the intial object that is spawned +60 away from the player on the x axis. Object1 will then be followed +10 by the object after it and so on.
  }
  GameObject GenerateObject(float referenceX) {
    GameObject Object = GameObject.Instantiate(GenObject2);
    SetTransform(Object,referenceX);
    return Object;
    // Returning the Objecting to the start for the map to generate in a new way.
  }
  void SetTransform(GameObject Object, float referenceX) {
    // Instantiate to load the prefab into the scene - these being the game objects.
    Object.transform.position = new Vector3(referenceX + Random.Range(minObjectSpacing,maxObjectSpacing), Random.Range(minObjectVertically,maxObjectVertically), 0);
    // The spacing between each object being generated.
    Object.transform.localScale = new Vector3(Object.transform.localScale.x, Random.Range(minObjectScaleVertically,maxObjectScaleVertically), Object.transform.localScale.z);
    // the scale of each of the objects being generated in terms of the height. Not Width - could do something with the width though.
  }

  // Update is called once per frame
  void Update()

  {
    // Debug.Log(Object2.transform.position.x);

    if (player1.transform.position.x > floor.transform.position.x) {
      var temporaryceiling = ceiling1;
      var temporaryfloor = floor1;
      var temporarylavaf = lavabackf1;
      var temporarylavac = lavabackc1;
      ceiling1 = ceiling;
      floor1 = floor;
      lavabackc1 = lavabackc;
      lavabackf1 = lavabackf;
      temporaryceiling.transform.position += new Vector3(20, 0, 0);
      temporaryfloor.transform.position += new Vector3(20, 0, 0);
      temporarylavaf.transform.position += new Vector3(10,0,0);
      temporarylavac.transform.position += new Vector3(10,0,0);
      ceiling = temporaryceiling;
      floor = temporaryfloor;
      lavabackf1 = temporarylavaf;
      lavabackc1 = temporarylavac;
      // The script for the Map generation - continuous movement on the map.
    }
    GenerateNewObj();
  }

  // New Object generation function:
  void GenerateNewObj() {
    if (player1.transform.position.x > Object2.transform.position.x) {
      var temporaryObject = Object1;
      Object1 = Object2;
      Object2 = Object3;
      Object3 = Object4;
      Object4 = Object5;
      Object5 = Object6;
      Object6 = Object7;
      Object7 = Object8;
      Object8 = Object9;
      Object9 = Object10;

      SetTransform(temporaryObject, Object9.transform.position.x);
      Object10 = temporaryObject;

    //  Debug.Log("somethingsfdsa");

    }
  }

  }
