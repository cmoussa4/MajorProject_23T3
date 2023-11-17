using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    enum State { StateA,StateB,StateC};
    private State currentState;

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

          switch(currentState)
        {
            case State.StateA:
                currentState = State.StateB;                               
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


}
