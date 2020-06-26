using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DNA : MonoBehaviour
{
    public float r;
    public float g;
    public float b;
    public float height;
    bool isDead = false;
    public float timeToDie = 0;
    SpriteRenderer sRenderer;
    Collider2D sCollider;

    // Start is called before the first frame update
    void Start()
    {
        sRenderer = GetComponent<SpriteRenderer>();
        sCollider = GetComponent<Collider2D>();
        sRenderer.color = new Color(r, g, b);
        this.transform.localScale = new Vector3(height, height, height);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        isDead = true;
        timeToDie = PopulationManager.elapsed;
        sRenderer.enabled = false;
        sCollider.enabled = false;
    }
}
