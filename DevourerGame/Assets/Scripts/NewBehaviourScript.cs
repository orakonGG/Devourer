using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class NewBehaviourScript : MonoBehaviour
{
    public GameObject endPanel;
    public bool endVis;
    // Start is called before the first frame update
    void Start()
    {
        endVis = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void TransitionScene(int level)
    {
        SceneManager.LoadScene(level);
    }
}
