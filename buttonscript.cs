using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonscript : MonoBehaviour
{
    public string LevelToLoad;

    // Start is called before the first frame update

    
    public void LoadLevel()
    {

        Application.LoadLevel(LevelToLoad);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        //SceneManager.LoadScene("level1");
    }
   
}
