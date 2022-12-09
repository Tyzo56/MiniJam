using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int score;
    [SerializeField] TMP_Text scoreText;

    private void Update()
    {
        scoreText.text = score.ToString();
    }
}
