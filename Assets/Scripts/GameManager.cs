using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private GameObject[] props;

    private int nbCompleted;

    [SerializeField]
    private GameObject winScreen;

    // Start is called before the first frame update
    void Start()
    {
        winScreen.SetActive(false);
        nbCompleted = 0;
        props = GameObject.FindGameObjectsWithTag("Slot");
        print("Nb slot " + props.Length);
    }

    // Update is called once per frame
    void Update()
    {
        nbCompleted = 0;

        foreach (GameObject lol in props)
        {
            if (lol.GetComponent<PropSlot>().completed)
            {
                nbCompleted++;
                print("nb completed " + nbCompleted);
            }
        }

        if (nbCompleted == props.Length)
        {
            winScreen.SetActive(true);
            Debug.Log("Victiore");
            Time.timeScale = 0.5f;
        }
    }
}
