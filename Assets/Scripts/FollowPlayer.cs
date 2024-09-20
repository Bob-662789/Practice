using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform playerTransform;
    public Vector3 offset = new Vector3(0, 1, -8);

    // Start is called before the first frame update
    void Start()
    {
        GameObject playerObject = GameObject.Find("Player");
        playerTransform = playerObject.GetComponent<Transform>();
        Debug.Log($"camera movement start, assign player transform to {playerTransform.gameObject.name}");
    }

    // Update is called once per frame
    void Update()
    {
        // camera to follow player with offset
        transform.position = playerTransform.position + offset;
    }
}
