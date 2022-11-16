using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    [SerializeField] private GameObject fruitObject;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private TMP_Text scoreText;

    private int score = 0;


    public void SpawnFood()
    {
        Instantiate(fruitObject, spawnPoint.position, spawnPoint.rotation);
    }

    public void DisplayScore()
    {
        //Add score
        score++;

        //Display the score
        scoreText.SetText("" + score);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
