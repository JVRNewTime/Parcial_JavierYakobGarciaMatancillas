using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteAsteroids : MonoBehaviour
{
    private void OnCollisionEnter(Collision collisionObject) {
        if (collisionObject.gameObject.CompareTag("Asteroids")){
            Destroy(collisionObject.gameObject);
        }
    }
}
