using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int score = 0;

    public void AddPoints()
    {
        //increasing score by one, posting a debug.
        score++;
        Debug.Log("Score: " + score);
    }
}
