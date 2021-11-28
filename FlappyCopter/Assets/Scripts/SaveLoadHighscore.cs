using UnityEngine;
using UnityEngine.UI;

public class SaveLoadHighscore : MonoBehaviour
{
    public Text textHighscore;

    void Start() {
        textHighscore.text = "Highscore = " + LoadHighScore().ToString();
    }

    public static int LoadHighScore() {
        int hg=0;
        if(!PlayerPrefs.HasKey("Highscore"))
            PlayerPrefs.SetInt("Highscore", 0);
        else
            hg = PlayerPrefs.GetInt("Highscore");
        return hg;
    }

    public static void SaveHighscore(int score) {
        int hg = 0;
        if(!PlayerPrefs.HasKey("Highscore"))
            PlayerPrefs.SetInt("Highscore",0);
        else {
            hg = PlayerPrefs.GetInt("Highscore");
            hg += score;
            PlayerPrefs.SetInt("Highscore",hg);
        }
    }
}
