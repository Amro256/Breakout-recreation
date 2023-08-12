using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; //Using TextMeshPro
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update

    //Refernce the UI score/lives text
    public GameObject ScoreText;
    public GameObject LiveText;
    public int Lives;
    private int Score;
    //Int for the score
    //Public static method to add to the score - its static, so the ball script can access it.
    public void P1Score()
    {   
        Score++;
        ScoreText.GetComponent<TextMeshProUGUI>().text = Score.ToString();
        
        
    }

    public void RemoveLife()
    {
        Lives--;
        LiveText.GetComponent<TextMeshProUGUI>().text = Lives.ToString();
        Debug.Log("Lives " + Lives); //Debug statement to check if code method is working correctly

        //if staement to deal with if the player has 0 lives left - game resets
        if(Lives <0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); //Reloads the current scene once the player has 0 lives 
        }
    }
    

    //Code to deal with the adding/updating the score and the UI
}
