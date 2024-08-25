using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBarScript : MonoBehaviour
{
    public float playerType;
    public Rigidbody2D rb;
    private float moveSpeed = 8;
    private float highestPoint = 3.742f;
    private float lowestPoint = -3.742f;

    private KeyCode moveUpKey;
    private KeyCode moveDownKey;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerType == 1)
        {
            moveUpKey = KeyCode.W;
            moveDownKey = KeyCode.S;
        } 
        else if (playerType == 2)
        {
            moveUpKey = KeyCode.UpArrow;
            moveDownKey = KeyCode.DownArrow;
        }

        MoveUpPlayerBar();
        MoveDownPlayerBar();

    }

    private void MoveUpPlayerBar()
    {
        if (Input.GetKey(moveUpKey) && transform.position.y <= highestPoint)
        {
            transform.position = transform.position + (Vector3.up * moveSpeed) * Time.deltaTime;
        }
    }
    private void MoveDownPlayerBar()
    {
        if (Input.GetKey(moveDownKey) && transform.position.y >= lowestPoint)
        {
            transform.position = transform.position + (Vector3.down * moveSpeed) * Time.deltaTime;
        }
    }
}
