using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public float speed = 1;
    private Rigidbody2D rig;
    public GameObject gameOver;
    public GameController sn;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {

            rig.velocity = Vector2.up * speed;
        }
    }

    void OnCollisionEnter2D(Collision2D collisor){
        sn = gameObject.GetComponent<GameController>();
        gameOver.SetActive(true);
        Time.timeScale = 0;
    }

}
