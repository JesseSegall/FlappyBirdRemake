using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LogicScript : MonoBehaviour
{
  [SerializeField] private int playerScore;
  [SerializeField] private Text scoreText;
[ContextMenu("Increase Score")]
  public void AddScore() {
    playerScore += 1;
    scoreText.text = playerScore.ToString();
  }
  
  
}
