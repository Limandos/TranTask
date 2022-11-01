namespace Task
{
    class Carriage
    {
        public int Number { get; set; }
        public bool Light { get; set; }
        public Carriage Next { get; set; }
        public Carriage Previous { get; set; }
    }
}