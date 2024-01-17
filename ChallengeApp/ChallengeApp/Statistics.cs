namespace ChallengeApp
{
    public class Statistics
    {
        public Statistics()
        {
            this.Minimum = float.MaxValue;
            this.Maximum = float.MinValue;
            this.Average = 0;
        }
        public void CalculateStep(float point)
        {
            if (point < this.Minimum) this.Minimum = point;
            if (point > this.Maximum) this.Maximum = point;
            this.Average += point;
        }
        public float Minimum { get; set; }
        public float Maximum { get; set; }
        public float Average { get; set; }
    }
}
