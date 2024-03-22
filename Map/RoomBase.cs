using System;
using UnityEngine;

namespace Map
{
    public class RoomBase : MonoBehaviour
    {
        private RoomBase[] _neighbors = new RoomBase[4];

        public Vector3 RoomSize { get; private set; } = Vector3.zero;


        public RoomBase GetNeighbor(MapConst.Direction dir)
        {
            var index = (int) dir;
            return _neighbors[index];
        }

        public void SetRoomSize(int length, int width)
        {
            RoomSize = new Vector3(length,10,width);
        }

        public void DrawRoom()
        {
            Gizmos.DrawCube(this.transform.position, RoomSize);
        }

        public void DrawRoad()
        {
            //重复画也无所谓
        }

        private void OnDrawGizmos()
        {
            DrawRoom();
            DrawRoad();
        }
    }
}