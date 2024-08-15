// Copyright (c) 2012-2024 FuryLion Group. All Rights Reserved.

using TMPro;
using UnityEngine;

public sealed class ScoreCounter : MonoBehaviour
{
    public static ScoreCounter Instance { get; private set; }

    private int _score;
    [SerializeField] private TextMeshProUGUI scoreText;

    public int Score
    {
        get => _score;
        set
        {
            if (_score != value)
            {
                _score = value;
                scoreText.SetText($"Score = {_score}");
            }
        }
    }

    private void Awake() => Instance = this;
}