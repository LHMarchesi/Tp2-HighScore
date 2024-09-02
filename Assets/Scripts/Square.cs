using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour
{
    public void OnMouseDown()
    {
        int randomX = Random.Range(-8, 8);
        int randomY = Random.Range(-4, 4);
        this.transform.position = new Vector2(randomX, randomY);
        GameManager.instance.ScoreAddOne();
    }
}
