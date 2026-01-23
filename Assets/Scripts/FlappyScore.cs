using UnityEngine;
using TMPro;

public class FlappyScore : MonoBehaviour
{
    int points = 0;
    TextMeshProUGUI Points;

    void Awake(){
        Points = GetComponent<TextMeshProUGUI>();
    }

    public void AddPoints(){
        points++;
		Points.text = points.ToString();
	}


}
