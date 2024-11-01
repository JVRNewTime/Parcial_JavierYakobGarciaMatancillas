using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSystem : MonoBehaviour
{
    [SerializeField] List<GameObject> asteroids = new List<GameObject>();
    [SerializeField] float spawnTime;
    void Start()
    {
        StartCoroutine(Spawn());
    }
    IEnumerator Spawn(){
        while(true){
            Instantiate(asteroids[Random.Range(0, asteroids.Capacity)], new Vector3(Random.Range(-3, 3), transform.position.y, transform.position.z), transform.rotation);
            yield return new WaitForSeconds(spawnTime);
        }
    }
}
