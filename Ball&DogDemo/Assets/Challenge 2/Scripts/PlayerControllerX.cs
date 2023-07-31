using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogProjectile;
    public float fireDelay = 20.0f;

    private void Start()
    {
        
    }

    void Update()
    {
        fireDelay -= 0.1f;
        if (Input.GetKeyDown(KeyCode.Space)&&fireDelay<=0)
        {
            Instantiate(dogProjectile, transform.position, transform.rotation);
            fireDelay = 20.0f;
        }
    }
}
