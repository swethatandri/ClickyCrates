using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyButton : MonoBehaviour
{
    // Start is called before the first frame update

    private Button diffButton;
    private GameManager gameManager;
    public int difficulty;
    void Start()

    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        diffButton = GetComponent<Button>();
        diffButton.onClick.AddListener(SetDifficulty);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetDifficulty(){

        Debug.Log(gameObject.name + " was clicked");
        gameManager.StartGame(difficulty);
        
    }
}
