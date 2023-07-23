using System;
using UnityEngine;

namespace IO.Unity3D.Source.HiZ
{
    //******************************************
    //  
    //
    // @Author: Kakashi
    // @Email: john.cha@qq.com
    // @Date: 2023-07-23 08:34
    //******************************************
    public class HiZComponent : MonoBehaviour
    {
        private HiZ _HiZ = new HiZ();
        
        public void Start()
        {
            _HiZ.Start();
        }

        public void Update()
        {
            _HiZ.Execute();
        }

        private void OnEnable()
        {
            _HiZ.OnEnable();
        }
        
        private void OnDisable()
        {
            _HiZ.OnDisable();
        }

        private void OnDestroy()
        {
            _HiZ.Destroy();
        }
    }
}