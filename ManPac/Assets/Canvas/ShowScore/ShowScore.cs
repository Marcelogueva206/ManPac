using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.TextCore.Text;
using UnityEngine;
using UnityEngine.UI;


public class ShowScore : MonoBehaviour
{

    TextMeshProUGUI showScoreUI;
    // Start is called before the first frame update
    void Start()
    {
        showScoreUI= GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        showScoreUI.text = ScoreManager.Score.ToString();
    }
}
