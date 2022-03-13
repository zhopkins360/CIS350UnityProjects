using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class triggerZone : MonoBehaviour
{
    public Text textbox;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("collision");
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("inside if");
            textbox.text = "YOU WIN\nYou are now the Boss make the money";
        }
    }
}
