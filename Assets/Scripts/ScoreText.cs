using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    public Transform playerTransform;

    public Transform startPointTransform;
    public Text scoreText;

    void Start()
    {
        GameObject playerObject = GameObject.Find("Player");
        playerTransform = playerObject.GetComponent<Transform>();

        GameObject scoreObject = GameObject.Find("ScoreText");
        scoreText = scoreObject.GetComponent<Text>();

        GameObject startPointObject = GameObject.Find("PlayerStartPoint");
        startPointTransform = startPointObject.GetComponent<Transform>();

    }
    void Update()
    {
        float distance = Vector3.Distance(playerTransform.position, startPointTransform.position);
        scoreText.text = distance.ToString("0");
    }
}
