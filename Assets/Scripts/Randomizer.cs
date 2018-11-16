using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomizer : MonoBehaviour {

    public Sprite[] faces;

    void OnMouseOver() {
        Debug.Log((Time.time * 10f) % 1f);
        if ((Time.time * 10f) % 1f < 0.2f)
            gameObject.GetComponent<SpriteRenderer>().sprite = faces[Random.Range(0, faces.Length)];
    }
}
