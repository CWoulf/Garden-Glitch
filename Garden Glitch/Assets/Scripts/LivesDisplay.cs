using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LivesDisplay : MonoBehaviour
{
    [SerializeField] int lives = 10;
    Text livesText;
    void Start()
    {
        livesText = GetComponent<Text>();
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        livesText.text = lives.ToString();
    }

    public void LoseLives()
    {
        lives -= 1;
        UpdateDisplay();

        if(lives <= 0)
        {
            FindObjectOfType<LevelLoader>().LoadYouLose();
        }
    }
}
