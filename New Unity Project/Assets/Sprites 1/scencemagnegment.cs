using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class scencemagnegment : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
       
        
        
    }
    public void Update()
    {
        
    }
    
    public void Relay()
    {
        SceneManager.LoadScene(1);
    }
    public void shit()
    {
        Application.Quit();
    }
    public void credits()
    {
        SceneManager.LoadScene(2);
    }
    public void returmenu()
    {
        SceneManager.LoadScene(0);
    }
    public void level1()
    {
        SceneManager.LoadScene(4);
    }
    public void level2()
    {
        SceneManager.LoadScene(5);
    }
    public void level3()
    {
        SceneManager.LoadScene(6);
    }
    public void level4()
    {
        SceneManager.LoadScene(7);
    }
    public void level5()
    {
        SceneManager.LoadScene(8);
    }
    public void level6()
    {
        SceneManager.LoadScene(9);
    }
    public void level7()
    {
        SceneManager.LoadScene(10);
    }
    public void level8()
    {
        SceneManager.LoadScene(11);
    }
    public void level9s()
    {
        SceneManager.LoadScene(12);
    }
    public void level10()
    {
        SceneManager.LoadScene(13);
    }

}
