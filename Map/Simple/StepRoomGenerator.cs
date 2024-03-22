using System;
using System.Collections.Generic;
using UnityEngine;

namespace Map
{
    public class StepRoomGenerator : MonoBehaviour
    {
        public GameObject StartPoint;
        [Header("房间尺寸")]
        public Vector2 MoveStep;

        public int roomSpace = 5;

        public int MaxRoomInRow = 5;
        public int MaxRoomInColumn = 5;
        
        
        private List<RoomBase> _rooms = new List<RoomBase>(8);
        private RoomBase[,] _map;
        public int RoomCount;

        
        
        
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                ClearRoom();
                DoGenerate(RoomCount);
            }
        }


        void ClearRoom()
        {
            
        }


        public void DoGenerate(int roomCount)
        {
            if (roomCount > MaxRoomInColumn * MaxRoomInRow)
            {
                Debug.Log("房间数过多");
                return;
            }

            _map = new RoomBase[MaxRoomInRow, MaxRoomInColumn];
        }

        public bool AddRoom(MapConst.Direction dir)
        {
            return false;
        }
    }
}