using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject[] grounds;
    public float groundNumber;

    private void Start()
    {
        grounds = GameObject.FindGameObjectsWithTag("Ground");
    }

    private void Update()
    {
        groundNumber = grounds.Length;
    } 

    public void LevelUpdate()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
