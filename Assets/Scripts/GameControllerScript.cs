using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerScript : MonoBehaviour
{
    public GameObject enemy;
    // Start is called before the first frame update
    IEnumerator SpawnEnemy()
    {
　　　　　while(true)


    {
      Instantiate(
          enemy,
          new Vector3(Random.Range(-12.8f, 12.8f), transform.position.y, 0f),
          transform.rotation
          );
          yield return new WaitForSeconds(0.5f);
    }
    }
    void Start()
    {
        StartCoroutine("SpawnEnemy");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
