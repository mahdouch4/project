using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projecttiles : MonoBehaviour
{
    public float movespeed = 20;
    public GameObject line;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector3(0, 1, 0) * movespeed;
    }
    
}
