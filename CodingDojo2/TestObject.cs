namespace CodingDojo2
{
    internal class TestObject
    {
        private int v1;
        private string v2;

        public TestObject(int v1, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}", v1, v2);
        }
    }
}