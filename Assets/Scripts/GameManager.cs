using UnityEngine;

public class GameManager : MonoBehaviour
{
   private int score; 

   private void GameOver()
   {
    Debug.Log("Game over");
   }

   private void IncreaseScore()
   {
    score++;
   }
}
