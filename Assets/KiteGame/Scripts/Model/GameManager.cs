using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameState state;

    public static event Action<GameState> onGameStateChanged;

    private void Awake()
    {
        instance = this;
    }

    public void UpdateGameState(GameState newState)
    {
        // update the state
        state = newState;

        switch (newState)
        {
            case GameState.ShowingPath:
                break;
            case GameState.Starting:
                break;
            case GameState.Playing:
                break;
            case GameState.Paused:
                break;
            case GameState.MainMenu:
                break;
        }

        // trigger state changed event to subscribed scripts
        onGameStateChanged?.Invoke(newState);
    }


    void Start()
    {
        UpdateGameState(GameState.MainMenu);
    }
}

public enum GameState
{
    ShowingPath,
    Starting,
    Playing,
    Paused,
    MainMenu
}