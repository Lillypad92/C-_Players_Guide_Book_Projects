using System;

namespace The_C__player_s_guide.Assignments.Other.CataCombsClass.TheLockedDoor
{
    public enum DoorState { Locked, Open, Closed }
    public class Door
    {
        public DoorState currentState = DoorState.Closed;
        private int _currentCode;
        public Door(int Startingpasscode) 
        {
            _currentCode = Startingpasscode;
        }
        
        public void Open() 
        {
            if (currentState == DoorState.Closed)
            {
                currentState = DoorState.Open;
            }
        }
        public void Close() 
        {
            if (currentState == DoorState.Open)
            {
                currentState = DoorState.Closed;
            }
            
        }
        public void Lock() 
        {
            if (currentState == DoorState.Closed)
            {
                currentState = DoorState.Locked;
            }
        }
        public void Unlocked(int passcode) 
        {
            if (currentState == DoorState.Locked && passcode == _currentCode)
            {
                currentState = DoorState.Closed;
            }
        }
        public void ChangePassword(int currentCode, int newCode) 
        { 
            if (currentCode == _currentCode) 
            { 
                _currentCode = newCode;
            }
        }

        
    }
}
