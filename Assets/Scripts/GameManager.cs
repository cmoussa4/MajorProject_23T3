using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameState State;

    int packages = 0;
    [SerializeField] TextMeshProUGUI packCount;
    bool packHeld = false;
    [SerializeField] TextMeshProUGUI packDisplay;
    SpriteRenderer spriteRender;
    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        UpdateGameState(GameState.Idle);
    }

    public void UpdateGameState(GameState newState)
    {
        State = newState;

        switch (newState)
        {
            case GameState.Idle:
                break;
            case GameState.DrivingWithNoPackage:
                break;
            case GameState.DrivingWithPackage:
                break;
            case GameState.PackageDelivered:
                break;
            
                
        };
    }
    public enum GameState
    {
        Idle,
        DrivingWithNoPackage,
        DrivingWithPackage,
        PackageDelivered
    }


}
