using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerReleaseScript : MonoBehaviour
{
    public GameObject stylizedCat;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey)
        {
            transform.GetChild(0).GetComponent<Animator>().SetBool("isSitting", false);
        }
    }
}
