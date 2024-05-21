using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoleRepository{

    Dictionary<int, RoleEntity> all;

    public RoleRepository(){
        all = new Dictionary<int, RoleEntity>();
    }

    public void Add(RoleEntity role){
        all.Add(role.id, role);
    }

    public bool TryGet(int id, out RoleEntity role){
        return all.TryGetValue(id, out role);
    }

    public void Remove(int id){
        all.Remove(id);
    }

    public void Foreach(Action<RoleEntity> action){
        foreach(var role in all.Values){
            action(role);
        }
    }

}
