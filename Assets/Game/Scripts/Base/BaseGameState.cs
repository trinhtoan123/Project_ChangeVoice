using Common;
using UnityEngine;

public class BaseGameState : MonoBehaviour
{

    private void Awake()
    {
        Observer.Instance.AddObserver(ObserverKey.GameStateUpdated, UpdateGameState);
        Observer.Instance.AddObserver(ObserverKey.GamePhaseUpdated, UpdateGamePhase);
    }

    private void UpdateGameState(object data)
    {
        GameStateChanged();
    }

    private void UpdateGamePhase(object data)
    {
        GamePhase gamePhase = (GamePhase)data;
        GamePhaseChanged(gamePhase);
    }

    protected virtual void GameStateChanged()
    {

    }

    protected virtual void GamePhaseChanged(GamePhase gamePhase)
    {

    }

    protected virtual void OnEnable() { }

    protected virtual void OnDestroy()
    {
        Observer.Instance.RemoveObserver(ObserverKey.GameStateUpdated, UpdateGameState);
        Observer.Instance.RemoveObserver(ObserverKey.GamePhaseUpdated, UpdateGamePhase);
    }
}
