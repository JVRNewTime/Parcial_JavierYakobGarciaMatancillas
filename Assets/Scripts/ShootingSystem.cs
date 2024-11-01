using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingSystem : MonoBehaviour
{
    [SerializeField] public float bulletVelocity;
    [SerializeField] public float shootingDelay;
    [SerializeField] public GameObject bullet;
    [SerializeField] public Transform bulletSpawn;
    public bool _readyToShoot = false;

    void Update()
    {
        Shoot();
    }

    private void Shoot(){
        if (Input.GetMouseButton(0) && !_readyToShoot){
            StartCoroutine(ShootCooldown());
            SpawnBullet();
        }
    }

    private IEnumerator ShootCooldown(){
        _readyToShoot = true;
        yield return new WaitForSeconds(shootingDelay);
        _readyToShoot = false;
    }

    private void SpawnBullet(){
        GameObject clone = Instantiate(bullet, bulletSpawn.position, Quaternion.identity);

        clone.GetComponent<Rigidbody>().AddForce(bulletSpawn.forward * bulletVelocity, ForceMode.Impulse);
        Destroy(clone, 5);
    }
}
