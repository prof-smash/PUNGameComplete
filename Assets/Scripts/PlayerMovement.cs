using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerMovement : MonoBehaviour
{
    private PhotonView PV;

    // Start is called before the first frame update
    void Start()
    {
        PV = GetComponent<PhotonView>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PV.IsMine)
            Movement();

        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
    }

    void Movement()
    {
        float yMov = Input.GetAxis("Vertical");
        float xMov = Input.GetAxis("Horizontal");
        transform.position += new Vector3(xMov / 7.5f, yMov / 7.5f, 0);
    }
}
