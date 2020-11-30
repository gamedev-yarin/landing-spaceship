using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


[RequireComponent(typeof(Collider))]
/**
 *  This component is responsible for moving the player to the next stage and checking that the player has completed the stage
 */


public class VictoryDetector : MonoBehaviour
{

    [SerializeField] string triggeringTag = null;
    [SerializeField] uint Countdown = 3;
    [SerializeField] GameObject text = null;
    [SerializeField] string NextSceneName;


    protected bool stillCollisio = false;
    protected TextMeshPro textField;
    protected uint num = 1;


    private void Start()
    {
        textField = text.GetComponent<TextMeshPro>();
        Debug.Log("VictoryDetector - Started");
    }


    void OnTriggerEnter(Collider collision)
    {
        Debug.Log("VictoryDetector - OnCollisionEnter");
        if (collision.gameObject.tag == triggeringTag)
        {
            stillCollisio = true;
            num = Countdown;
            textField.text = num.ToString();
            StartCoroutine(waitSecond());


        }
    }


    void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag == triggeringTag)
        {
            stillCollisio = false;
        }
    }

    private IEnumerator waitSecond()
    {
        while (!textField.text.ToString().Equals("0") && stillCollisio)
        {
            yield return new WaitForSeconds(1);
            num--;
            textField.text = num.ToString();
        }
        if (!stillCollisio)
        {
            textField.text = "";
        }
        if(textField.text.ToString().Equals("0") && stillCollisio) SceneManager.LoadScene(NextSceneName);
    }
}