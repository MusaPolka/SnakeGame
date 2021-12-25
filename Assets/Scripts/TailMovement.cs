using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TailMovement : MonoBehaviour
{
    public float Speed;
    public SnakeMovement mainSnake; 
    public Vector3 TailTarget;
    public GameObject TailTargetObj;
    public int indx;
    void Start()
    {
        mainSnake = GameObject.FindGameObjectWithTag("MainSnake").GetComponent<SnakeMovement>();
        Speed = mainSnake.Speed + 1;
        TailTargetObj = mainSnake.tailObjects[mainSnake.tailObjects.Count - 2];
        indx = mainSnake.tailObjects.IndexOf(gameObject);
    }

    void Update()
    {
        TailTarget = TailTargetObj.transform.position;
        
        transform.LookAt(TailTarget);
        transform.position = Vector3.Lerp(transform.position, TailTarget, Time.deltaTime * Speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MainSnake"))
        {
            if (indx > 2)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
