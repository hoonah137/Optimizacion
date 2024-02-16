using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float _bulletSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * _bulletSpeed * Time.deltaTime;
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        gameObject.SetActive(false);
    }
}
