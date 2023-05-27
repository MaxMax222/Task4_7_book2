namespace Q18
{
    public class Shift
    {
        private string manager;
        private string worker1;
        private string worker2;

        public Shift(string manager = "m", string worker1 = "w1", string worker2 = "w2")
        {
            this.manager = manager;
            this.worker1 = worker1;
            this.worker2 = worker2;
        }
        public string Manager
        {
            get { return manager; }
            set { manager = value; }
        }

        public string Worker1
        {
            get { return worker1; }
            set { worker1 = value; }
        }

        public string Worker2
        {
            get { return worker2; }
            set { worker2 = value; }
        }

        public bool DoubleWorkers(string name)
        {
            return !manager.Equals(name) && !manager.Equals(name) && !worker1.Equals(name);
        }
        public override string ToString()
        {
            return $"Manager: {manager}, worker 1: {worker1}, worker 2: {worker2}";
        }
    }
}