namespace ConsoleApp
{
    public class Test
    {
        public const float pi = 3.14f;
        public readonly float PI = 3.14f;
        private float _piProp = 3.14f;

        public float PIProp
        { get { return _piProp; } }

        public Test()
        {
            // pi = 3f;
            PI = 3f;
            _piProp = 3f;
        }

        public void ChangeValue()
        {
            //pi = 3f;
            //PI = 3f;
            _piProp = 3f;
        }
    }
}
