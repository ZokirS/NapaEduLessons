namespace AayncProject
{
    internal class FileName : IFileName
    {
        public int MyProperty { get; set; }

        public void Method()
        {
        }
    }

    interface IFileName
    {
        public int MyProperty { get;}
        void Method();
    }
}
