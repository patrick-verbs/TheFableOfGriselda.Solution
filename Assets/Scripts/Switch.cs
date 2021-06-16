using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public GameObject otherPlayer;

    void OnMouseDown()
    {
        otherPlayer.GetComponent<PlayerMovement>().enabled = false;
        GetComponent<PlayerMovement>().enabled = true;
    }
    //public GameObject avatar1, avatar2;

    // int whichAvatarOn = 1;
    // // Start is called before the first frame update
    // void Start()
    // {
    //     avatar1.gameObject.SetActive (true);
    //     avatar2.gameObject.SetActive (false);
    // }

    // public void SwitchAvatar()
    // {
    //     switch(whichAvatarOn)
    //     {
    //         case 1:
    //         whichAvatarOn = 2;

    //         avatar1.gameObject.SetActive (false);
    //         avatar2.gameObject.SetActive (true);
    //         break;

    //         case 2:
    //         whichAvatarOn = 1;

    //         avatar1.gameObject.SetActive (true);
    //         avatar2.gameObject.SetActive (false);
    //         break;
    //     }
    // }
}
