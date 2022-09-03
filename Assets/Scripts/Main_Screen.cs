using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Screen : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void playGame()
    {
        SceneManager.LoadScene(1);
        Debug.Log("Play");
    }

    public void exitGame()
    {
        Application.Quit();
        Debug.Log("Application Quit");
    }

    public void NextGame()
    {
        SceneManager.LoadScene(2);
        Debug.Log("Next Level");
    }
}
