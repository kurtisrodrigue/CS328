using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTrap : MonoBehaviour {

    private Animator anim;
    private SpriteRenderer SR;
    public float trap_speed;
    public GameObject player;

    void Start () 
    {
        anim = GetComponent<Animator>();
        anim.speed = trap_speed;
        SR = GetComponent<SpriteRenderer>();
	}
	
	void Update () 
    {
		// if character position == this position
        // might have to use a different method to check if this doesnt work
        if(player.transform.position == transform.position)
        {
            // if the spikes are up
            if(SR.sprite.name == "spike_animation_4" ||
               SR.sprite.name == "spike_animation_5")
            {
                // kill the player, restart the game
                // perhaps use invoke
            }
        }
	}
}
