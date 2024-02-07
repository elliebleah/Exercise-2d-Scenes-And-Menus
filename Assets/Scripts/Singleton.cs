using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton : MonoBehaviour
{
    // Start is called before the first frame update


    public Score score;

    public static Singleton singleton;

    //private
    void Awake()
    {
        singleton = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void notifyScoreChange(int points)
    {
        score.AddScore(points);
    }


    public int notifyGetScore()
    {
        return score.getScore();
    }
}
