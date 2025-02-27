using UnityEngine;

public class SceneController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField]
    private GameObject enemyPrefab;
    private GameObject enemy;
    private Vector3 spawnPoint = new Vector3(0, 0, 5);

    private const int numEnemies = 3;
    private GameObject[] enemies;

    [SerializeField] WanderingIguana iguana;
    private GameObject[] iguanas;
    private void Start()
    {
        //enemyPrefab = GetComponent<GameObject>();
        //enemy = Instantiate(enemyPrefab as GameObject);
        enemies = new GameObject[numEnemies];
        
        //enemies = {enemyPrefab as GameObject, enemyPrefab as GameObject, enemyPrefab as GameObject};
    }
    // Update is called once per frame
    void Update()
    {
        
        for (int i = 0; i < numEnemies; i++)
        {
            //Debug.Log("enemies array at:" + i + " is "+ enemies[i] == null);
            if (enemies[i] == null)
            {
                enemy = Instantiate(enemyPrefab as GameObject);
                enemy.transform.position = spawnPoint;
                float angle = Random.Range(0, 360);
                enemy.transform.Rotate(0, angle, 0);
                enemies[i] = enemy;
            }
        }
        
    }
}
