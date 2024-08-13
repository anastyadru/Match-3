using TMPro;
using UnityEngine;

public sealed class ScoreCounter : MonoBehaviour
{
    public static ScoreCounter Instance { get; private set; }

    private int _score;

    public int Score
    {
        get => _score;

        set
        {
            
        }
    }
}