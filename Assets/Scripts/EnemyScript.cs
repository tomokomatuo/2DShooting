using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public GameObject explosion;
    private float phase;
    // Start is called before the first frame update
    void Start()
    {
      phase = Random.Range(0f, Mathf.PI *2);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(
            Mathf.Cos(Time.frameCount * 0.05f + phase) * 0.05f,
        　　 -2f * Time.deltaTime,
        　　 0f);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Bullet"))
        {
          Instantiate(explosion, transform.position, transform.rotation);
          Destroy(collision.gameObject);
          Destroy(gameObject);
        }
        if(collision.gameObject.CompareTag("Player"))
        {
          Instantiate(explosion, transform.position, transform.rotation);
          Instantiate(explosion, collision.transform.position, collision.transform.rotation);
          Destroy(collision.gameObject);
          Destroy(gameObject);
        }
    }
}
