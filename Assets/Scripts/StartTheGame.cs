using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


/**
 * This component start the game when player presses the space bar.
 */
public class StartTheGame : MonoBehaviour
{

    [SerializeField] string sceneName;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
