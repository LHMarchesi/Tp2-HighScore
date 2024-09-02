using System;

[Serializable]
public class HighScoreElement
{
    public string playerName;
    public float points;

    public HighScoreElement(string playerName, float points)
    {
        this.playerName = playerName;
        this.points = points;
    }
}
