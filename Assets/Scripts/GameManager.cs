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
            ball.Launch(GetRandomBallDirection());
        }
        else if (ball.transform.position.x < minx)
        {
            scoreP2++;
            ui.UpdateScore(scoreP1, scoreP2);
            ball.Reset();
            ball.Launch(GetRandomBallDirection());
        }
    }

    Vector3 GetRandomBallDirection()
    {
        float x = 1;
        float y = 1;
        if (Random.Range(0, 2) == 0)
        {
            x = -1f;
        }
        if (Random.Range(0, 2) == 0)
        {
            y = -1f;
        }
        Vector3 dir = new Vector3(x, y, 0);
        return dir;
    }

}
