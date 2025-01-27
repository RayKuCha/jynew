/*
 * 金庸群侠传3D重制版
 * https://github.com/jynew/jynew
 *
 * 这是本开源项目文件头，所有代码均使用MIT协议。
 * 但游戏内资源和第三方插件、dll等请仔细阅读LICENSE相关授权协议文档。
 *
 * 金庸老先生千古！
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomTalkMan : MonoBehaviour {

    public string[] Words;

    MapRole mapRole;

	// Use this for initialization
	void Start () {
        mapRole = GetComponent<MapRole>();
        InvokeRepeating("RandomTalk",5,5);
	}
	
    void RandomTalk()
    {
        if(Words != null && Words.Length > 0 && mapRole != null)
        {
            mapRole.Say(Words[Random.Range(0, Words.Length - 1)]);
        }
    }

}
