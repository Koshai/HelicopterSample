using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IndiePixel
{
    public class IP_KeyboardHeli_Input : IP_Base_Input
    {
        #region Variables
        #endregion

        #region Properties
        private float throttleInput = 0f;
        public float ThrottleInput
        {
            get { return throttleInput; }
        }
        private float collectiveInput = 0f;
        public float CollectiveInput
        {
            get { return collectiveInput; }
        }
        private Vector2 cyclicInput = Vector2.zero;
        public Vector2 CyclicInput
        {
            get { return cyclicInput; }
        }
        private float pedalInput = 0f;
        public float PedalInput
        {
            get { return pedalInput; }
        }
        #endregion

        #region Builtin Methods

        #endregion

        #region Custom Methods
        protected override void HandleInputs()
        {
            base.HandleInputs();

            HandleThrottle();
            HandleCollective();
            HandleCyclic();
            HandlePedal();
        }

        void HandleThrottle()
        {
            throttleInput = Input.GetAxis("Throttle");
        }

        void HandleCollective()
        {
            collectiveInput = Input.GetAxis("Collective");
        }

        void HandleCyclic()
        {
            cyclicInput.y = vertical;
            cyclicInput.x = horizontal;
        }

        void HandlePedal()
        {
            pedalInput = Input.GetAxis("Pedal");
        }
        #endregion
    }
}
