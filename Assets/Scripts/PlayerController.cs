using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] public float velocity;
    private float _axisHorizontal;
    private Rigidbody _rb;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move(){
        _axisHorizontal = Input.GetAxis("Horizontal");
        _rb.velocity = new Vector2(_axisHorizontal * velocity, _rb.velocity.y);
    }
}
