namespace IO.Unity3D.Source.HiZ
{
    //******************************************
    //  
    //
    // @Author: Kakashi
    // @Email: john.cha@qq.com
    // @Date: 2023-07-23 08:33
    //******************************************
    public class HiZ
    {
        private bool _Enable;
        
        public HiZ()
        {
        }

        public void Start()
        {
        }

        public void OnEnable()
        {
            _Enable = true;
        }

        public void OnDisable()
        {
            _Enable = false;
        }

        public void Add()
        {
            
        }

        public void Execute()
        {
            if (_Enable)
            {
                return;
            }
        }

        public void Destroy()
        {
        }
    }
}