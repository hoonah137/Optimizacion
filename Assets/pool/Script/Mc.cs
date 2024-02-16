using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mc : MonoBehaviour
{

    [SerializeField] Transform gunPosition;

    [SerializeField] GameObject bulletPrefab;

    [SerializeField] int bulletType = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject bullet = PoolManager.Instance.GetPooledObjects(bulletType, gunPosition.position, gunPosition.rotation);
            if (bullet != null)
            {
                bullet.SetActive(true);
            }

            else
            {
                Debug.LogError("Pool demasiado chiko");
            }
        }

    }
}
