﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bird : MonoBehaviour
{
    Vector3 _initialPosition;
    bool _birdLaunched = false;
    float _timeIdle;
    [SerializeField] float _launchPower = 500;
    
    private void Awake() 
    {
        _initialPosition = transform.position;
    }

    private void Update() 
    {
        GetComponent<LineRenderer>().SetPosition(1, _initialPosition);
        GetComponent<LineRenderer>().SetPosition(0, transform.position);
        if (_birdLaunched && GetComponent<Rigidbody2D>().velocity.magnitude <= 0.1)
        {
            _timeIdle += Time.deltaTime;
        }
        if (transform.position.y < -10 || 
        transform.position.y > 10 || 
        transform.position.x < -50 ||
        transform.position.x > 30 || 
        _timeIdle >= 5)
        {
            string currentSceneName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(currentSceneName);
        }
    }

    private void OnMouseDown()
    {
        GetComponent<LineRenderer>().enabled = true;
    }
    
    private void OnMouseUp() 
    {

        Vector2 directionToInitialPosition = _initialPosition - transform.position;

        GetComponent<Rigidbody2D>().AddForce(directionToInitialPosition * _launchPower);
        GetComponent<Rigidbody2D>().gravityScale = 1;
        
        _birdLaunched = true;
        GetComponent<LineRenderer>().enabled = false;
    }
    
    private void OnMouseDrag() 
    {
        Vector2 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = newPosition;
        
    }
}
