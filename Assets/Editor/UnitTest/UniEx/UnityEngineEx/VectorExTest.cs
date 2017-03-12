using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UniEx;
using UnityEngine;

namespace UniEx.Test
{
    public class VectorExTest : MonoBehaviour
    {

        [Test]
        public static void PutTest()
        {
            Vector3 hoge = new Vector3(1, 2, 3);
            Debug.Log(hoge + " : " + hoge.PutX(10));
            Debug.Log(hoge + " : " + hoge.PutY(10));
            Debug.Log(hoge + " : " + hoge.PutZ(10));
        }
    }
}