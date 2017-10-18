using System;
using UnityEngine;


namespace UnityStandardAssets.Utility
{
    public class FollowTarget : MonoBehaviour
    {
        public Transform target;
        public Vector3 offset = new Vector3(0f, 7.5f, 0f);

		void Start()
		{
			print ("Start!");
			target = GameObject.Find("Drozdik").transform;
		}
        /*private void LateUpdate()
        {
			transform.position = target.position*Time.deltaTime + offset;
        }*/
		void FixedUpdate () {
			Vector2 toTarget = target.transform.position - transform.position;
			float speed = 1.5f;

			transform.Translate(toTarget * speed * Time.deltaTime);
		}
    }
}
