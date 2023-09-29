using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    public float currentMoney;
    /*
    [Header("Hamburger")]
    public float hamburgerPrice = 100f;
    public float hamburgerHealthProvides = 90f;
    private float hamburgerHungerProvides = 100f;


    [Header("Salad")]
    public float saladPrice = 20f;
    public float saladHealthProvides = 15f;
    private float saladHungerDecreases = 30f;

    [Header("Tomato")]
    public float tomatoPrice = 10f;
    public float tomatoHealthProvides = 10;
    private float tomatoHungerDecreases = 20f;

    [Header("Pizza")]
    public float pizzaPrice = 80f;
    public float pizzaHealthProvides = 70;
    private float pizzaHungerDecreases = 80f;
    */

    // Start is called before the first frame update
    void Start()
    {
        currentMoney = 500;
}

    // Update is called once per frame
    void Update()
    {
        
    }
	private void OnCollisionEnter2D(Collision2D collision)
	{
        if (collision.gameObject.tag == "Player" && Input.GetKey("E")) {
            //oyuncumuz bir food objesiyle karþýlaþtýðýnda ve e tuþuna bastýðýnda parasý azalsýn, açlýðýmýz giderilsin ve can dolsun 


        }
    }
}
