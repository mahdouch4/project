using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class zoon : MonoBehaviour
{
    public Text score;
    public Transform P;
    public GameObject resetbutton;
    public GameObject menubutton;
    bool x;
    public float health;
    public float movespeed;
    public Text Health;
    public bool rang;
    public GameObject player;
    public Transform damageeffect;
    bool difficulty;
    public GameObject easy;
    public GameObject meduim;
    public GameObject hard;
    
    // Start is called before the first frame update
    void Start()
    {
        menubutton.SetActive(false);
        resetbutton.SetActive(false);
        Time.timeScale = 1;
        //PlayerPrefs.SetFloat("highscore", shit.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        score.text = P.position.y.ToString("0");
        if (difficulty == false)
        {
            Time.timeScale = 0;

        }
        if (difficulty == true)
        {
            
            Time.timeScale = 1;
            easy.SetActive(false);
            meduim.SetActive(false);
            hard.SetActive(false);
        }
        if (health <= 0)
        {

            menubutton.SetActive(true);
            resetbutton.SetActive(true);
            Time.timeScale = 0;

        }
        GetComponent<Rigidbody2D>().velocity = new Vector3(0, 1, 0) * movespeed;
        if (x == true)
        {
            health--;
        }
        Health.text = ((health / 100) + ((health / 100) * 2 / 3)).ToString("0");

        if (Input.GetKey(KeyCode.E) && !rang )
        {
          
           menubutton.SetActive(true);
            resetbutton.SetActive(true);
            Time.timeScale = 0;
             rang = true;

        }
        if (Input.GetKey(KeyCode.E) && rang  == true)
        {
            menubutton.SetActive(false);
            resetbutton.SetActive(false);
            Time.timeScale = 1;
            rang =  false;
        }
       





    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        
        if (col.tag == "Player")
        {
            damageeffect.position = new Vector3(damageeffect.position.x, damageeffect.position.y, damageeffect.position.z + 5);
            x = true;
        }
    }
    private void OnTriggerExit2D(Collider2D col)
    {

        if (col.tag == "Player")
        {
            damageeffect.position = new Vector3(damageeffect.position.x, damageeffect.position.y, damageeffect.position.z - 5);
            x = false;
        }

    }
    public void Sleep()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
   public void Reset()
        {
            SceneManager.LoadScene(1);

        }
    //public void Change()
    //{

    //    if (health <= 300)

    //    {
    //        GetComponent<Text>().color = Color.black;
    //    }
    //}
    public void Easy()
    {
        difficulty = true;
        easy.SetActive(false);
        
    }
    public void Meduim()
    {
        difficulty = true;
        meduim.SetActive(false);
        movespeed = 8.25f;
    }
    public void Hard()
    {
        
        difficulty = true;
        hard.SetActive(false);
        movespeed = 10;
    }

}


