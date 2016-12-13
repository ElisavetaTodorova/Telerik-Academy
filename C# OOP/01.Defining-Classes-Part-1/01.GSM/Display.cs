

namespace _01.GSM
{
    public class Display
    {
        public Display(double size, long numberOfColors)
        {
            this.Size = size;
            this.NumberOfColors = numberOfColors;
        }

        public double Size { get; private set; }

        public long NumberOfColors { get; private set; }

        public override string ToString()
        {
            return string.Format("{0} {1}", this.Size, this.NumberOfColors);
        }
    }
}
