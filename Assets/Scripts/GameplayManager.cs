using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayManager : MonoBehaviour
{
    public static GameplayManager Instance;

    public GameplayState State;

    public static event System.Action<GameplayState> OnGameplayStateChange;
    // Start is called before the first frame update
    void Start()
    {
        GameplayStateUpdate(State);
    }

    private void Awake()
    {
        Instance = this;
        GameManager.OnGameStateChange += GameStarts;
        
    }
    private void OnDestroy()
    {
        GameManager.OnGameStateChange -= GameStarts;
    }

    public void GameplayStateUpdate(GameplayState newState)
    {
        State = newState;

        switch (newState)
        {
            case GameplayState.NoGameplay:

                break;
            case GameplayState.InitGameplay:

                break;
            case GameplayState.MapView:
               
                break;
            case GameplayState.Inventory:
                
                break;
            case GameplayState.Fight:
              
                break;
            default:
                throw new System.ArgumentOutOfRangeException(nameof(newState), newState, null);
        }
        print(newState);
        OnGameplayStateChange?.Invoke(newState);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void GameStarts(GameManager.GameState newState)
    {
       if(newState == GameManager.GameState.PlayGame) GameplayStateUpdate(State);
    }

    public enum GameplayState
    {
        NoGameplay,
        InitGameplay,
        MapView,
        Inventory,
        Fight
    }
}
