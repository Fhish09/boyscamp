using UnityEngine;

namespace Boyscamp.Network
{
    public class RoomManager : MonoBehaviour
    {
        public string currentRoomId;
        public int maxPlayers = 100;

        public void CreateRoom(string roomName)
        {
            currentRoomId = System.Guid.NewGuid().ToString();
            Debug.Log("Room created: " + currentRoomId);
        }

        public void JoinRoom(string roomId)
        {
            currentRoomId = roomId;
            Debug.Log("Joined room: " + roomId);
        }

        public void LeaveRoom()
        {
            currentRoomId = null;
            Debug.Log("Left room");
        }
    }
}
