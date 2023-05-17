using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5f;

    public new Rigidbody2D rigidbody2D;
    public Animator animator;
    public int health;
    public int hunger;
    public int energy;
    public int coin;
    public string scene;
    Vector2 movement;
    public bool goodEndingTracker;
    public bool carriedFurniture;

    public void PlayerD()
    {
        health = PlayerPrefs.GetInt("save");
        hunger = PlayerPrefs.GetInt("save1");
        energy = PlayerPrefs.GetInt("save2");
        coin = PlayerPrefs.GetInt("money");
        scene = SceneManager.GetActiveScene().name;
    }
   
    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
        PlayerD();
        Save();
    }
    public void Save()
    {
        SaveSystem.SavePlayer(this);
    }

    public bool GetEnding(){
        if (PlayerPrefs.GetInt("Ending").Equals(1))
        {
            goodEndingTracker = true;
        }
        else
        {
            goodEndingTracker = false;
        }
        return goodEndingTracker;
    }

    public void SetEnding(bool ending){
        goodEndingTracker = ending;
        if (ending == true)
        {
            PlayerPrefs.SetInt("Ending", 1);
        }
        else
        {
            PlayerPrefs.SetInt("Ending", 0);
        }
        
    }

    public bool GetFurn(){
        if (PlayerPrefs.GetInt("carried").Equals(1))
        {
            carriedFurniture = true;
        }
        else
        {
            carriedFurniture = false;
        }
        return carriedFurniture;
    }

    public void SetFurn(bool furn){
        carriedFurniture = furn;
        if (furn == true)
        {
            PlayerPrefs.SetInt("carried", 1);
        }
        else
        {
            PlayerPrefs.SetInt("carried", 0);
        }

    }

    void FixedUpdate()
    {
        rigidbody2D.MovePosition(rigidbody2D.position + movement * speed * Time.fixedDeltaTime);
    }
}
