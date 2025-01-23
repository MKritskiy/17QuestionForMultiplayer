using Mirror;
using UnityEngine;

public class ServerScript : NetworkBehaviour
{
    void Update()
    {
        if (isServer)
        {
            if (Input.GetKeyDown(KeyCode.S))
            {
                string message = "Hello from server!";
                RpcSendMessageToClient(message);
            }
        }
    }

    [ClientRpc]
    void RpcSendMessageToClient(string message)
    {
        Debug.Log("Client received: " + message);
    }
}