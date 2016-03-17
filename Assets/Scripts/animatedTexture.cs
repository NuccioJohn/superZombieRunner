using UnityEngine;
using System.Collections;

public class animatedTexture : MonoBehaviour {

	public Vector2 speed = Vector2.zero;

	private Vector2 offset = Vector2.zero;
	private Material material;

	// Use this for initialization
	void Start () {
		material = GetComponent<Renderer> ().material;

		offset = material.GetTextureOffset ("_MainTex");
	}
	
	// Update is called once per frame
	void Update () {
		offset += speed * Time.deltaTime;

		material.SetTextureOffset ("_MainTex", offset);
	}

	static void caculate(){
		int A = 12;
		int B = 13;

		int test = A + B;

		System.Console.WriteLine ("This is a test of mathemtatics" + test);
	}
}

