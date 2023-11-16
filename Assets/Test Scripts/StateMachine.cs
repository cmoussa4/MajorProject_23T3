using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    enum State { StateA,StateB,StateC};
    private State currentState;
    [SerializeField] GameObject enemy;
    [SerializeField] GameObject player;
    [SerializeField] float chaseSpeed = 0.1f;
    private float dist;
    // Start is called before the first frame update
    void Start()
    {
        currentState = State.StateA;
        Debug.Log(currentState);
    }

    // Update is called once per frame
    void Update()
    {
        if (dist < 3f)
        {
            ChangeState();
        }
        else if(dist > 3f)
        {
            ChangeState();
        }
    }

    void ChangeState()
    {

          switch(currentState)
        {
            case State.StateA:
                currentState = State.StateB;
                               
                Debug.Log(currentState);
                break;

            case State.StateB:
                currentState = State.StateC;
                Chase();
                Debug.Log(currentState);
                break;
            case State.StateC:
                currentState = State.StateA;
                Debug.Log(currentState);
                break;
        };
    }

    void Chase()
    {
        dist = Vector2.Distance(enemy.transform.position, player.transform.position);
        if (dist <3f)
        {
            enemy.transform.position = Vector2.MoveTowards(enemy.transform.position, player.transform.position, chaseSpeed * Time.deltaTime);
        }
    }
}
