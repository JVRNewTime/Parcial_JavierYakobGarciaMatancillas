using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSystem : MonoBehaviour
{
    private void OnCollisionEnter(Collision collisionObject) {
        if (collisionObject.gameObject.CompareTag("Asteroids")){
            Destroy(collisionObject.gameObject);
            GameManager.Instance.points ++;
        }
        Destroy(this.gameObject);
    }
}
