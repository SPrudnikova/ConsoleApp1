using System;

namespace hw_10
{
    public interface IShape
    {
        string Name { get; set; }
        double GetArea();
    }
}
