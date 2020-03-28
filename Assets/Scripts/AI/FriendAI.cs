using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendAI : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        CharactersHandler.soliders.Add(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
