using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Cube : MonoBehaviourPun
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //没连photon或者不是我的的时候，跳过
        if (photonView.IsMine == false || PhotonNetwork.IsConnected==false)
        {
            return;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            this.transform.position -= new Vector3(-0.2f,0,0);
        }
    }
}
