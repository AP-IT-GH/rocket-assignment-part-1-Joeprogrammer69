using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HitLandingObject : MonoBehaviour
{
   
    public string LevelToLoad;
    
   // Collider m_ObjectCollider;

    //private GameObject allowedTrigger;
    // Start is called before the first frame update
    void Start()
    {
        /*
        m_ObjectCollider = GetComponent<Collider>();
        m_ObjectCollider.isTrigger = false;*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            Application.LoadLevel(LevelToLoad);
        }
        /*if (allowedTrigger.gameObject.tag == "Player")

        {
            SceneManager.LoadScene(LevelToLoad);
            gameObject.SetActive(true);
            m_ObjectCollider.isTrigger = true;

        }*/



    }
}
