using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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
    Vector2 movement;
    public void PlayerD()
    {
        health = PlayerPrefs.GetInt("save");
        hunger = PlayerPrefs.GetInt("save1");
        energy = PlayerPrefs.GetInt("save2");
        coin = PlayerPrefs.GetInt("money");
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

    void FixedUpdate()
    {
        rigidbody2D.MovePosition(rigidbody2D.position + movement * speed * Time.fixedDeltaTime);
    }
}
