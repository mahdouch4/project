using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mapscrolling : MonoBehaviour
{
    public GameObject player;
    Vector3 obsatclesppoint;
    public GameObject obstacle;
    float y;
    float x;
    float score;
    float doubles;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        score  = player.transform.position.y;
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        
        if (col.gameObject.tag == "Player")
        {
            transform.position += Vector3.up * 25;
            for (int i = 0; i < Random.Range(4,8); i++)
            {
                y = Random.Range(transform.position.y - 5, player.transform.position.y + 5);
                x = Random.Range(-8, 9);
                obsatclesppoint = new Vector3(x, y, 0);
                Instantiate(obstacle, obsatclesppoint, Quaternion.identity);

            }
        }
    }
    



}
