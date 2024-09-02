using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScoreManager : MonoBehaviour
{
    
    public List<HighScoreElement> HighScoreList = new List<HighScoreElement>();

    private int maxCount = 10;


    public void AddHighScore(HighScoreElement highScore)
    {
        for (int i = 0; i < maxCount; i++)
        {
            if (i >= HighScoreList.Count || highScore.points > HighScoreList[i].points)
            {
                HighScoreList.Insert(i, highScore);

                while (HighScoreList.Count > maxCount)
                {
                    HighScoreList.RemoveAt(maxCount);
                }
                
                break;
            }
        }
    }
}
