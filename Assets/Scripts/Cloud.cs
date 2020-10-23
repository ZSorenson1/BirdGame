using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : MonoBehaviour
{
    Vector2 _respawnPoint;
    int moveSpeed = 1;
    [SerializeField] Vector2 moveVector;

    private void Awake() 
    {
        _respawnPoint = new Vector2(-22, transform.position.y);
    }

    void Update()
    {
        transform.Translate(moveVector * moveSpeed * Time.deltaTime);
        if(transform.position.x > 20)
        {
            transform.position = _respawnPoint;
        }
    }
}
