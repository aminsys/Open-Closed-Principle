namespace open_Closed_Principal
{
    public class ShapeNotOpenClosed
    {
        private readonly double _radius;
        private readonly double _width;
        private readonly string _type;

        #region initializer and finalizer

        public ShapeNotOpenClosed(double radius, double width, string type)
        {
            _radius = radius;
            _width = width;
            _type = type;
        }

        #endregion

        #region Methods

        public double getArea()
        {
            switch (_type)
            {
                case "square":
                    return Math.Pow(_width, 2);

                case "circle":
                    return Math.PI * Math.Pow(_radius, 2);
            }
            
            return 0;
        }

        #endregion

    }
}