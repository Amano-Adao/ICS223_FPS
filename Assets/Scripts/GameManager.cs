using UnityEngine;

public class GameManager : MonoBehaviour
{
    //[SerializeField] private Ball ball;
    

    [SerializeField] Ball2 ball;
    [SerializeField] UIManager ui;
    float maxX = 13;
    float minx = -13;

    int scoreP1 = 0;
    int scoreP2 = 0;
    private string vertInputAxix = "VerticalP1";
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ball.Reset();
    }

    // Update is called once per frame
    void Update()
    {
        if (ball.transform.position.x > maxX)
        {
            scoreP1++;
            ui.UpdateScore(scoreP1, scoreP2);
            ball.Reset();
        }
        else if (ball.transform.position.x < minx)
        {
            scoreP2++;
            ui.UpdateScore(scoreP1, scoreP2);
            ball.Reset();
        }
    }


    
}
