using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float maxSpeed = .2f;
    public float speedIncrease = 10f;

    private Rigidbody2D _rb;
    private Vector2 _direction;

	// Use this for initialization
	void Start ()
    {
        _rb = this.GetComponent<Rigidbody2D>();
        print(_rb);
	}
	
	// Update is called once per frame
	void Update ()
    {
        var hor = Input.GetAxis("Horizontal");
        var ver = Input.GetAxis("Vertical");
        var dir = new Vector2(hor, ver);

        ThrusterMove(dir);
	}

    /// <summary>
    /// Describes the way movement is supposed to be performed in a given direction
    /// This movement is independent of controls.
    /// </summary>
    /// <param name="direction"></param>
    void ThrusterMove(Vector2 direction)
    {
        // TODO: Add speed cap
        _rb.AddForce(direction * speedIncrease);
    }
}
