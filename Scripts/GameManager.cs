using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update

    public List<GameObject> targets;

    public GameObject titleScreen;
    private float spawnRate = 1.0f;

    private int score;
    public TextMeshProUGUI scoretext;
    public TextMeshProUGUI gameOverText;
    public bool isGameActive;

    public Button restartButton;

    
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnTarget(){
        while(isGameActive){
        yield return new WaitForSeconds(spawnRate);
        int index = Random.Range(0, targets.Count);
        Instantiate(targets[index]);
        
        
        }
    
    }

    public void UpdateScore(int scoreToUpdate){

        score += scoreToUpdate;
        scoretext.text = "Score: " + score;

    }

    public void GameOver(){
        isGameActive = false;
        gameOverText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);

    }

    public void RestartGame(){

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    public void StartGame(int difficulty){

        isGameActive = true;
        StartCoroutine(SpawnTarget());
        score = 0;
        scoretext.text = "Score: " + score;
        titleScreen.gameObject.SetActive(false);
        spawnRate = spawnRate / difficulty;

    }
}
