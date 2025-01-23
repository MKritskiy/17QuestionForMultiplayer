using Mirror;
using UnityEngine;

public class ClientScript : NetworkBehaviour
{
    void Update()
    {
        if (isClient)
        {
            if (Input.GetKeyDown(KeyCode.C))
            {
                string message = "Hello from client!";
                CmdSendMessageToServer(message);
            }
        }
    }

    [Command]
    void CmdSendMessageToServer(string message)
    {
        Debug.Log("Server received: " + message);
    }
}
