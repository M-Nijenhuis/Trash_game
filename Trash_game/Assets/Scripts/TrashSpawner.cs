using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = System.Random;

public class TrashSpawner : MonoBehaviour
{
  public GameObject[] trashPrefabs;
  public float spawnInterval = 2f;
  private float timer = 0f;

  // Start is called before the first frame update
  void Start()
  {
    SpawnTrashObject();
  }
  
  // Update is called once per frame
  void Update()
  {
    if (timer < spawnInterval)
    {
      timer = timer + Time.deltaTime;
    }
    else
    {
      SpawnTrashObject();
      timer = 0;
    }
  }


  private void SpawnTrashObject()
  {
    int index = UnityEngine.Random.Range(0, trashPrefabs.Length);
    GameObject TrashToSpawn = trashPrefabs[index]; 
    Instantiate(TrashToSpawn, new Vector2(transform.position.x, 0), transform.rotation);
  }
}
