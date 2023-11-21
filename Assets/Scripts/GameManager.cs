using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    Spawner spawner;
    enum State { StateA, StateB, StateC };
    private State currentState;

    private void Awake()
    {
        spawner = GetComponent<Spawner>();
    }
    // Start is called before the first frame update
    void Start()
    {
        currentState = State.StateA;
        Debug.Log(currentState);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void ChangeState()
    {

        switch (currentState)
        {
            case State.StateA:
                currentState = State.StateB;
                spawner.Spawn();
                Debug.Log(currentState);
                break;

            case State.StateB:
                currentState = State.StateC;
                Debug.Log(currentState);
                break;
            case State.StateC:
                currentState = State.StateA;
                Debug.Log(currentState);
                break;
        };
    }

    void Idle()
    {

    }

}
