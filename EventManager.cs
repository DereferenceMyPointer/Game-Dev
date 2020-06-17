using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public static EventManager Instance;
    public int livesRemaining;

    //enumerate death cycle
    public enum PlayerState
    {

    };

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    public void PlayerDeath()
    {
        livesRemaining--;
        if (livesRemaining < 0)
        {
            //run out of lives mechanic
        }
    }

}
