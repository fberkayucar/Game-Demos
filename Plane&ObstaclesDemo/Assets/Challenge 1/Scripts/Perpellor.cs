using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perpellor : MonoBehaviour
{
    public Vector3 _rotate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(_rotate * Time.deltaTime);
    }
}
