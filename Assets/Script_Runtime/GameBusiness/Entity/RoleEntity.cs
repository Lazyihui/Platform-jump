using System;
using UnityEngine;

public class RoleEntity : MonoBehaviour {
    [SerializeField] Rigidbody2D rb;

    [SerializeField] SpriteRenderer sr;

    [SerializeField] Animator animator;

    public int id;


    public void Ctor() { }


}