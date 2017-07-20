using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Startup : MonoBehaviour {

    public ParticleSystem particlePrefab;

	void Start () {
        var p = GameObject.Instantiate<ParticleSystem>(particlePrefab);
        p.transform.position = new Vector3(-100, 10, 0);
        p.Play();
	}
}
