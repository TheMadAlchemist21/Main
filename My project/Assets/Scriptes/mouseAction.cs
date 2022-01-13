using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class mouseAction : MonoBehaviour
{
    public GameObject obj;
    public Image rend;
     void Start()
    {
        rend = obj.GetComponent<Image>();
    }

    void OnMouseEnter()
    {
        rend.color = new Color32(248, 216, 43,255);
    }

    // ...and the mesh finally turns white when the mouse moves away.
    void OnMouseExit()
    {
        rend.color = Color.white;
    }

    void OnMouseDown()
    {
        // Destroy the gameObject after clicking on it
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
    