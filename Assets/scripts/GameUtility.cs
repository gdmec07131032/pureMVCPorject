using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUtility
{

    public static Transform GetChild(GameObject root,string path)
    {
        Transform trans = root.transform.Find(path);
        if (trans == null) Debug.Log(path + "not find");
        return trans;
    }

    public static T GetChildCommponent<T>(GameObject root ,string path)where T : Component
    {
        Transform trans = root.transform.Find(path);
        if (trans == null) Debug.Log(path + "not find");
        T t = trans.GetComponent<T>();
        return t;
    }
}
