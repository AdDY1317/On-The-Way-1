using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public Rigidbody2D rigidbody2d;
    public float speed;
    public GameObject gameWonPanel;
    public GameObject gameLostPanel;
    public GameObject enemy;
    Enemy _enemy;

    public bool isGameOver = false;

     void Awake()
    {
        _enemy = enemy.GetComponent<Enemy>();
    }
    // Start is called before the first frame update
    void Start()
    {
        _enemy.movement();
    }

    // Update is called once per frame
    void Update()
    {
       
        if(isGameOver== true)
        {
            return;
          
        }
        if (Input.GetAxis("Horizontal") > 0)  //it is positive---right and left
        {
            rigidbody2d.velocity = new Vector2(speed, 0f);
        }
        else if (Input.GetAxis("Horizontal") < 0)   //it is negative 
        {
            rigidbody2d.velocity = new Vector2(-speed, 0f);
        }
        else if (Input.GetAxis("Vertical") > 0)  //it is positive---right and left
        {
            rigidbody2d.velocity = new Vector2(0f, speed);
        }
        else if (Input.GetAxis("Vertical") < 0)   //it is negative 
        {
            rigidbody2d.velocity = new Vector2(0f, -speed);
        }
        else if (Input.GetAxis("Vertical") == 0 && Input.GetAxis("Horizontal") == 0)  // stop
        {
            rigidbody2d.velocity = new Vector2(0f, 0f);
        }
    } 
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Door")
        {
            Debug.Log("level complete");
            gameWonPanel.SetActive(true);
            isGameOver = true;
            
            
        }
        else if (other.tag == "Enemy")
        {
            Debug.Log("You Died");
            gameLostPanel.SetActive(true);
            isGameOver = true;
        }
        else if (other.tag == "Maze")
        {
            Debug.Log("You Died");
            gameLostPanel.SetActive(true);
            isGameOver = true;
           
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
        Debug.Log("Button");
    }
     public void NextGame()
    {
        SceneManager.LoadScene(2);
        Debug.Log("Button");
    }
    public void LastGame()
    {
        SceneManager.LoadScene(3);
        Debug.Log("Button");

    }

}
