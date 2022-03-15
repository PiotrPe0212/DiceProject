using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public static bool GamePaused;

    public GameState State;

    public static event System.Action<GameState> OnGameStateChange;

    private void Awake()
    {
        Instance = this;
    }


    private void Start()
    {
        GameStateUpdate(State);
    }
    public void GameStateUpdate(GameState newState)
    {
        State = newState;

        switch (newState)
        {
            case GameState.MainMenu:
                StopGame();
                break;
            case GameState.PauseGame:
                StopGame();
                break;
            case GameState.PlayGame:
                Time.timeScale = 1;
                GamePaused = false;
                            break;
            case GameState.Lose:
                StopGame(); ;
                break;
            case GameState.Win:
                StopGame();
                break;
            default:
                throw new System.ArgumentOutOfRangeException(nameof(newState), newState, null);
        }
        print(newState);
        OnGameStateChange?.Invoke(newState);
    }


    private void StopGame()
    {
        Time.timeScale = 0;
        GamePaused = true;
    }

    public enum GameState
    {
        MainMenu,
        PauseGame,
        PlayGame,
        Lose,
        Win
    }
}
