using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private static float highScore = 0f;

    public static float HighScore
    {
        get { return highScore; }
        set
        {
            if (value > highScore)
            {
                highScore = value;
                
            }
        }
    }

    
}
