using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LivesDisplay : MonoBehaviour
{
    [SerializeField] float baseLives = 3f;
    [SerializeField] int damage = 1;
    float lives = 10;
    Text livesText;
    void Start()
    {
        lives = baseLives - PlayerPrefsController.GetDifficulty();
        livesText = GetComponent<Text>();
        UpdateDisplay();
        Debug.Log("Difficulty setting is currently: " + PlayerPrefsController.GetDifficulty());
    }

    private void UpdateDisplay()
    {
        livesText.text = lives.ToString();
    }

    public void LoseLives()
    {
        lives -= damage;
        UpdateDisplay();

        if(lives <= 0)
        {
            FindObjectOfType<LevelController>().HandleLoseCondition();
        }
    }
}
