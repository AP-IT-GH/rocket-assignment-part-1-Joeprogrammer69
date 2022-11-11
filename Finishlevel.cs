using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static managerscript;

public class Finishlevel : MonoBehaviour
{
    //public string LevelToLoad;

    public GameObject Finishbutton;

   


    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            //Application.LoadLevel(LevelToLoad);
            Finishbutton.SetActive(true);
        }

        
                   
                   
                   


               

       

    }
}
