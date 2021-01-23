using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartLevel1(){
        SceneManager.LoadScene("SampleScene");
    }
    public void StartLevel2(){
        SceneManager.LoadScene("SampleScene2");
    }

    public void Back(){
        SceneManager.LoadScene("Menu");
    }
}
