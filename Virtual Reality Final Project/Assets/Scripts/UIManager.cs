using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    public Text _scoreText;
    void Start()
    {
        _scoreText.text = "Score: " + 0;
    }
    public void updateScore(int playerScore)
    {
        _scoreText.text = "Score: " + playerScore.ToString();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
