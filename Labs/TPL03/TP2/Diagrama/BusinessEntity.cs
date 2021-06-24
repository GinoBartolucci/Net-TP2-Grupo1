using System;
using System.Collections.Generic;
using System.Text;

namespace Diagrama
{
    public class BusinessEntity
    {
        public enum States
        {
            Deleted, New, Modified, Unmodified
        }

        private int _ID;
        private States _State;

        public int ID
        {
            get => default;
            set
            {
            }
        }

        public States State
        {
            get => default;
            set
            {
            }
        }
    }
}