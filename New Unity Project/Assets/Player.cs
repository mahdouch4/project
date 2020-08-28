using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UI;


public class Player : MonoBehaviour
{
    public Transform wood;
    Vector3 mousepos;
    public Camera cam;
    public float movespeed =12;
    public float highscore;
    bool shit;
    bool superSpeed;
    public Collider2D myCollider;
    public GameObject background;
    //public AudioSource audioSource;
    
    //AudioSource audioData;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector3(1, 1, 0) * movespeed;
        highscore = PlayerPrefs.GetFloat("highscore");
        Debug.Log(highscore);
       
        
    }

    // Update is called once per frames
    void Update()
    {
        //audioData = GetComponent<AudioSource>();
        mousepos = cam.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetKey(KeyCode.Space) && !shit)
            
        {
            

            superSpeed = true;
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, 5, 0) * movespeed;
            background.transform.localScale = new Vector3(background.transform.localScale.x, background.transform.localScale.y + 90, background.transform.localScale.z);
            CancelInvoke();
            Invoke("removeability", 4);
            Invoke("Resetability", 64);
            myCollider.enabled = false;
            shit = true;
            
        }
        if (superSpeed)
        {
            wood.position =  new Vector3(0,transform.position.y+25,0);
        }
       
    }
    public void removeability()
    {
        {
            GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, 1, 0) * movespeed;
            superSpeed = false;
            myCollider.enabled = true; 
            wood.position =  new Vector3(0,transform.position.y+25,0);
            background.transform.localScale = new Vector3(background.transform.localScale.x, background.transform.localScale.y - 90, background.transform.localScale.z);
            
        }
    }
    public void Resetability()
    {
        shit = false;
    }


    //private void OnTriggerExit2D(Collider2D other)
    //{


    //    if (superSpeed && !other.gameObject.CompareTag("Walls"))
    //    {
    //        other.enabled = false;
    //    }

    //}

    //Save data to global control   
  

}
