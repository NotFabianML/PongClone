using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalPlayer1 : MonoBehaviour
{
    public LogicScript logic;
    public BallBounceScript ball;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        ball = GameObject.FindGameObjectWithTag("Ball").GetComponent<BallBounceScript>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            if (gameObject.name == "Goal Player 1")
            {
                logic.addScore(2, 1);
            }
            else if (gameObject.name == "Goal Player 2")
            {
                logic.addScore(1, 1);
            }

            ball.ResetBall();
        }
    }
}
