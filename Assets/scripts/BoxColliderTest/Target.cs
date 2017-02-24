using UnityEngine;
using System.Collections;

public class Target : MonoBehaviour {

    public GameObject m_FollowTarget = null;

    public float manSpeed = 6f;

	// Use this for initialization
	void Start () {
        m_FollowTarget = this.gameObject;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            m_FollowTarget.transform.Translate(Vector3.left * Time.deltaTime * manSpeed);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            m_FollowTarget.transform.Translate(-Vector3.left * Time.deltaTime * manSpeed);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            m_FollowTarget.transform.Translate(Vector3.forward * Time.deltaTime * manSpeed);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            m_FollowTarget.transform.Translate(-Vector3.forward * Time.deltaTime * manSpeed);
        }
	}

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("========================:" + collision.collider.name);
    }
}
