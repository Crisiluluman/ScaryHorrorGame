using UnityEngine;

namespace Input_Manager_and_Camera.PlayerControls
{
    public class PlayerRayCasting : MonoBehaviour
    {
        //Useful class to see distance to different targets
        //As well as using this class to interact with certain objects, like the door
        public static float distanceFromTarget;
        
        
        [SerializeField]
        private float toTarget;

        //public static RaycastHit hit;


        void Update()
        {

            RaycastHit hit;

            if (Physics.Raycast(transform.position,transform.TransformDirection(Vector3.forward), out hit))
            {
                //getHitOb = hit;
                toTarget = hit.distance;
                distanceFromTarget = toTarget;
            }

        }
    }
}
